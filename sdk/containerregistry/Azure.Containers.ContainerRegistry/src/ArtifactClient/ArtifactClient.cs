// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry.Models;
using Azure.Containers.ContainerRegistry.Storage;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ContainerRegistryRepository service client. </summary>
    public partial class ArtifactClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRepositoryRestClient RestClient { get; }

        private string _repositoryName;
        private ArtifactReference _reference;

        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference, TokenCredential credential) : this(endpoint, repositoryName, reference, credential, new ContainerRegistryClientOptions())
        {
        }

        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
            _reference = reference;
        }

        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference, AzureAdminUserCredential credential) : this(endpoint, repositoryName, reference, credential, new ContainerRegistryClientOptions())
        {
        }

        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference, AzureAdminUserCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
            _reference = reference;
        }

        /// <summary>
        /// anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="repositoryName"></param>
        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference) : this(endpoint, repositoryName, reference, new ContainerRegistryClientOptions())
        {
        }

        public ArtifactClient(Uri endpoint, string repositoryName, ArtifactReference reference, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient for mocking. </summary>
        protected ArtifactClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal ArtifactClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRepositoryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        public Uri Endpoint { get; }

        public string RepositoryName { get { return _repositoryName; } }

        // TODO: this is uncool - call it reference or separate these out ... ?
        // TODO: we could use an options bag everywhere this is found...?
        public ArtifactReference Reference {  get { return _reference; } }

        public virtual async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<ArtifactAttributes>> GetAttributesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<ArtifactAttributes> GetAttributes(CancellationToken cancellationToken = default)
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

        public async virtual Task<Response> PushAsync(string artifactName, Stream stream, PushOptions options = null, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        public virtual Response Push(string artifactName, Stream stream, PushOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<Response<Stream>> PullAsync(string artifactName, PullOptions options = null, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        public virtual Response<Stream> Pull(string artifactName, PullOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual ArtifactStorageClient GetArtifactStorageClient()
        {
            throw new NotImplementedException();
        }
    }
}
