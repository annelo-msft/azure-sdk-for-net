// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RecommendedAction and their operations over its parent. </summary>
    public partial class RecommendedActionCollection : ArmCollection, IEnumerable<RecommendedAction>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DatabaseRecommendedActionsRestOperations _databaseRecommendedActionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecommendedActionCollection"/> class for mocking. </summary>
        protected RecommendedActionCollection()
        {
        }

        /// <summary> Initializes a new instance of RecommendedActionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RecommendedActionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _databaseRecommendedActionsRestClient = new DatabaseRecommendedActionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ServerDatabaseAdvisor.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<RecommendedAction> Get(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecommendedAction(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_Get
        /// <summary> Gets a database recommended action. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<RecommendedAction>> GetAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecommendedAction(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<RecommendedAction> GetIfExists(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RecommendedAction>(null, response.GetRawResponse())
                    : Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<RecommendedAction>> GetIfExistsAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _databaseRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RecommendedAction>(null, response.GetRawResponse())
                    : Response.FromValue(new RecommendedAction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<bool> Exists(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(recommendedActionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recommendedActionName"> The name of Database Recommended Action. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            if (recommendedActionName == null)
            {
                throw new ArgumentNullException(nameof(recommendedActionName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(recommendedActionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_ListByDatabaseAdvisor
        /// <summary> Gets list of Database Recommended Actions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<RecommendedAction>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetAll");
            scope.Start();
            try
            {
                var response = _databaseRecommendedActionsRestClient.ListByDatabaseAdvisor(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Select(value => new RecommendedAction(Parent, value)).ToArray() as IReadOnlyList<RecommendedAction>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}/recommendedActions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// OperationId: DatabaseRecommendedActions_ListByDatabaseAdvisor
        /// <summary> Gets list of Database Recommended Actions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<RecommendedAction>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RecommendedActionCollection.GetAll");
            scope.Start();
            try
            {
                var response = await _databaseRecommendedActionsRestClient.ListByDatabaseAdvisorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Select(value => new RecommendedAction(Parent, value)).ToArray() as IReadOnlyList<RecommendedAction>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecommendedAction> IEnumerable<RecommendedAction>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RecommendedAction, RecommendedActionData> Construct() { }
    }
}
