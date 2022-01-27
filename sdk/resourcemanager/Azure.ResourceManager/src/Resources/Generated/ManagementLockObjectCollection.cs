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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ManagementLockObject and their operations over its parent. </summary>
    public partial class ManagementLockObjectCollection : ArmCollection, IEnumerable<ManagementLockObject>, IAsyncEnumerable<ManagementLockObject>
    {
        private readonly ClientDiagnostics _managementLockObjectManagementLocksClientDiagnostics;
        private readonly ManagementLocksRestOperations _managementLockObjectManagementLocksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementLockObjectCollection"/> class for mocking. </summary>
        protected ManagementLockObjectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementLockObjectCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagementLockObjectCollection(ArmResource parent) : base(parent)
        {
            _managementLockObjectManagementLocksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ManagementLockObject.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ManagementLockObject.ResourceType, out string managementLockObjectManagementLocksApiVersion);
            _managementLockObjectManagementLocksRestClient = new ManagementLocksRestOperations(_managementLockObjectManagementLocksClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managementLockObjectManagementLocksApiVersion);
        }

        // Collection level operations.

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_CreateOrUpdateByScope
        /// <summary> Create or update a management lock by scope. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="parameters"> Create or update management lock parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ManagementLockObjectCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementLockObjectManagementLocksRestClient.CreateOrUpdateByScope(Id, lockName, parameters, cancellationToken);
                var operation = new ManagementLockObjectCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_CreateOrUpdateByScope
        /// <summary> Create or update a management lock by scope. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="parameters"> Create or update management lock parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagementLockObjectCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementLockObjectManagementLocksRestClient.CreateOrUpdateByScopeAsync(Id, lockName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementLockObjectCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_GetByScope
        /// <summary> Get a management lock by scope. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual Response<ManagementLockObject> Get(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.Get");
            scope.Start();
            try
            {
                var response = _managementLockObjectManagementLocksRestClient.GetByScope(Id, lockName, cancellationToken);
                if (response.Value == null)
                    throw _managementLockObjectManagementLocksClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementLockObject(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks/{lockName}
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_GetByScope
        /// <summary> Get a management lock by scope. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public async virtual Task<Response<ManagementLockObject>> GetAsync(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementLockObjectManagementLocksRestClient.GetByScopeAsync(Id, lockName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managementLockObjectManagementLocksClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementLockObject(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual Response<ManagementLockObject> GetIfExists(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managementLockObjectManagementLocksRestClient.GetByScope(Id, lockName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagementLockObject>(null, response.GetRawResponse());
                return Response.FromValue(new ManagementLockObject(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public async virtual Task<Response<ManagementLockObject>> GetIfExistsAsync(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managementLockObjectManagementLocksRestClient.GetByScopeAsync(Id, lockName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagementLockObject>(null, response.GetRawResponse());
                return Response.FromValue(new ManagementLockObject(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual Response<bool> Exists(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(lockName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string lockName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(lockName, nameof(lockName));

            using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(lockName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_ListByScope
        /// <summary> Gets all the management locks for a scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementLockObject" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementLockObject> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagementLockObject> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managementLockObjectManagementLocksRestClient.ListByScope(Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagementLockObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managementLockObjectManagementLocksRestClient.ListByScopeNextPage(nextLink, Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/locks
        /// ContextualPath: /{scope}
        /// OperationId: ManagementLocks_ListByScope
        /// <summary> Gets all the management locks for a scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementLockObject" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementLockObject> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagementLockObject>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managementLockObjectManagementLocksRestClient.ListByScopeAsync(Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagementLockObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementLockObjectManagementLocksClientDiagnostics.CreateScope("ManagementLockObjectCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managementLockObjectManagementLocksRestClient.ListByScopeNextPageAsync(nextLink, Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagementLockObject> IEnumerable<ManagementLockObject>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementLockObject> IAsyncEnumerable<ManagementLockObject>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
