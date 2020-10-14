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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The JobSteps service client. </summary>
    public partial class JobStepsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal JobStepsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of JobStepsOperations for mocking. </summary>
        protected JobStepsOperations()
        {
        }
        /// <summary> Initializes a new instance of JobStepsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal JobStepsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new JobStepsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified version of a job step. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobStep>> GetByVersionAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.GetByVersion");
            scope.Start();
            try
            {
                return await RestClient.GetByVersionAsync(resourceGroupName, serverName, jobAgentName, jobName, jobVersion, stepName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified version of a job step. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobStep> GetByVersion(string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.GetByVersion");
            scope.Start();
            try
            {
                return RestClient.GetByVersion(resourceGroupName, serverName, jobAgentName, jobName, jobVersion, stepName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a job step in a job&apos;s current version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobStep>> GetAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, jobAgentName, jobName, stepName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a job step in a job&apos;s current version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobStep> Get(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, jobAgentName, jobName, stepName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a job step. This will implicitly create a new job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="parameters"> The requested state of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobStep>> CreateOrUpdateAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, JobStep parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, jobName, stepName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a job step. This will implicitly create a new job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="parameters"> The requested state of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobStep> CreateOrUpdate(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, JobStep parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, serverName, jobAgentName, jobName, stepName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a job step. This will implicitly create a new job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, serverName, jobAgentName, jobName, stepName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a job step. This will implicitly create a new job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="stepName"> The name of the job step to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string serverName, string jobAgentName, string jobName, string stepName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, serverName, jobAgentName, jobName, stepName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all job steps in the specified job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual AsyncPageable<JobStep> ListByVersionAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            async Task<Page<JobStep>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByVersion");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByVersionAsync(resourceGroupName, serverName, jobAgentName, jobName, jobVersion, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobStep>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByVersion");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByVersionNextPageAsync(nextLink, resourceGroupName, serverName, jobAgentName, jobName, jobVersion, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all job steps in the specified job version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual Pageable<JobStep> ListByVersion(string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            Page<JobStep> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByVersion");
                scope.Start();
                try
                {
                    var response = RestClient.ListByVersion(resourceGroupName, serverName, jobAgentName, jobName, jobVersion, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobStep> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByVersion");
                scope.Start();
                try
                {
                    var response = RestClient.ListByVersionNextPage(nextLink, resourceGroupName, serverName, jobAgentName, jobName, jobVersion, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all job steps for a job&apos;s current version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual AsyncPageable<JobStep> ListByJobAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            async Task<Page<JobStep>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByJobAsync(resourceGroupName, serverName, jobAgentName, jobName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobStep>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByJobNextPageAsync(nextLink, resourceGroupName, serverName, jobAgentName, jobName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all job steps for a job&apos;s current version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual Pageable<JobStep> ListByJob(string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            Page<JobStep> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = RestClient.ListByJob(resourceGroupName, serverName, jobAgentName, jobName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobStep> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobStepsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = RestClient.ListByJobNextPage(nextLink, resourceGroupName, serverName, jobAgentName, jobName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
