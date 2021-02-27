// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

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
    public partial class RepositoryItemClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRepositoryRestClient RestClient { get; }

        private string _repository;
        private string _itemReference;

        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest, TokenCredential credential) : this(endpoint, respository, tagOrDigest, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _repository = respository;
            _itemReference = tagOrDigest;
        }

        private bool IsDigest(string reference)
        {
            throw new NotImplementedException();
        }

        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest, ContainerRegistryUserCredential credential) : this(endpoint, respository, tagOrDigest, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest, ContainerRegistryUserCredential credential, ContainerRegistryClientOptions options)
        {
            _repository = respository;
            _itemReference = tagOrDigest;
        }

        /// <summary>
        /// anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="respository"></param>
        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest) : this(endpoint, respository, tagOrDigest, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryItemClient(Uri endpoint, string respository, string tagOrDigest, ContainerRegistryClientOptions options)
        {
            _repository = respository;
            _itemReference = tagOrDigest;
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient for mocking. </summary>
        protected RepositoryItemClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal RepositoryItemClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRepositoryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        public Uri Endpoint { get; }

        public string Registry { get; }

        public string Repository { get { return _repository; } }

        //public virtual async Task<Response<string>> GetDigestAsync(CancellationToken cancellationToken = default)
        //{
        //    await Task.Delay(0, cancellationToken).ConfigureAwait(false);
        //    throw new NotImplementedException();

        //    // We'll return our cached version of this if we have it, or make a REST API call to get it if needed.
        //}

        //public virtual Response<string> GetDigest(CancellationToken cancellationToken = default)
        //{
        //    throw new NotImplementedException();

        //    // We'll return our cached version of this if we have it, or make a REST API call to get it if needed.
        //    // TODO: is this precedented elsewhere in the SDK
        //}

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

        public virtual async Task<Response> DeleteAsync(string digest, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        public virtual Response Delete(string digest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<RepositoryItemProperties>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<RepositoryItemProperties> GetProperties(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response> SetPermissionsAsync(ContentPermissions value, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
            //scope.Start();
            //try
            //{
            //    return await RestClient.UpdateRepositoryAttributesAsync(respository, value, cancellationToken).ConfigureAwait(false);
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
            //    return RestClient.UpdateRepositoryAttributes(respository, value, cancellationToken);
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
        public virtual async Task<Response> SetTagPermissionsAsync(string tag, ContentPermissions value, CancellationToken cancellationToken = default)
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
        public virtual Response SetTagPermissions(string tag, ContentPermissions value, CancellationToken cancellationToken = default)
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
    }
}
