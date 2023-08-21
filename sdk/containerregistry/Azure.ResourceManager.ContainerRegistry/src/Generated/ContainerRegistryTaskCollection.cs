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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryTaskResource" /> and their operations.
    /// Each <see cref="ContainerRegistryTaskResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ContainerRegistryTaskCollection" /> instance call the GetContainerRegistryTasks method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ContainerRegistryTaskCollection : ArmCollection, IEnumerable<ContainerRegistryTaskResource>, IAsyncEnumerable<ContainerRegistryTaskResource>
    {
        private readonly ClientDiagnostics _containerRegistryTaskTasksClientDiagnostics;
        private readonly TasksRestOperations _containerRegistryTaskTasksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTaskCollection"/> class for mocking. </summary>
        protected ContainerRegistryTaskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTaskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryTaskCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryTaskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryTaskResource.ResourceType, out string containerRegistryTaskTasksApiVersion);
            _containerRegistryTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a task for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="data"> The parameters for creating a task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryTaskResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string taskName, ContainerRegistryTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskTasksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTaskResource>(new ContainerRegistryTaskOperationSource(Client), _containerRegistryTaskTasksClientDiagnostics, Pipeline, _containerRegistryTaskTasksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates a task for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="data"> The parameters for creating a task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryTaskResource> CreateOrUpdate(WaitUntil waitUntil, string taskName, ContainerRegistryTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskTasksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTaskResource>(new ContainerRegistryTaskOperationSource(Client), _containerRegistryTaskTasksClientDiagnostics, Pipeline, _containerRegistryTaskTasksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get the properties of a specified task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryTaskResource>> GetAsync(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specified task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<ContainerRegistryTaskResource> Get(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryTaskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryTaskResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTaskTasksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTaskTasksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryTaskResource(Client, ContainerRegistryTaskData.DeserializeContainerRegistryTaskData(e)), _containerRegistryTaskTasksClientDiagnostics, Pipeline, "ContainerRegistryTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryTaskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryTaskResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTaskTasksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTaskTasksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryTaskResource(Client, ContainerRegistryTaskData.DeserializeContainerRegistryTaskData(e)), _containerRegistryTaskTasksClientDiagnostics, Pipeline, "ContainerRegistryTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<bool> Exists(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _containerRegistryTaskTasksClientDiagnostics.CreateScope("ContainerRegistryTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryTaskResource> IEnumerable<ContainerRegistryTaskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryTaskResource> IAsyncEnumerable<ContainerRegistryTaskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
