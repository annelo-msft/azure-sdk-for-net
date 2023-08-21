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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedCcfResource" /> and their operations.
    /// Each <see cref="ManagedCcfResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ManagedCcfCollection" /> instance call the GetManagedCcfs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ManagedCcfCollection : ArmCollection, IEnumerable<ManagedCcfResource>, IAsyncEnumerable<ManagedCcfResource>
    {
        private readonly ClientDiagnostics _managedCcfManagedCcfClientDiagnostics;
        private readonly ManagedCCFRestOperations _managedCcfManagedCcfRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedCcfCollection"/> class for mocking. </summary>
        protected ManagedCcfCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedCcfCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedCcfCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedCcfManagedCcfClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConfidentialLedger", ManagedCcfResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedCcfResource.ResourceType, out string managedCcfManagedCcfApiVersion);
            _managedCcfManagedCcfRestClient = new ManagedCCFRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedCcfManagedCcfApiVersion);
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
        /// Creates a Managed CCF with the specified Managed CCF parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="data"> Managed CCF Create Request Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedCcfResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string appName, ManagedCcfData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedCcfManagedCcfRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, appName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConfidentialLedgerArmOperation<ManagedCcfResource>(new ManagedCcfOperationSource(Client), _managedCcfManagedCcfClientDiagnostics, Pipeline, _managedCcfManagedCcfRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, appName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a Managed CCF with the specified Managed CCF parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="data"> Managed CCF Create Request Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedCcfResource> CreateOrUpdate(WaitUntil waitUntil, string appName, ManagedCcfData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedCcfManagedCcfRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, appName, data, cancellationToken);
                var operation = new ConfidentialLedgerArmOperation<ManagedCcfResource>(new ManagedCcfOperationSource(Client), _managedCcfManagedCcfClientDiagnostics, Pipeline, _managedCcfManagedCcfRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, appName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual async Task<Response<ManagedCcfResource>> GetAsync(string appName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedCcfManagedCcfRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, appName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedCcfResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of a Managed CCF app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual Response<ManagedCcfResource> Get(string appName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.Get");
            scope.Start();
            try
            {
                var response = _managedCcfManagedCcfRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, appName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedCcfResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedCcfResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedCcfManagedCcfRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedCcfManagedCcfRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedCcfResource(Client, ManagedCcfData.DeserializeManagedCcfData(e)), _managedCcfManagedCcfClientDiagnostics, Pipeline, "ManagedCcfCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Managed CCF apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedCcfResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedCcfResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedCcfManagedCcfRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedCcfManagedCcfRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedCcfResource(Client, ManagedCcfData.DeserializeManagedCcfData(e)), _managedCcfManagedCcfClientDiagnostics, Pipeline, "ManagedCcfCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string appName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedCcfManagedCcfRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, appName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/managedCCFs/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCCF_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> Name of the Managed CCF. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual Response<bool> Exists(string appName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _managedCcfManagedCcfClientDiagnostics.CreateScope("ManagedCcfCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedCcfManagedCcfRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, appName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedCcfResource> IEnumerable<ManagedCcfResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedCcfResource> IAsyncEnumerable<ManagedCcfResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
