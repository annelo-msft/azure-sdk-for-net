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
        private string _repositoryName;

        public RepositoryClient(Uri endpoint, string repositoryName, TokenCredential credential) : this(endpoint, repositoryName, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repositoryName, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        public RepositoryClient(Uri endpoint, string repositoryName, AzureAdminUserCredential credential) : this(endpoint, repositoryName, credential, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repositoryName, AzureAdminUserCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        /// <summary>
        /// anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="repositoryName"></param>
        public RepositoryClient(Uri endpoint, string repositoryName) : this(endpoint, repositoryName, new ContainerRegistryClientOptions())
        {
        }

        public RepositoryClient(Uri endpoint, string repositoryName, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
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

        public string RepositoryName {  get { return _repositoryName; } }

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

        public virtual async Task<Response<RepositoryAttributes>> GetAttributesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<RepositoryAttributes> GetAttributes(CancellationToken cancellationToken = default)
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
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteArtifactAsync(string name, string manifestDigest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return await RestClient.DeleteManifestAsync(name, manifestDigest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the manifest identified by `name` and `reference`. Note that a manifest can _only_ be deleted by `digest`. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteArtifact(string name, string manifestDigest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return RestClient.DeleteManifest(name, manifestDigest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List tags of a repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<TagAttributes> GetTagsAsync(GetTagOptions options = null, CancellationToken cancellationToken = default)
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
        public virtual Pageable<TagAttributes> GetTags(GetTagOptions options = null, CancellationToken cancellationToken = default)
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
        public virtual async Task<Response> DeleteTagAsync(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return await RestClient.DeleteTagAsync(_repositoryName, tagName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteTag(string tagName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return RestClient.DeleteTag(_repositoryName, tagName, cancellationToken);
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
        public virtual AsyncPageable<ArtifactAttributes> GetArtifactsAsync(GetArtifactOptions options = null, CancellationToken cancellationToken = default)
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
        public virtual Pageable<ArtifactAttributes> GetArtifacts(GetArtifactOptions options = null, CancellationToken cancellationToken = default)
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

        public virtual ArtifactClient GetArtifactClient(ArtifactReference reference)
        {
            throw new NotImplementedException();
        }

        public virtual TagClient GetTagClient(string tagName)
        {
            throw new NotImplementedException();
        }

        public virtual ArtifactStorageClient GetArtifactStorageClient()
        {
            throw new NotImplementedException();
        }
    }
}
