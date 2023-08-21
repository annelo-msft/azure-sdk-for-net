// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a StaticSiteCustomDomainOverview along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StaticSiteCustomDomainOverviewResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStaticSiteCustomDomainOverviewResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteResource" /> using the GetStaticSiteCustomDomainOverview method.
    /// </summary>
    public partial class StaticSiteCustomDomainOverviewResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteCustomDomainOverviewResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string domainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteCustomDomainOverviewStaticSitesRestClient;
        private readonly StaticSiteCustomDomainOverviewData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewResource"/> class for mocking. </summary>
        protected StaticSiteCustomDomainOverviewResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteCustomDomainOverviewResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewResource(ArmClient client, StaticSiteCustomDomainOverviewData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteCustomDomainOverviewStaticSitesApiVersion);
            _staticSiteCustomDomainOverviewStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteCustomDomainOverviewStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/customDomains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteCustomDomainOverviewData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteCustomDomainOverviewResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteCustomDomainOverviewResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.DeleteStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateDeleteStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.DeleteStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateDeleteStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteCustomDomainOverviewResource>> UpdateAsync(WaitUntil waitUntil, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Update");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewResource>(new StaticSiteCustomDomainOverviewOperationSource(Client), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteCustomDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StaticSiteCustomDomainOverviewResource> Update(WaitUntil waitUntil, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.Update");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewResource>(new StaticSiteCustomDomainOverviewOperationSource(Client), _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Description for Validates a particular custom domain can be added to a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ValidateCustomDomainCanBeAddedToStaticSite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> ValidateCustomDomainCanBeAddedToStaticSiteAsync(WaitUntil waitUntil, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.ValidateCustomDomainCanBeAddedToStaticSite");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewStaticSitesRestClient.ValidateCustomDomainCanBeAddedToStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateValidateCustomDomainCanBeAddedToStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validates a particular custom domain can be added to a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ValidateCustomDomainCanBeAddedToStaticSite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation ValidateCustomDomainCanBeAddedToStaticSite(WaitUntil waitUntil, StaticSiteCustomDomainContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteCustomDomainOverviewStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewResource.ValidateCustomDomainCanBeAddedToStaticSite");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewStaticSitesRestClient.ValidateCustomDomainCanBeAddedToStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteCustomDomainOverviewStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewStaticSitesRestClient.CreateValidateCustomDomainCanBeAddedToStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
