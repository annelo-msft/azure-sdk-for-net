// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Net.Http;

namespace System.ClientModel.Primitives;

public partial class HttpClientPipelineTransport
{
    private class HttpPipelineResponse : PipelineResponse
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

        public HttpPipelineResponse(HttpResponseMessage httpResponse)
        {
            _httpResponse = httpResponse ?? throw new ArgumentNullException(nameof(httpResponse));
            _httpResponseContent = _httpResponse.Content;
        }

        public override int Status => (int)_httpResponse.StatusCode;

        public override string ReasonPhrase
            => _httpResponse.ReasonPhrase ?? string.Empty;

        protected override PipelineResponseHeaders GetHeadersCore()
            => new HttpClientResponseHeaders(_httpResponse, _httpResponseContent);

        public override Stream? ContentStream
        {
            get => _contentStream;
            set
            {
                // Make sure we don't dispose the content if the stream was replaced
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
                HttpResponseMessage httpResponse = _httpResponse;
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
                // If the response has not been buffered, this is because a client or
                // other caller of pipeline.Send set message.BufferResponse = false.
                // The reason to do this in a client is because the client is providing
                // a streaming API in which it passes the live network stream to the caller
                // of a a service method.
                //
                // In clients with protocol methods, clients must call ExtractResponse
                // to allow returning an undisposed response from the protocol method.
                // In this case, the caller of the protocol method is responsible for
                // disposing the response, which will dispose the network stream with it.
                //
                // In some Azure.Core-based client convenince methods in libraries without
                // protocol methods, the client may have called HttpMessage's
                // ExtractResponseContent method to obtain a reference to the network
                // stream instead of ExtractResponse.  If that is the case, the response
                // content was replaced by a stream that makes dispose here a no-op.
                // In this case, the caller of the protocol method is also responsible for
                // disposing the network stream returned from the convenience method, but
                // will do so by disposing the stream directly, rather than disposing the
                // response that holds it.

                if (!IsBuffered)
                {
                    Stream? contentStream = _contentStream;
                    contentStream?.Dispose();
                    _contentStream = null;
                }

                _disposed = true;
            }
        }
        #endregion
    }
}
