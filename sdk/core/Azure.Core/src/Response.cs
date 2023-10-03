﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.ServiceModel.Rest.Core.Pipeline;
using Azure.Core;

namespace Azure
{
    /// <summary>
    /// Represents the HTTP response from the service.
    /// </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public abstract class Response : RestResponse
#pragma warning restore AZC0012 // Avoid single word type names
    {
        /// <summary>
        /// Gets the client request id that was sent to the server as <c>x-ms-client-request-id</c> headers.
        /// </summary>
        public abstract string ClientRequestId { get; set; }

        /// <summary>
        /// TBD.
        /// </summary>
        public Response() : base(null,null)
        {
            // TODO: this shouldn't be called, but is required for back-compat.
        }

        internal Response(HttpResponseMessage httpResponse, Stream? contentStream)
            : base(httpResponse, contentStream)
        {
        }

        /// <summary>
        /// Get the HTTP response headers.
        /// </summary>
        public virtual ResponseHeaders Headers => new ResponseHeaders(this);

        internal HttpMessageSanitizer Sanitizer { get; set; } = HttpMessageSanitizer.Default;

        internal RequestFailedDetailsParser? RequestFailedDetailsParser { get; set; }

        ///// <summary>
        ///// TBD.
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="value"></param>
        ///// <returns></returns>
        //public override bool TryGetHeaderValue(string name, out string? value)
        //    => TryGetHeader(name, out value);

        internal bool TryGetHeaderValuesInternal(string name, [NotNullWhen(true)] out IEnumerable<string>? values)
            => TryGetHeaderValues(name, out values);

        internal bool ContainsHeaderInternal(string name)
            => ContainsHeader(name);

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
        {
            return new ValueResponse<T>(response, value);
        }

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
    }
}
