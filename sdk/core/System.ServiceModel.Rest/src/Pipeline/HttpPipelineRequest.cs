// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.ServiceModel.Rest.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace System.ServiceModel.Rest.Core.Pipeline;

// This adds the Http dependency, and some implementation

internal class HttpPipelineRequest : PipelineRequest, IDisposable
{
    private const string AuthorizationHeaderName = "Authorization";
    private static readonly Uri _invalidUri = new("http://www.example.com");

    private HttpMethod _method;
    private Uri? _uri;
    private RequestBody? _content;
    private MessageRequestHeaders? _headers;

    public HttpPipelineRequest()
    {
        // Default to get is validated in Azure.Core unit tests.
        // TODO: Would it be better to be explicit and put this in the constructor?
        _method = HttpMethod.Get;
    }

    public override void SetUri(Uri uri) => _uri = uri;

    public override bool TryGetUri(out Uri uri)
    {
        if (_uri is not null)
        {
            uri = _uri;
            return true;
        }

        uri = _invalidUri;
        return false;
    }

    public override RequestBody? Content
    {
        get => _content;
        set => _content = value;
    }

    public override MessageHeaders Headers => _headers ??= new MessageRequestHeaders();

    public override void SetMethod(string method)
        => _method = ToHttpMethod(method);

    public override bool TryGetMethod(out string method)
    {
        method = _method.Method;
        return true;
    }

    // PATCH value needed for compat with pre-net5.0 TFMs
    private static readonly HttpMethod _patchMethod = new HttpMethod("PATCH");

    private HttpMethod ToHttpMethod(string method)
    {
        return method switch
        {
            "GET" => HttpMethod.Get,
            "POST" => HttpMethod.Post,
            "PUT" => HttpMethod.Put,
            "HEAD" => HttpMethod.Head,
            "DELETE" => HttpMethod.Delete,
            "PATCH" => _patchMethod,
            _ => new HttpMethod(method),
        }; ;
    }

    #region Construction for transport

    internal HttpRequestMessage BuildRequestMessage(PipelineMessage? message = default)
    {
        Uri uri;
        TryGetUri(out uri);
        HttpRequestMessage httpRequest = new HttpRequestMessage(_method, uri);
        CancellationToken cancellationToken = message?.CancellationToken ?? default;

        PipelineContentAdapter? httpContent = _content != null ? new PipelineContentAdapter(_content, cancellationToken) : null;
        httpRequest.Content = httpContent;
#if NETSTANDARD
        httpRequest.Headers.ExpectContinue = false;
#endif

        Headers.TryGetHeaders(out IEnumerable<MessageHeader<string, object>> headers);
        foreach (MessageHeader<string, object> header in headers)
        {
            switch (header.Value)
            {
                case string stringValue:
                    // Authorization is special cased because it is in the hot path for auth polices that set this header on each request and retry.
                    if (header.Name == AuthorizationHeaderName && AuthenticationHeaderValue.TryParse(stringValue, out var authHeader))
                    {
                        httpRequest.Headers.Authorization = authHeader;
                    }
                    else if (!httpRequest.Headers.TryAddWithoutValidation(header.Name, stringValue))
                    {
                        if (httpContent != null && !httpContent.Headers.TryAddWithoutValidation(header.Name, stringValue))
                        {
                            throw new InvalidOperationException($"Unable to add header {header.Name} to header collection.");
                        }
                    }
                    break;

                case List<string> listValue:
                    if (!httpRequest.Headers.TryAddWithoutValidation(header.Name, listValue))
                    {
                        if (httpContent != null && !httpContent.Headers.TryAddWithoutValidation(header.Name, listValue))
                        {
                            throw new InvalidOperationException($"Unable to add header {header.Name} to header collection.");
                        }
                    }
                    break;
            }
        }

        return httpRequest;
    }

    private sealed class PipelineContentAdapter : HttpContent
    {
        private readonly RequestBody _pipelineContent;
        private readonly CancellationToken _cancellationToken;

        public PipelineContentAdapter(RequestBody pipelineContent, CancellationToken cancellationToken)
        {
            _pipelineContent = pipelineContent;
            _cancellationToken = cancellationToken;
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext? context)
            => await _pipelineContent.WriteToAsync(stream, _cancellationToken).ConfigureAwait(false);

        protected override bool TryComputeLength(out long length)
            => _pipelineContent.TryComputeLength(out length);

#if NET5_0_OR_GREATER
        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext? context, CancellationToken cancellationToken)
            => await _pipelineContent!.WriteToAsync(stream, cancellationToken).ConfigureAwait(false);

        protected override void SerializeToStream(Stream stream, TransportContext? context, CancellationToken cancellationToken)
            => _pipelineContent.WriteTo(stream, cancellationToken);
#endif
    }

    #endregion

    public virtual void Dispose()
    {
        var content = _content;
        if (content != null)
        {
            _content = null;
            content.Dispose();
        }

        GC.SuppressFinalize(this);
    }

    public override string ToString() => BuildRequestMessage().ToString();
}
