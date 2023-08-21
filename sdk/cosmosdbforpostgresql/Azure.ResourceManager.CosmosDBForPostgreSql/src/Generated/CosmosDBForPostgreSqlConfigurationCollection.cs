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

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBForPostgreSqlConfigurationResource" /> and their operations.
    /// Each <see cref="CosmosDBForPostgreSqlConfigurationResource" /> in the collection will belong to the same instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// To get a <see cref="CosmosDBForPostgreSqlConfigurationCollection" /> instance call the GetCosmosDBForPostgreSqlConfigurations method from an instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// </summary>
    public partial class CosmosDBForPostgreSqlConfigurationCollection : ArmCollection, IEnumerable<CosmosDBForPostgreSqlConfigurationResource>, IAsyncEnumerable<CosmosDBForPostgreSqlConfigurationResource>
    {
        private readonly ClientDiagnostics _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlConfigurationCollection"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBForPostgreSqlConfigurationResource.ResourceType, out string cosmosDBForPostgreSqlConfigurationConfigurationsApiVersion);
            _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBForPostgreSqlClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBForPostgreSqlClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information of a configuration for coordinator and nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information of a configuration for coordinator and nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the configurations of a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBForPostgreSqlConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CosmosDBForPostgreSqlConfigurationResource(Client, CosmosDBForPostgreSqlConfigurationData.DeserializeCosmosDBForPostgreSqlConfigurationData(e)), _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the configurations of a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBForPostgreSqlConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CosmosDBForPostgreSqlConfigurationResource(Client, CosmosDBForPostgreSqlConfigurationData.DeserializeCosmosDBForPostgreSqlConfigurationData(e)), _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBForPostgreSqlConfigurationResource> IEnumerable<CosmosDBForPostgreSqlConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBForPostgreSqlConfigurationResource> IAsyncEnumerable<CosmosDBForPostgreSqlConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
