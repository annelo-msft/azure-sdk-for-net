// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGateway and their operations over its parent. </summary>
    public partial class VirtualNetworkGatewayCollection : ArmCollection, IEnumerable<VirtualNetworkGateway>, IAsyncEnumerable<VirtualNetworkGateway>
    {
        private readonly ClientDiagnostics _virtualNetworkGatewayClientDiagnostics;
        private readonly VirtualNetworkGatewaysRestOperations _virtualNetworkGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayCollection(ArmResource parent) : base(parent)
        {
            _virtualNetworkGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkGateway.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(VirtualNetworkGateway.ResourceType, out string virtualNetworkGatewayApiVersion);
            _virtualNetworkGatewayRestClient = new VirtualNetworkGatewaysRestOperations(_virtualNetworkGatewayClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualNetworkGatewayApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, parameters, cancellationToken);
                var operation = new VirtualNetworkGatewayCreateOrUpdateOperation(ArmClient, _virtualNetworkGatewayClientDiagnostics, Pipeline, _virtualNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="parameters"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualNetworkGatewayName, VirtualNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkGatewayCreateOrUpdateOperation(ArmClient, _virtualNetworkGatewayClientDiagnostics, Pipeline, _virtualNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network gateway by resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual Response<VirtualNetworkGateway> Get(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken);
                if (response.Value == null)
                    throw _virtualNetworkGatewayClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGateway(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network gateway by resource group. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGateway>> GetAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualNetworkGatewayClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGateway(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual Response<VirtualNetworkGateway> GetIfExists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGateway>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGateway(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGateway>> GetIfExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGateway>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGateway(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual network gateways by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual network gateways by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGateway(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkGateway> IEnumerable<VirtualNetworkGateway>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGateway> IAsyncEnumerable<VirtualNetworkGateway>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
