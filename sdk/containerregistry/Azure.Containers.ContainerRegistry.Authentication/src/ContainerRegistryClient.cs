// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ContainerRegistry service client. </summary>
    public partial class ContainerRegistryClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRestClient RestClient { get; }

        public ContainerRegistryClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryClient(Uri endpoint, TokenCredential credential, ContainerRegistryClientOptions options)
        {
        }

        public ContainerRegistryClient(Uri endpoint, ContainerRegistryUserCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryClient(Uri endpoint, ContainerRegistryUserCredential credential, ContainerRegistryClientOptions options)
        {
        }

        public ContainerRegistryClient(Uri endpoint) : this(endpoint, new ContainerRegistryClientOptions())
        {
        }

        /// <summary>
        /// Anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="options"></param>
        public ContainerRegistryClient(Uri endpoint, ContainerRegistryClientOptions options)
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryClient for mocking. </summary>
        protected ContainerRegistryClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal ContainerRegistryClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        // TODO: I don't think these need to be part of public client API
        ///// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        ///// <param name="cancellationToken"> The cancellation token to use. </param>
        //public virtual async Task<Response> CheckDockerV2SupportAsync(CancellationToken cancellationToken = default)
        //{
        //    using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.CheckDockerV2Support");
        //    scope.Start();
        //    try
        //    {
        //        return await RestClient.CheckDockerV2SupportAsync(cancellationToken).ConfigureAwait(false);
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        ///// <param name="cancellationToken"> The cancellation token to use. </param>
        //public virtual Response CheckDockerV2Support(CancellationToken cancellationToken = default)
        //{
        //    using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.CheckDockerV2Support");
        //    scope.Start();
        //    try
        //    {
        //        return RestClient.CheckDockerV2Support(cancellationToken);
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        public Uri Endpoint { get; }

        public virtual Pageable<string> GetRepositories(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual AsyncPageable<string> GetRepositoriesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Get repository attributes. </summary>
        /// <param name="respository"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RepositoryProperties>> GetRepositoryPropertiesAsync(string respository, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositoryAttributes");
            scope.Start();
            try
            {
                return await RestClient.GetRepositoryAttributesAsync(respository, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get repository attributes. </summary>
        /// <param name="respository"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RepositoryProperties> GetRepositoryProperties(string respository, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositoryAttributes");
            scope.Start();
            try
            {
                return RestClient.GetRepositoryAttributes(respository, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="respository"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeleteRepositoryResult>> DeleteRepositoryAsync(string respository, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
            scope.Start();
            try
            {
                return await RestClient.DeleteRepositoryAsync(respository, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="respository"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeleteRepositoryResult> DeleteRepository(string respository, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
            scope.Start();
            try
            {
                return RestClient.DeleteRepository(respository, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        public virtual RepositoryClient GetRepositoryClient(string respository)
        {
            throw new NotImplementedException();
        }
    }
}
