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
    public partial class TagClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ContainerRegistryRepositoryRestClient RestClient { get; }

        private string _repositoryName;
        private string _tagName;

        public TagClient(Uri endpoint, string repositoryName, string tagName, TokenCredential credential) : this(endpoint, repositoryName, tagName, credential, new ContainerRegistryClientOptions())
        {
        }

        public TagClient(Uri endpoint, string repositoryName, string tagName, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _tagName = tagName;
            _repositoryName = repositoryName;
        }

        public TagClient(Uri endpoint, string repositoryName, string tagName, AzureAdminUserCredential credential) : this(endpoint, repositoryName, tagName, credential, new ContainerRegistryClientOptions())
        {
        }

        public TagClient(Uri endpoint, string repositoryName, string tagName, AzureAdminUserCredential credential, ContainerRegistryClientOptions options)
        {
            _tagName = tagName;
            _repositoryName = repositoryName;
        }

        /// <summary>
        /// anonymous access
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="tagName"></param>
        public TagClient(Uri endpoint, string repositoryName, string tagName) : this(endpoint, repositoryName, tagName, new ContainerRegistryClientOptions())
        {
        }

        public TagClient(Uri endpoint, string repositoryName, string tagName, ContainerRegistryClientOptions options)
        {
            _tagName = tagName;
        }

        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient for mocking. </summary>
        protected TagClient()
        {
        }
        /// <summary> Initializes a new instance of ContainerRegistryRepositoryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal TagClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryRepositoryRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        public Uri Endpoint { get; }

        public string RepositoryName { get { return _repositoryName; } }

        public string TagName {  get { return _tagName; } }

        public virtual async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            // TODO: delete this tag
        }

        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<TagProperties>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();

            // TODO: Get Repository Attributes
        }

        public virtual Response<TagProperties> GetProperties(CancellationToken cancellationToken = default)
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
    }
}
