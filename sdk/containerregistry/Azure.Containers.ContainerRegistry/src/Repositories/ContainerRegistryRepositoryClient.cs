// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry.Models;
using Azure.Core.Pipeline;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ContainerRegistryRepository service client. </summary>
    public class ContainerRegistryRepositoryClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRepositoryRestClient RestClient { get; }

        public ContainerRegistryRepositoryClient(Uri endpoint, string repositoryName, TokenCredential credential) : this(endpoint, repositoryName, credential, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryRepositoryClient(Uri endpoint, string repositoryName, TokenCredential credential, ContainerRegistryClientOptions options)
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient for mocking. </summary>
        protected ContainerRegistryRepositoryClient()
        {
        }
        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal ContainerRegistryRepositoryClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRepositoryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        // TODO: Handle accept header story!
        /// <summary> Get the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="accept"> Accept header string delimited by comma. For example, application/vnd.docker.distribution.manifest.v2+json. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManifestAttributes>> GetManifestAttributesAsync(string repositoryName, string tagOrDigest, string accept = null, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifest");
            //scope.Start();
            //try
            //{
            //    return await RestClient.GetManifestAsync(name, reference, accept, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Get the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="accept"> Accept header string delimited by comma. For example, application/vnd.docker.distribution.manifest.v2+json. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManifestAttributes> GetManifestAttributes(string repositoryName, string tagOrDigest, string accept = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifest");
            //scope.Start();
            //try
            //{
            //    return RestClient.GetManifest(name, reference, accept, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Put the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> A tag or a digest, pointing to a specific image. </param>
        /// <param name="payload"> Manifest body, can take v1 or v2 values depending on accept header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CreateManifestAsync(string name, string reference, Manifest_internal payload, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                return await RestClient.CreateManifestAsync(name, reference, payload, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> A tag or a digest, pointing to a specific image. </param>
        /// <param name="payload"> Manifest body, can take v1 or v2 values depending on accept header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CreateManifest(string name, string reference, Manifest_internal payload, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                return RestClient.CreateManifest(name, reference, payload, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // TODO: what are the semantics of Create in our APIs?  Does it throw if the resource already exists?
        // TODO: is there a user scenario where they would want to Set and override?  CreateIfNotExists?
        // TODO: figure out what Track 2 semantics to copy; what is precedent here?  (What do I think?)
        public virtual Response CreateManifest(string name, string reference, Manifest_internal payload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        // TODO: dig into this ManifestWrapper type - will be need to simplify or restructure?
        // TODO: Rename Manifest
        // TODO: Rename Descriptor
        // TODO: Rename Annotations
        public virtual Response<ManifestWrapper> GetManifest(string name, string reference, Manifest_internal payload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Delete the manifest identified by `name` and `reference`. Note that a manifest can _only_ be deleted by `digest`. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> A tag or a digest, pointing to a specific image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteManifestAsync(string name, string reference, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return await RestClient.DeleteManifestAsync(name, reference, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the manifest identified by `name` and `reference`. Note that a manifest can _only_ be deleted by `digest`. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> A tag or a digest, pointing to a specific image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteManifest(string name, string reference, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteManifest");
            scope.Start();
            try
            {
                return RestClient.DeleteManifest(name, reference, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        public virtual Pageable<TagAttributes> GetTags(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual AsyncPageable<TagAttributes> GetTagsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Get tag attributes by tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagAttributes>> GetTagAttributesAsync(string repositoryName, string tagName, CancellationToken cancellationToken = default)
        {
            await Task.Delay(1, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

        }

        /// <summary> Get tag attributes by tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagAttributes> GetTagAttributes(string repositoryName, string tagName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Update tag attributes. </summary>
        /// <param name="value"> Repository attribute value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateTagAttributesAsync(string repositoryName, string tagName, RegistryObjectPermissions value, CancellationToken cancellationToken = default)
        {
            await Task.Delay(1, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.UpdateTagAttributes");
            //scope.Start();
            //try
            //{
            //    return await RestClient.UpdateTagAttributesAsync(artifactName, tagName, value, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Update tag attributes. </summary>
        /// <param name="value"> Repository attribute value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateTagAttributes(string repositoryName, string tagName, RegistryObjectPermissions value = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.UpdateTagAttributes");
            //scope.Start();
            //try
            //{
            //    return RestClient.UpdateTagAttributes(name, reference, value, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Delete tag. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> Tag name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteTagAsync(string name, string reference, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return await RestClient.DeleteTagAsync(name, reference, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete tag. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="reference"> Tag name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteTag(string name, string reference, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.DeleteTag");
            scope.Start();
            try
            {
                return RestClient.DeleteTag(name, reference, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        public virtual Pageable<ManifestAttributes> GetManifests(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual AsyncPageable<ManifestAttributes> GetManifestsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Get manifest attributes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManifestAttributes>> GetManifestAttributesAsync(string repositoryName, string tagOrDigest, CancellationToken cancellationToken = default)
        {
            await Task.Delay(1, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary> Get manifest attributes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManifestAttributes> GetManifestAttributes(string repositoryName, string tagOrDigest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Update attributes of a manifest. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateManifestAttributesAsync(string repositoryName, string tagOrDigest, RegistryObjectPermissions value, CancellationToken cancellationToken = default)
        {
            await Task.Delay(1, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.UpdateManifestAttributes");
            //scope.Start();
            //try
            //{
            //    return await RestClient.UpdateManifestAttributesAsync(name, reference, value, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Update attributes of a manifest. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateManifestAttributes(string repositoryName, string tagOrDigest, RegistryObjectPermissions value, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.UpdateManifestAttributes");
            //scope.Start();
            //try
            //{
            //    return RestClient.UpdateManifestAttributes(name, reference, value, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }
    }
}
