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
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeAnalyticsComputePolicyResource" /> and their operations.
    /// Each <see cref="DataLakeAnalyticsComputePolicyResource" /> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// To get a <see cref="DataLakeAnalyticsComputePolicyCollection" /> instance call the GetDataLakeAnalyticsComputePolicies method from an instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// </summary>
    public partial class DataLakeAnalyticsComputePolicyCollection : ArmCollection, IEnumerable<DataLakeAnalyticsComputePolicyResource>, IAsyncEnumerable<DataLakeAnalyticsComputePolicyResource>
    {
        private readonly ClientDiagnostics _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics;
        private readonly ComputePoliciesRestOperations _dataLakeAnalyticsComputePolicyComputePoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsComputePolicyCollection"/> class for mocking. </summary>
        protected DataLakeAnalyticsComputePolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsComputePolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeAnalyticsComputePolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeAnalyticsComputePolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeAnalyticsComputePolicyResource.ResourceType, out string dataLakeAnalyticsComputePolicyComputePoliciesApiVersion);
            _dataLakeAnalyticsComputePolicyComputePoliciesRestClient = new ComputePoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsComputePolicyComputePoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified compute policy. During update, the compute policy with the specified name will be replaced with this new compute policy. An account supports, at most, 50 policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computePolicyName"> The name of the compute policy to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the compute policy. The max degree of parallelism per job property, min priority per job property, or both must be present. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeAnalyticsComputePolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string computePolicyName, DataLakeAnalyticsComputePolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsComputePolicyResource>(Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the specified compute policy. During update, the compute policy with the specified name will be replaced with this new compute policy. An account supports, at most, 50 policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computePolicyName"> The name of the compute policy to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the compute policy. The max degree of parallelism per job property, min priority per job property, or both must be present. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeAnalyticsComputePolicyResource> CreateOrUpdate(WaitUntil waitUntil, string computePolicyName, DataLakeAnalyticsComputePolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsComputePolicyResource>(Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual async Task<Response<DataLakeAnalyticsComputePolicyResource>> GetAsync(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual Response<DataLakeAnalyticsComputePolicyResource> Get(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Analytics compute policies within the specified Data Lake Analytics account. An account supports, at most, 50 policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsComputePolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsComputePolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataLakeAnalyticsComputePolicyResource(Client, DataLakeAnalyticsComputePolicyData.DeserializeDataLakeAnalyticsComputePolicyData(e)), _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics, Pipeline, "DataLakeAnalyticsComputePolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Data Lake Analytics compute policies within the specified Data Lake Analytics account. An account supports, at most, 50 policies
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsComputePolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsComputePolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataLakeAnalyticsComputePolicyResource(Client, DataLakeAnalyticsComputePolicyData.DeserializeDataLakeAnalyticsComputePolicyData(e)), _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics, Pipeline, "DataLakeAnalyticsComputePolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _dataLakeAnalyticsComputePolicyComputePoliciesClientDiagnostics.CreateScope("DataLakeAnalyticsComputePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsComputePolicyComputePoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeAnalyticsComputePolicyResource> IEnumerable<DataLakeAnalyticsComputePolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataLakeAnalyticsComputePolicyResource> IAsyncEnumerable<DataLakeAnalyticsComputePolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
