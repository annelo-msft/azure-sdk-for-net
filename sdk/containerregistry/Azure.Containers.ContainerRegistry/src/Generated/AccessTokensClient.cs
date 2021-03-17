// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The AccessTokens service client. </summary>
    public partial class AccessTokensClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AccessTokensRestClient RestClient { get; }

        /// <summary> Initializes a new instance of AccessTokensClient for mocking. </summary>
        protected AccessTokensClient()
        {
        }

        /// <summary> Initializes a new instance of AccessTokensClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal AccessTokensClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new AccessTokensRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Exchange ACR Refresh token for an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Which is expected to be a valid scope, and can be specified more than once for multiple scope requests. You obtained this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="refreshToken"> Must be a valid ACR refresh token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AccessToken>> GetAsync(string service, string scope, string refreshToken, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("AccessTokensClient.Get");
            scope0.Start();
            try
            {
                return await RestClient.GetAsync(service, scope, refreshToken, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Exchange ACR Refresh token for an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Which is expected to be a valid scope, and can be specified more than once for multiple scope requests. You obtained this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="refreshToken"> Must be a valid ACR refresh token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessToken> Get(string service, string scope, string refreshToken, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("AccessTokensClient.Get");
            scope0.Start();
            try
            {
                return RestClient.Get(service, scope, refreshToken, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Exchange Username, Password and Scope an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Expected to be a valid scope, and can be specified more than once for multiple scope requests. You can obtain this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AccessToken>> GetFromLoginAsync(string service, string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("AccessTokensClient.GetFromLogin");
            scope0.Start();
            try
            {
                return await RestClient.GetFromLoginAsync(service, scope, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Exchange Username, Password and Scope an ACR Access Token. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="scope"> Expected to be a valid scope, and can be specified more than once for multiple scope requests. You can obtain this from the Www-Authenticate response header from the challenge. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessToken> GetFromLogin(string service, string scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("AccessTokensClient.GetFromLogin");
            scope0.Start();
            try
            {
                return RestClient.GetFromLogin(service, scope, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
