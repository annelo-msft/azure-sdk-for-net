// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The DataFlow service client. </summary>
    public partial class DataFlowClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DataFlowRestClient RestClient { get; }

        /// <summary> Initializes a new instance of DataFlowClient for mocking. </summary>
        protected DataFlowClient()
        {
        }

        /// <summary> Initializes a new instance of DataFlowClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DataFlowClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new DataFlowRestClient(_clientDiagnostics, _pipeline, endpoint, options.Version);
        }

        /// <summary> Initializes a new instance of DataFlowClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DataFlowClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2020-12-01")
        {
            RestClient = new DataFlowRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFlowResource>> GetDataFlowAsync(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlow");
            scope.Start();
            try
            {
                return await RestClient.GetDataFlowAsync(dataFlowName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFlowResource> GetDataFlow(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlow");
            scope.Start();
            try
            {
                return RestClient.GetDataFlow(dataFlowName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DataFlowResource> GetDataFlowsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataFlowResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetDataFlowsByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataFlowResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetDataFlowsByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DataFlowResource> GetDataFlowsByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<DataFlowResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetDataFlowsByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataFlowResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowClient.GetDataFlowsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetDataFlowsByWorkspaceNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="dataFlow"/> is null. </exception>
        public virtual async Task<DataFlowCreateOrUpdateDataFlowOperation> StartCreateOrUpdateDataFlowAsync(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartCreateOrUpdateDataFlow");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateDataFlowAsync(dataFlowName, dataFlow, ifMatch, cancellationToken).ConfigureAwait(false);
                return new DataFlowCreateOrUpdateDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateDataFlowRequest(dataFlowName, dataFlow, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="dataFlow"/> is null. </exception>
        public virtual DataFlowCreateOrUpdateDataFlowOperation StartCreateOrUpdateDataFlow(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartCreateOrUpdateDataFlow");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateDataFlow(dataFlowName, dataFlow, ifMatch, cancellationToken);
                return new DataFlowCreateOrUpdateDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateDataFlowRequest(dataFlowName, dataFlow, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public virtual async Task<DataFlowDeleteDataFlowOperation> StartDeleteDataFlowAsync(string dataFlowName, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartDeleteDataFlow");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteDataFlowAsync(dataFlowName, cancellationToken).ConfigureAwait(false);
                return new DataFlowDeleteDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteDataFlowRequest(dataFlowName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public virtual DataFlowDeleteDataFlowOperation StartDeleteDataFlow(string dataFlowName, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartDeleteDataFlow");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteDataFlow(dataFlowName, cancellationToken);
                return new DataFlowDeleteDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteDataFlowRequest(dataFlowName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a dataflow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<DataFlowRenameDataFlowOperation> StartRenameDataFlowAsync(string dataFlowName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartRenameDataFlow");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameDataFlowAsync(dataFlowName, request, cancellationToken).ConfigureAwait(false);
                return new DataFlowRenameDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameDataFlowRequest(dataFlowName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a dataflow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="request"/> is null. </exception>
        public virtual DataFlowRenameDataFlowOperation StartRenameDataFlow(string dataFlowName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowClient.StartRenameDataFlow");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenameDataFlow(dataFlowName, request, cancellationToken);
                return new DataFlowRenameDataFlowOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameDataFlowRequest(dataFlowName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
