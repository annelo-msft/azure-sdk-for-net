﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace System.ClientModel.Primitives;

public partial class HttpClientPipelineTransport
{
    private class HttpClientPipelineResponse : PipelineResponse
    {
        private readonly HttpResponseMessage _httpResponse;

        // We keep a reference to the http response content so it will be available
        // for reading headers, even if we set _httpResponse.Content to null when we
        // buffer the content.  Since we handle disposing the content separately, we
        // don't believe there is a concern about rooting objects that are holding
        // references to network resources.
        private readonly HttpContent _httpResponseContent;

        private Stream? _contentStream;

        private bool _disposed;

        public HttpClientPipelineResponse(HttpResponseMessage httpResponse)
        {
            _httpResponse = httpResponse ?? throw new ArgumentNullException(nameof(httpResponse));
            _httpResponseContent = _httpResponse.Content;
        }

        public override int Status => (int)_httpResponse.StatusCode;

        public override string ReasonPhrase
            => _httpResponse.ReasonPhrase ?? string.Empty;

        protected override PipelineResponseHeaders GetHeadersCore()
            => new HttpClientResponseHeaders(_httpResponse.Headers, _httpResponseContent);

        private byte[]? _contentBytes;
        public override BinaryData Content
        {
            get
            {
                if (BufferResponseRequested)
                {
                    if (_contentBytes is null)
                    {
                        return s_emptyBinaryData;
                    }

                    return BinaryData.FromBytes(_contentBytes);
                }
                else
                {
                    if (_contentStreamRead)
                    {
                        throw new InvalidOperationException("Network stream has already been accessed via ContentStream property.");
                    }
                    else
                    {
                        if (ContentStream is null)
                        {
                            return s_emptyBinaryData;
                        }

                        return BinaryData.FromStream(ContentStream);
                    }
                }
            }
        }

        private bool _contentStreamRead = false;
        public override Stream? ContentStream
        {
            get
            {
                _contentStreamRead = true;
                return _contentStream;
            }
            set
            {
                // We null the HttpResponseMessage.Content property to ensure
                // that when we dispose the message, we don't also dispose the
                // content we need for reading header values later on.
                _httpResponse.Content = null;

                _contentStream = value;
            }
        }

        #region IDisposable

        public override void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                var httpResponse = _httpResponse;
                httpResponse?.Dispose();

                // Some notes on this:
                //
                // 1. If the content is buffered, we want it to remain available to the
                // client for model deserialization and in case the end user of the
                // client calls OutputMessage.GetRawResponse. So, we don't dispose it.
                //
                // If the content is buffered, we assume that the entity that did the
                // buffering took responsibility for disposing the network stream.
                //
                // 2. If the content is not buffered, we dispose it so that we don't leave
                // a network connection open.
                //
                // One tricky piece here is that in some cases, we may not have buffered
                // the content because we wanted to pass the live network stream out of
                // the client method and back to the end-user caller of the client e.g.
                // for a streaming API.  If the latter is the case, the client should have
                // called the HttpMessage.ExtractResponseContent method to obtain a reference
                // to the network stream, and the response content was replaced by a stream
                // that we are ok to dispose here.  In this case, the network stream is
                // not disposed, because the entity that replaced the response content
                // intentionally left the network stream undisposed.

                var contentStream = _contentStream;
                if (contentStream is not null && !TryGetBufferedContent(out _))
                {
                    contentStream?.Dispose();
                    _contentStream = null;
                }

                _disposed = true;
            }
        }
        #endregion
    }

    // TODO: remove duplication
    private static void WrapNetworkStream(PipelineMessage message, TimeSpan networkTimeout)
    {
        if (networkTimeout != Timeout.InfiniteTimeSpan)
        {
            Stream contentStream = message.Response!.ContentStream!;
            message.Response!.ContentStream = new ReadTimeoutStream(contentStream, networkTimeout);
        }
    }
}
