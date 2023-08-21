// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    internal partial class ArmResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _benefitRecommendationsClientDiagnostics;
        private BenefitRecommendationsRestOperations _benefitRecommendationsRestClient;
        private ClientDiagnostics _forecastClientDiagnostics;
        private ForecastRestOperations _forecastRestClient;
        private ClientDiagnostics _dimensionsClientDiagnostics;
        private DimensionsRestOperations _dimensionsRestClient;
        private ClientDiagnostics _queryClientDiagnostics;
        private QueryRestOperations _queryRestClient;
        private ClientDiagnostics _scheduledActionsClientDiagnostics;
        private ScheduledActionsRestOperations _scheduledActionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class for mocking. </summary>
        protected ArmResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics BenefitRecommendationsClientDiagnostics => _benefitRecommendationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CostManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private BenefitRecommendationsRestOperations BenefitRecommendationsRestClient => _benefitRecommendationsRestClient ??= new BenefitRecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ForecastClientDiagnostics => _forecastClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CostManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ForecastRestOperations ForecastRestClient => _forecastRestClient ??= new ForecastRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DimensionsClientDiagnostics => _dimensionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CostManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DimensionsRestOperations DimensionsRestClient => _dimensionsRestClient ??= new DimensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics QueryClientDiagnostics => _queryClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CostManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private QueryRestOperations QueryRestClient => _queryRestClient ??= new QueryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ScheduledActionsClientDiagnostics => _scheduledActionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CostManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ScheduledActionsRestOperations ScheduledActionsRestClient => _scheduledActionsRestClient ??= new ScheduledActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CostManagementExportResources in the ArmResource. </summary>
        /// <returns> An object representing collection of CostManagementExportResources and their operations over a CostManagementExportResource. </returns>
        public virtual CostManagementExportCollection GetCostManagementExports()
        {
            return GetCachedClient(Client => new CostManagementExportCollection(Client, Id));
        }

        /// <summary> Gets a collection of CostManagementViewsResources in the ArmResource. </summary>
        /// <returns> An object representing collection of CostManagementViewsResources and their operations over a CostManagementViewsResource. </returns>
        public virtual CostManagementViewsCollection GetAllCostManagementViews()
        {
            return GetCachedClient(Client => new CostManagementViewsCollection(Client, Id));
        }

        /// <summary> Gets a collection of CostManagementAlertResources in the ArmResource. </summary>
        /// <returns> An object representing collection of CostManagementAlertResources and their operations over a CostManagementAlertResource. </returns>
        public virtual CostManagementAlertCollection GetCostManagementAlerts()
        {
            return GetCachedClient(Client => new CostManagementAlertCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScheduledActionResources in the ArmResource. </summary>
        /// <returns> An object representing collection of ScheduledActionResources and their operations over a ScheduledActionResource. </returns>
        public virtual ScheduledActionCollection GetScheduledActions()
        {
            return GetCachedClient(Client => new ScheduledActionCollection(Client, Id));
        }

        /// <summary>
        /// List of recommendations for purchasing savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{billingScope}/providers/Microsoft.CostManagement/benefitRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BenefitRecommendations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Can be used to filter benefitRecommendations by: properties/scope with allowed values ['Single', 'Shared'] and default value 'Shared'; and properties/lookBackPeriod with allowed values ['Last7Days', 'Last30Days', 'Last60Days'] and default value 'Last60Days'; properties/term with allowed values ['P1Y', 'P3Y'] and default value 'P3Y'; properties/subscriptionId; properties/resourceGroup. </param>
        /// <param name="orderby"> May be used to order the recommendations by: properties/armSkuName. For the savings plan, the results are in order by default. There is no need to use this clause. </param>
        /// <param name="expand"> May be used to expand the properties by: properties/usage, properties/allRecommendationDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BenefitRecommendationModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BenefitRecommendationModel> GetBenefitRecommendationsAsync(string filter = null, string orderby = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BenefitRecommendationsRestClient.CreateListRequest(Id, filter, orderby, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BenefitRecommendationsRestClient.CreateListNextPageRequest(nextLink, Id, filter, orderby, expand);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, BenefitRecommendationModel.DeserializeBenefitRecommendationModel, BenefitRecommendationsClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetBenefitRecommendations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of recommendations for purchasing savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{billingScope}/providers/Microsoft.CostManagement/benefitRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BenefitRecommendations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Can be used to filter benefitRecommendations by: properties/scope with allowed values ['Single', 'Shared'] and default value 'Shared'; and properties/lookBackPeriod with allowed values ['Last7Days', 'Last30Days', 'Last60Days'] and default value 'Last60Days'; properties/term with allowed values ['P1Y', 'P3Y'] and default value 'P3Y'; properties/subscriptionId; properties/resourceGroup. </param>
        /// <param name="orderby"> May be used to order the recommendations by: properties/armSkuName. For the savings plan, the results are in order by default. There is no need to use this clause. </param>
        /// <param name="expand"> May be used to expand the properties by: properties/usage, properties/allRecommendationDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BenefitRecommendationModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BenefitRecommendationModel> GetBenefitRecommendations(string filter = null, string orderby = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BenefitRecommendationsRestClient.CreateListRequest(Id, filter, orderby, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BenefitRecommendationsRestClient.CreateListNextPageRequest(nextLink, Id, filter, orderby, expand);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, BenefitRecommendationModel.DeserializeBenefitRecommendationModel, BenefitRecommendationsClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetBenefitRecommendations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the forecast charges for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/forecast</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Forecast_Usage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ForecastResult>> UsageForecastAsync(ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = ForecastClientDiagnostics.CreateScope("ArmResourceExtensionClient.UsageForecast");
            scope.Start();
            try
            {
                var response = await ForecastRestClient.UsageAsync(Id, forecastDefinition, filter, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the forecast charges for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/forecast</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Forecast_Usage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="forecastDefinition"> Parameters supplied to the CreateOrUpdate Forecast Config operation. </param>
        /// <param name="filter"> May be used to filter forecasts by properties/usageDate (Utc time), properties/chargeType or properties/grain. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ForecastResult> UsageForecast(ForecastDefinition forecastDefinition, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = ForecastClientDiagnostics.CreateScope("ArmResourceExtensionClient.UsageForecast");
            scope.Start();
            try
            {
                var response = ForecastRestClient.Usage(Id, forecastDefinition, filter, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the dimensions by the defined scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/dimensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Dimensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter dimensions by properties/category, properties/usageStart, properties/usageEnd. Supported operators are 'eq','lt', 'gt', 'le', 'ge'. </param>
        /// <param name="expand"> May be used to expand the properties/data within a dimension category. By default, data is not included when listing dimensions. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N dimension data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CostManagementDimension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CostManagementDimension> GetDimensionsAsync(string filter = null, string expand = null, string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DimensionsRestClient.CreateListRequest(Id, filter, expand, skiptoken, top);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, CostManagementDimension.DeserializeCostManagementDimension, DimensionsClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetDimensions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the dimensions by the defined scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/dimensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Dimensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter dimensions by properties/category, properties/usageStart, properties/usageEnd. Supported operators are 'eq','lt', 'gt', 'le', 'ge'. </param>
        /// <param name="expand"> May be used to expand the properties/data within a dimension category. By default, data is not included when listing dimensions. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N dimension data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CostManagementDimension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CostManagementDimension> GetDimensions(string filter = null, string expand = null, string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DimensionsRestClient.CreateListRequest(Id, filter, expand, skiptoken, top);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, CostManagementDimension.DeserializeCostManagementDimension, DimensionsClientDiagnostics, Pipeline, "ArmResourceExtensionClient.GetDimensions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Query the usage data for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/query</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Query_Usage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queryDefinition"> Parameters supplied to the CreateOrUpdate Query Config operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QueryResult>> UsageQueryAsync(QueryDefinition queryDefinition, CancellationToken cancellationToken = default)
        {
            using var scope = QueryClientDiagnostics.CreateScope("ArmResourceExtensionClient.UsageQuery");
            scope.Start();
            try
            {
                var response = await QueryRestClient.UsageAsync(Id, queryDefinition, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Query the usage data for scope defined.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/query</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Query_Usage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queryDefinition"> Parameters supplied to the CreateOrUpdate Query Config operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QueryResult> UsageQuery(QueryDefinition queryDefinition, CancellationToken cancellationToken = default)
        {
            using var scope = QueryClientDiagnostics.CreateScope("ArmResourceExtensionClient.UsageQuery");
            scope.Start();
            try
            {
                var response = QueryRestClient.Usage(Id, queryDefinition, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks availability and correctness of the name for a scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CheckNameAvailabilityByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Scheduled action to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CostManagementNameAvailabilityResult>> CheckCostManagementNameAvailabilityByScopeScheduledActionAsync(CostManagementNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ScheduledActionsClientDiagnostics.CreateScope("ArmResourceExtensionClient.CheckCostManagementNameAvailabilityByScopeScheduledAction");
            scope.Start();
            try
            {
                var response = await ScheduledActionsRestClient.CheckNameAvailabilityByScopeAsync(Id, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks availability and correctness of the name for a scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CheckNameAvailabilityByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Scheduled action to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CostManagementNameAvailabilityResult> CheckCostManagementNameAvailabilityByScopeScheduledAction(CostManagementNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ScheduledActionsClientDiagnostics.CreateScope("ArmResourceExtensionClient.CheckCostManagementNameAvailabilityByScopeScheduledAction");
            scope.Start();
            try
            {
                var response = ScheduledActionsRestClient.CheckNameAvailabilityByScope(Id, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
