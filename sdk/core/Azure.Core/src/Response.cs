﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Buffers;
using Azure.Core.Pipeline;

namespace Azure
{
    /// <summary>
    /// Represents the HTTP response from the service.
    /// </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public abstract class Response : PipelineResponse
#pragma warning restore AZC0012 // Avoid single word type names
    {
        // TODO(matell): The .NET Framework team plans to add BinaryData.Empty in dotnet/runtime#49670, and we can use it then.
        private static readonly BinaryData s_EmptyBinaryData = new(Array.Empty<byte>());

        /// <summary>
        /// Gets the client request id that was sent to the server as <c>x-ms-client-request-id</c> headers.
        /// </summary>
        public abstract string ClientRequestId { get; set; }

        /// <summary>
        /// Get the HTTP response headers.
        /// </summary>
        public new virtual ResponseHeaders Headers => new ResponseHeaders(this);

        /// <summary>
        /// Gets the value of <see cref="PipelineResponse.Headers"/> on
        /// the base <see cref="PipelineResponse"/> type.
        /// </summary>
        protected override PipelineResponseHeaders HeadersCore
            => new ResponseHeadersAdapter(Headers);

        /// <summary>
        /// Gets the contents of HTTP response, if it is available.
        /// </summary>
        /// <remarks>
        /// Throws <see cref="InvalidOperationException"/> when content is not buffered.
        /// </remarks>
        public override BinaryData Content
        {
            get
            {
                if (ContentStream is null || ContentStream is MemoryStream)
                {
                    return BufferContent();
                }

                throw new InvalidOperationException($"The response is not buffered.");
            }
        }

        internal HttpMessageSanitizer Sanitizer { get; set; } = HttpMessageSanitizer.Default;

        internal RequestFailedDetailsParser? RequestFailedDetailsParser { get; set; }

        internal void SetIsError(bool value) => IsErrorCore = value;

        /// <summary>
        /// Returns header value if the header is stored in the collection. If header has multiple values they are going to be joined with a comma.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="value">The reference to populate with value.</param>
        /// <returns><c>true</c> if the specified header is stored in the collection, otherwise <c>false</c>.</returns>
        protected internal abstract bool TryGetHeader(string name, [NotNullWhen(true)] out string? value);

        /// <summary>
        /// Returns header values if the header is stored in the collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="values">The reference to populate with values.</param>
        /// <returns><c>true</c> if the specified header is stored in the collection, otherwise <c>false</c>.</returns>
        protected internal abstract bool TryGetHeaderValues(string name, [NotNullWhen(true)] out IEnumerable<string>? values);

        /// <summary>
        /// Returns <c>true</c> if the header is stored in the collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <returns><c>true</c> if the specified header is stored in the collection, otherwise <c>false</c>.</returns>
        protected internal abstract bool ContainsHeader(string name);

        /// <summary>
        /// Returns an iterator for enumerating <see cref="HttpHeader"/> in the response.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{T}"/> enumerating <see cref="HttpHeader"/> in the response.</returns>
        protected internal abstract IEnumerable<HttpHeader> EnumerateHeaders();

        /// <summary>
        /// Creates a new instance of <see cref="Response{T}"/> with the provided value and HTTP response.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="response">The HTTP response.</param>
        /// <returns>A new instance of <see cref="Response{T}"/> with the provided value and HTTP response.</returns>
        public static Response<T> FromValue<T>(T value, Response response)
            => new AzureCoreResponse<T>(value, response);

        /// <summary>
        /// Returns the string representation of this <see cref="Response"/>.
        /// </summary>
        /// <returns>The string representation of this <see cref="Response"/></returns>
        public override string ToString()
        {
            return $"Status: {Status}, ReasonPhrase: {ReasonPhrase}";
        }

        internal static void DisposeStreamIfNotBuffered(ref Stream? stream)
        {
            // We want to keep the ContentStream readable
            // even after the response is disposed but only if it's a
            // buffered memory stream otherwise we can leave a network
            // connection hanging open
            if (stream is not MemoryStream)
            {
                stream?.Dispose();
                stream = null;
            }
        }

        /// <inheritdoc/>
        public override BinaryData BufferContent(CancellationToken cancellationToken = default)
            => BufferContentSyncOrAsync(cancellationToken, async: false).EnsureCompleted();

        /// <inheritdoc/>
        public override async ValueTask<BinaryData> BufferContentAsync(CancellationToken cancellationToken = default)
            => await BufferContentSyncOrAsync(cancellationToken, async: true).ConfigureAwait(false);

        private async ValueTask<BinaryData> BufferContentSyncOrAsync(CancellationToken cancellationToken, bool async)
        {
            // Derived types should provide an implementation that allows caching
            // to improve performance.
            if (ContentStream is null)
            {
                return s_EmptyBinaryData;
            }

            if (ContentStream is MemoryStream memoryStream)
            {
                return memoryStream.TryGetBuffer(out ArraySegment<byte> segment) ?
                    new BinaryData(segment.AsMemory()) :
                    new BinaryData(memoryStream.ToArray());
            }

            BufferedContentStream bufferStream = new();

            Stream? contentStream = ContentStream;
            if (async)
            {
                await contentStream.CopyToAsync(bufferStream, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                contentStream.CopyTo(bufferStream, cancellationToken);
            }

            contentStream.Dispose();

            bufferStream.Position = 0;
            ContentStream = bufferStream;

            BinaryData content = BinaryData.FromStream(bufferStream);
            bufferStream.Position = 0;

            return content;
        }

        private class BufferedContentStream : MemoryStream { }

        /// <summary>
        /// Internal implementation of abstract <see cref="Response{T}"/>.
        /// </summary>
        private class AzureCoreResponse<T> : Response<T>
        {
            public AzureCoreResponse(T value, Response response)
                : base(value, response) { }
        }

        /// <summary>
        /// This adapter adapts the Azure.Core <see cref="ResponseHeaders"/>
        /// type to the System.ClientModel <see cref="PipelineResponseHeaders"/>
        /// interface, so that <see cref="Response"/> can implement the
        /// <see cref="HeadersCore"/> property inherited from
        /// <see cref="PipelineResponse"/>.
        /// </summary>
        private class ResponseHeadersAdapter : PipelineResponseHeaders
        {
            /// <summary>
            /// Headers on the Azure.Core Response type to adapt to.
            /// </summary>
            private readonly ResponseHeaders _headers;

            public ResponseHeadersAdapter(ResponseHeaders headers)
            {
                _headers = headers;
            }

            public override bool TryGetValue(string name, out string? value)
                => _headers.TryGetValue(name, out value);

            public override bool TryGetValues(string name, out IEnumerable<string>? values)
                => _headers.TryGetValues(name, out values);

            public override IEnumerator<KeyValuePair<string, string>> GetEnumerator()
                => GetHeaderValues().GetEnumerator();

            private IEnumerable<KeyValuePair<string, string>> GetHeaderValues()
            {
                foreach (HttpHeader header in _headers)
                {
                    yield return new KeyValuePair<string, string>(header.Name, header.Value);
                }
            }
        }
    }
}
