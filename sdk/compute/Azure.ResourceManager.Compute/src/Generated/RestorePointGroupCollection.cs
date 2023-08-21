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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorePointGroupResource" /> and their operations.
    /// Each <see cref="RestorePointGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RestorePointGroupCollection" /> instance call the GetRestorePointGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RestorePointGroupCollection : ArmCollection, IEnumerable<RestorePointGroupResource>, IAsyncEnumerable<RestorePointGroupResource>
    {
        private readonly ClientDiagnostics _restorePointGroupRestorePointCollectionsClientDiagnostics;
        private readonly RestorePointCollectionsRestOperations _restorePointGroupRestorePointCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroupCollection"/> class for mocking. </summary>
        protected RestorePointGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorePointGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointGroupRestorePointCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", RestorePointGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorePointGroupResource.ResourceType, out string restorePointGroupRestorePointCollectionsApiVersion);
            _restorePointGroupRestorePointCollectionsRestClient = new RestorePointCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorePointGroupRestorePointCollectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="data"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RestorePointGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string restorePointGroupName, RestorePointGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<RestorePointGroupResource>(Response.FromValue(new RestorePointGroupResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="data"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RestorePointGroupResource> CreateOrUpdate(WaitUntil waitUntil, string restorePointGroupName, RestorePointGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, data, cancellationToken);
                var operation = new ComputeArmOperation<RestorePointGroupResource>(Response.FromValue(new RestorePointGroupResource(Client, response), response.GetRawResponse()));
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
        /// The operation to get the restore point collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> is null. </exception>
        public virtual async Task<Response<RestorePointGroupResource>> GetAsync(string restorePointGroupName, RestorePointGroupExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the restore point collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> is null. </exception>
        public virtual Response<RestorePointGroupResource> Get(string restorePointGroupName, RestorePointGroupExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of restore point collections in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorePointGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorePointGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorePointGroupRestorePointCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorePointGroupRestorePointCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RestorePointGroupResource(Client, RestorePointGroupData.DeserializeRestorePointGroupData(e)), _restorePointGroupRestorePointCollectionsClientDiagnostics, Pipeline, "RestorePointGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of restore point collections in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorePointGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorePointGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorePointGroupRestorePointCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorePointGroupRestorePointCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RestorePointGroupResource(Client, RestorePointGroupData.DeserializeRestorePointGroupData(e)), _restorePointGroupRestorePointCollectionsClientDiagnostics, Pipeline, "RestorePointGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorePointGroupName, RestorePointGroupExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePointCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointGroupName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointGroupName, RestorePointGroupExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, restorePointGroupName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorePointGroupResource> IEnumerable<RestorePointGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorePointGroupResource> IAsyncEnumerable<RestorePointGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
