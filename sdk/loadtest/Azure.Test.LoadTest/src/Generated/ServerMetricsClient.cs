// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Test.LoadTest
{
    /// <summary> The ServerMetrics service client. </summary>
    public partial class ServerMetricsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ServerMetricsClient for mocking. </summary>
        protected ServerMetricsClient()
        {
        }

        /// <summary> Initializes a new instance of ServerMetricsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ServerMetricsClient(Uri endpoint = null, CloudNativeTestClientOptions options = null)
        {
            endpoint ??= new Uri("");
            options ??= new CloudNativeTestClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Associate server metrics config to a test model or test run. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateServerMetricsConfigAsync(string name, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.CreateOrUpdateServerMetricsConfig");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateServerMetricsConfigRequest(name, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Associate server metrics config to a test model or test run. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdateServerMetricsConfig(string name, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.CreateOrUpdateServerMetricsConfig");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateServerMetricsConfigRequest(name, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get server metrics config for a given name in query param. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetServerMetricsByNameAsync(string name, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerMetricsByName");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerMetricsByNameRequest(name, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get server metrics config for a given name in query param. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetServerMetricsByName(string name, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerMetricsByName");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerMetricsByNameRequest(name, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete server metrics config by given name. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> DeleteServerMetricsAsync(string name, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.DeleteServerMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteServerMetricsRequest(name, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete server metrics config by given name. </summary>
        /// <param name="name"> Unique identifier for server metric name, must be a valid URL character ^[a-z0-9_-]*$. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response DeleteServerMetrics(string name, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.DeleteServerMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteServerMetricsRequest(name, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get server metrics config for a test model or test run of given name in query param. </summary>
        /// <param name="testId"> Required testId, if testRunId name is not provided. </param>
        /// <param name="testRunId"> Required testRunId, if testId is not provided. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetServerMetricsAsync(string testId = null, string testRunId = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerMetricsRequest(testId, testRunId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get server metrics config for a test model or test run of given name in query param. </summary>
        /// <param name="testId"> Required testId, if testRunId name is not provided. </param>
        /// <param name="testRunId"> Required testRunId, if testId is not provided. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   name: string,
        ///   testId: string,
        ///   testRunId: string,
        ///   metrics: Dictionary&lt;string, ResourceMetricModel&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetServerMetrics(string testId = null, string testRunId = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerMetricsRequest(testId, testRunId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all default server metrics config with supported resource type. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   defaultMetrics: Dictionary&lt;string, DefaultServerMetricsConfigModel[]&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetServerDefaultMetricsAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerDefaultMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerDefaultMetricsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all default server metrics config with supported resource type. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   defaultMetrics: Dictionary&lt;string, DefaultServerMetricsConfigModel[]&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetServerDefaultMetrics(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetServerDefaultMetrics");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetServerDefaultMetricsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all supported resource types for app components(azure resource types). </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetSupportedResourceTypesAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetSupportedResourceTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSupportedResourceTypesRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all supported resource types for app components(azure resource types). </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponseBody]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetSupportedResourceTypes(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ServerMetricsClient.GetSupportedResourceTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSupportedResourceTypesRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateOrUpdateServerMetricsConfigRequest(string name, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200201.Instance;
            return message;
        }

        internal HttpMessage CreateGetServerMetricsByNameRequest(string name, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteServerMetricsRequest(string name, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier204.Instance;
            return message;
        }

        internal HttpMessage CreateGetServerMetricsRequest(string testId, string testRunId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig", false);
            if (testId != null)
            {
                uri.AppendQuery("testId", testId, true);
            }
            if (testRunId != null)
            {
                uri.AppendQuery("testRunId", testRunId, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetServerDefaultMetricsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetSupportedResourceTypesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/serverMetricsConfig/supportedResourceTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200201 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200201();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    201 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    204 => false,
                    _ => true
                };
            }
        }
    }
}
