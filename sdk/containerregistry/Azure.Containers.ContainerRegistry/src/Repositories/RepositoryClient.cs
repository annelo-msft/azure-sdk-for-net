// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
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

        public string Registry { get; }

        public string Repository { get { return _repository; } }

        public virtual async Task<Response<RepositoryProperties>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Properties
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

        public virtual async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Pageable<ManifestProperties> GetManifests(GetManifestOptions options = null, CancellationToken cancellationToken = default)
        {
            // Get images in repository

            throw new NotImplementedException();
        }

        public virtual AsyncPageable<ManifestProperties> GetManifestsAsync(GetManifestOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteImage(string digest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
            //scope.Start();
            //try
            //{
            //    return RestClient.DeleteRepository(repository, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteImageAsync(string digest, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
            //scope.Start();
            //try
            //{
            //    return await RestClient.DeleteRepositoryAsync(repository, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        public virtual async Task<Response<ManifestProperties>> GetManifestPropertiesAsync(string digest, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<ManifestProperties> GetManifestProperties(string digest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<ManifestProperties>> SetManifestPermissionsAsync(string digest, ContentPermissions value, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
            //scope.Start();
            //try
            //{
            //    return await RestClient.UpdateRepositoryAttributesAsync(repository, value, cancellationToken).ConfigureAwait(false);
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
        public virtual Response<ManifestProperties> SetManifestPermissions(string digest, ContentPermissions value,  CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
            //scope.Start();
            //try
            //{
            //    return RestClient.UpdateRepositoryAttributes(repository, value, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        public virtual async Task<Response<TagProperties>> GetTagPropertiesAsync(string tag, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<TagProperties> GetTagProperties(string tag, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Update the attribute identified by `name` where `reference` is the name of the repository. </summary>
        /// <param name="value"> Repository attribute value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagProperties>> SetTagPermissionsAsync(string tag, ContentPermissions value, CancellationToken cancellationToken = default)
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
        public virtual Response<TagProperties> SetTagPermissions(string tag, ContentPermissions value, CancellationToken cancellationToken = default)
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

        /// <summary> List tags of a repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<TagProperties> GetTagsAsync(GetTagOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetTags");
            //scope.Start();
            //try
            //{
            //    return await RestClient.GetTagsAsync(name, last, n, orderby, digest, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> List tags of a repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<TagProperties> GetTags(GetTagOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetTags");
            //scope.Start();
            //try
            //{
            //    return RestClient.GetTags(name, last, n, orderby, digest, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Delete tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteTagAsync(string tag, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return await RestClient.DeleteTagAsync(_repository, tag, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteTag(string tag, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return RestClient.DeleteTag(_repository, tag, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
