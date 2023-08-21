// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlContainerResource" /> and their operations.
    /// Each <see cref="CosmosDBSqlContainerResource" /> in the collection will belong to the same instance of <see cref="CosmosDBSqlDatabaseResource" />.
    /// To get a <see cref="CosmosDBSqlContainerCollection" /> instance call the GetCosmosDBSqlContainers method from an instance of <see cref="CosmosDBSqlDatabaseResource" />.
    /// </summary>
    public partial class CosmosDBSqlContainerCollection : ArmCollection, IEnumerable<CosmosDBSqlContainerResource>, IAsyncEnumerable<CosmosDBSqlContainerResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlContainerSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlContainerSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlContainerCollection"/> class for mocking. </summary>
        protected CosmosDBSqlContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlContainerSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlContainerResource.ResourceType, out string cosmosDBSqlContainerSqlResourcesApiVersion);
            _cosmosDBSqlContainerSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlContainerSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBSqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBSqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB SQL container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="content"> The parameters to provide for the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerName, CosmosDBSqlContainerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlContainerSqlResourcesRestClient.CreateUpdateSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlContainerResource>(new CosmosDBSqlContainerOperationSource(Client), _cosmosDBSqlContainerSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlContainerSqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB SQL container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="content"> The parameters to provide for the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlContainerResource> CreateOrUpdate(WaitUntil waitUntil, string containerName, CosmosDBSqlContainerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlContainerSqlResourcesRestClient.CreateUpdateSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlContainerResource>(new CosmosDBSqlContainerOperationSource(Client), _cosmosDBSqlContainerSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlContainerSqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SQL container under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlContainerResource>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlContainerSqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SQL container under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<CosmosDBSqlContainerResource> Get(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlContainerSqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SQL container under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlContainers</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlContainerSqlResourcesRestClient.CreateListSqlContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBSqlContainerResource(Client, CosmosDBSqlContainerData.DeserializeCosmosDBSqlContainerData(e)), _cosmosDBSqlContainerSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlContainerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the SQL container under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlContainers</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlContainerSqlResourcesRestClient.CreateListSqlContainersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBSqlContainerResource(Client, CosmosDBSqlContainerData.DeserializeCosmosDBSqlContainerData(e)), _cosmosDBSqlContainerSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlContainerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlContainerSqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _cosmosDBSqlContainerSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlContainerSqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlContainerResource> IEnumerable<CosmosDBSqlContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlContainerResource> IAsyncEnumerable<CosmosDBSqlContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
