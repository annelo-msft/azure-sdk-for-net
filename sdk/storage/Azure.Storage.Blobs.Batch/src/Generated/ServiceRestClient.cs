// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Storage.Blobs.Batch
{
    internal partial class ServiceRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _version;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, container, or blob that is the targe of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. The default value is "2020-06-12". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        /// <summary> The Batch operation allows multiple API calls to be embedded into a single HTTP request. </summary>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="body"> Initial data. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multipartContentType"/> or <paramref name="body"/> is null. </exception>
        public async Task<Core.ResponseWithHeaders<Stream, ServiceSubmitBatchHeaders>> SubmitBatchAsync(long contentLength, string multipartContentType, Stream body, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (multipartContentType == null)
            {
                throw new ArgumentNullException(nameof(multipartContentType));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSubmitBatchRequest(contentLength, multipartContentType, body, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceSubmitBatchHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        var value = message.ExtractResponseContent();
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The Batch operation allows multiple API calls to be embedded into a single HTTP request. </summary>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="body"> Initial data. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multipartContentType"/> or <paramref name="body"/> is null. </exception>
        public Core.ResponseWithHeaders<Stream, ServiceSubmitBatchHeaders> SubmitBatch(long contentLength, string multipartContentType, Stream body, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (multipartContentType == null)
            {
                throw new ArgumentNullException(nameof(multipartContentType));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSubmitBatchRequest(contentLength, multipartContentType, body, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceSubmitBatchHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        var value = message.ExtractResponseContent();
                        return Core.ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSubmitBatchRequest(long contentLength, string multipartContentType, RequestContent content, int? timeout, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("comp", "batch", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            request.Headers.Add("Content-Length", contentLength);
            request.Headers.Add("Content-Type", multipartContentType);
            request.Content = content;
            return message;
        }

        /// <summary>
        /// [Protocol Method] The Batch operation allows multiple API calls to be embedded into a single HTTP request.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multipartContentType"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> SubmitBatchAsync(long contentLength, string multipartContentType, RequestContent content, int? timeout = null, RequestContext context = null)
        {
            Argument.AssertNotNull(multipartContentType, nameof(multipartContentType));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Service.SubmitBatch");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSubmitBatchRequest(contentLength, multipartContentType, content, timeout, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] The Batch operation allows multiple API calls to be embedded into a single HTTP request.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="multipartContentType"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response SubmitBatch(long contentLength, string multipartContentType, RequestContent content, int? timeout = null, RequestContext context = null)
        {
            Argument.AssertNotNull(multipartContentType, nameof(multipartContentType));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Service.SubmitBatch");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSubmitBatchRequest(contentLength, multipartContentType, content, timeout, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
