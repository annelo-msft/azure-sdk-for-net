// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry.Specialized;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ContainerRegistryRepository service client. </summary>
    public partial class RepositoryClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRepositoryRestClient RestClient { get; }

        // Name of the image (including the namespace).
        private string _repository;

        public RepositoryClient(Uri endpoint, string repository, TokenCredential credential) : this(endpoint, repository, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repository, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _repository = repository;
        }

        public RepositoryClient(Uri endpoint, string repository, ContainerRegistryUserCredential credential) : this(endpoint, repository, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repository, ContainerRegistryUserCredential credential, ContainerRegistryClientOptions options)
        {
            _repository = repository;
        }

        /// <summary>
        /// anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="repository"></param>
        public RepositoryClient(Uri endpoint, string repository) : this(endpoint, repository, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repository, ContainerRegistryClientOptions options)
        {
            _repository = repository;
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient for mocking. </summary>
        protected RepositoryClient()
        {
        }
        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal RepositoryClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRepositoryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        public Uri Endpoint { get; }

        public string Repository {  get { return _repository; } }

        public virtual async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            // TODO: delete the repository for this repositoryName
        }

        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<RepositoryProperties>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<RepositoryProperties> GetProperties(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Update the attribute identified by `name` where `reference` is the name of the repository. </summary>
        /// <param name="value"> Repository attribute value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SetPermissionsAsync(ContentPermissions value, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
            //scope.Start();
            //try
            //{
            //    return await RestClient.UpdateRepositoryAttributesAsync(repositoryName, value, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Update the attribute identified by `name` where `reference` is the name of the repository. </summary>
        /// <param name="value"> Repository attribute value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response SetPermissions(ContentPermissions value, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
            //scope.Start();
            //try
            //{
            //    return RestClient.UpdateRepositoryAttributes(repositoryName, value, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Delete the manifest identified by `name` and `reference`. Note that a manifest can _only_ be deleted by `digest`. </summary>
        /// <param name="digest"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteItemAsync(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return await RestClient.DeleteManifestAsync(_repository, digest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the manifest identified by `name` and `reference`. Note that a manifest can _only_ be deleted by `digest`. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteItem(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return RestClient.DeleteManifest(_repository, digest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // TODO: concern here with this name -- GetManifests doesn't return the same thing as GetManifest.  Will this lead to 
        // caller confusion?
        /// <summary> List manifests of a repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<RepositoryItemProperties> GetItemPropertiesAsync(GetRepositoryItemOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            // call await RestClient.GetManifestsAsync(**_repositoryName**, last, n, orderby, cancellationToken).ConfigureAwait(false);            

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifests");
            //scope.Start();
            //try
            //{
            //    return await RestClient.GetManifestsAsync(name, last, n, orderby, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> List manifests of a repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<RepositoryItemProperties> GetItemProperties(GetRepositoryItemOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            // call RestClient.GetManifests(**_repositoryName**, last, n, orderby, cancellationToken).ConfigureAwait(false);            

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifests");
            //scope.Start();
            //try
            //{
            //    return RestClient.GetManifests(name, last, n, orderby, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        public virtual RepositoryItemClient GetRepositoryItemClient(string reference)
        {
            throw new NotImplementedException();
        }
    }
}
