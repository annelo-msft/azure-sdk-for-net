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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryPrivateEndpointResource" /> and their operations.
    /// Each <see cref="DataFactoryPrivateEndpointResource" /> in the collection will belong to the same instance of <see cref="DataFactoryManagedVirtualNetworkResource" />.
    /// To get a <see cref="DataFactoryPrivateEndpointCollection" /> instance call the GetDataFactoryPrivateEndpoints method from an instance of <see cref="DataFactoryManagedVirtualNetworkResource" />.
    /// </summary>
    public partial class DataFactoryPrivateEndpointCollection : ArmCollection, IEnumerable<DataFactoryPrivateEndpointResource>, IAsyncEnumerable<DataFactoryPrivateEndpointResource>
    {
        private readonly ClientDiagnostics _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics;
        private readonly ManagedPrivateEndpointsRestOperations _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPrivateEndpointCollection"/> class for mocking. </summary>
        protected DataFactoryPrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPrivateEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryPrivateEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryPrivateEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryPrivateEndpointResource.ResourceType, out string dataFactoryPrivateEndpointManagedPrivateEndpointsApiVersion);
            _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient = new ManagedPrivateEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryPrivateEndpointManagedPrivateEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryManagedVirtualNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryManagedVirtualNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="data"> Managed private endpoint resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed private endpoint entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryPrivateEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedPrivateEndpointName, DataFactoryPrivateEndpointData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryPrivateEndpointResource>(Response.FromValue(new DataFactoryPrivateEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="data"> Managed private endpoint resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed private endpoint entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryPrivateEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string managedPrivateEndpointName, DataFactoryPrivateEndpointData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryPrivateEndpointResource>(Response.FromValue(new DataFactoryPrivateEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Gets a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryPrivateEndpointResource>> GetAsync(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<DataFactoryPrivateEndpointResource> Get(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists managed private endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryPrivateEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryPrivateEndpointResource(Client, DataFactoryPrivateEndpointData.DeserializeDataFactoryPrivateEndpointData(e)), _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "DataFactoryPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists managed private endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryPrivateEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryPrivateEndpointResource(Client, DataFactoryPrivateEndpointData.DeserializeDataFactoryPrivateEndpointData(e)), _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "DataFactoryPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _dataFactoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryPrivateEndpointResource> IEnumerable<DataFactoryPrivateEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryPrivateEndpointResource> IAsyncEnumerable<DataFactoryPrivateEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
