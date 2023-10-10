// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.ServiceModel.Rest.Core;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    /// <summary>
    /// Represents an HTTP request. Use <see cref="HttpPipeline.CreateMessage()"/> or <see cref="HttpPipeline.CreateRequest"/> to create an instance.
    /// </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public abstract class Request : PipelineRequest
#pragma warning restore AZC0012 // Avoid single word type names
    {
        private RequestUriBuilder? _uriBuilder;

        /// <summary>
        /// Gets or sets and instance of <see cref="RequestUriBuilder"/> used to create the Uri.
        /// </summary>
        public virtual RequestUriBuilder Uri
        {
            get
            {
                return _uriBuilder ??= new RequestUriBuilder();
            }
            set
            {
                Argument.AssertNotNull(value, nameof(value));
                _uriBuilder = value;
            }
        }

        /// <summary>
        /// Gets or sets the request HTTP method.
        /// </summary>
        public virtual RequestMethod Method
        {
            get
            {
                try
                {
                    TryGetMethod(out string method);
                    return SystemToAzureMethod(method);
                }
                catch (InvalidOperationException)
                {
                    // Preserve existing Azure.Core functionality
                    return new RequestMethod();
                }
            }
            set { SetMethod(value.Method); }
        }

        private static RequestMethod SystemToAzureMethod(string verb)
        {
            return verb switch
            {
                "GET" => RequestMethod.Get,
                "POST" => RequestMethod.Post,
                "PUT" => RequestMethod.Put,
                "HEAD" => RequestMethod.Head,
                "DELETE" => RequestMethod.Delete,
                "PATCH" => RequestMethod.Patch,
                _ => new RequestMethod(verb),
            };
        }

        // PATCH value needed for compat with pre-net5.0 TFMs
        private static readonly HttpMethod _patchMethod = new HttpMethod("PATCH");

        private static HttpMethod AzureToSystemMethod(RequestMethod method)
        {
            return method.Method switch
            {
                "GET" => HttpMethod.Get,
                "POST" => HttpMethod.Post,
                "PUT" => HttpMethod.Put,
                "HEAD" => HttpMethod.Head,
                "DELETE" => HttpMethod.Delete,
                "PATCH" => _patchMethod,
                _ => new HttpMethod(method.Method),
            };
            ;
        }

        /// <summary>
        /// Gets or sets the request content.
        /// </summary>

        public new abstract RequestContent? Content { get; set; }

        /// <summary>
        /// Gets or sets the client request id that was sent to the server as <c>x-ms-client-request-id</c> headers.
        /// </summary>
        public abstract string ClientRequestId { get; set; }

        /// <summary>
        /// Returns an iterator enumerating <see cref="HttpHeader"/> in the request.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{T}"/> enumerating <see cref="HttpHeader"/> in the response.</returns>
        protected internal abstract IEnumerable<HttpHeader> EnumerateHeaders();

        /// <summary>
        /// Gets the response HTTP headers.
        /// </summary>
        public new RequestHeaders Headers => new(this);
    }
}
