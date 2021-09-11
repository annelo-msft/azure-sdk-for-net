// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class DatasetRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DatasetRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatasetRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2020-12-01")
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetDatasetsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/datasets", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DatasetListResponse>> GetDatasetsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDatasetsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatasetListResponse.DeserializeDatasetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DatasetListResponse> GetDatasetsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDatasetsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatasetListResponse.DeserializeDatasetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateDatasetRequest(string datasetName, DatasetResource dataset, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/datasets/", false);
            uri.AppendPath(datasetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(dataset);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public async Task<Response> CreateOrUpdateDatasetAsync(string datasetName, DatasetResource dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var message = CreateCreateOrUpdateDatasetRequest(datasetName, dataset, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public Response CreateOrUpdateDataset(string datasetName, DatasetResource dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var message = CreateCreateOrUpdateDatasetRequest(datasetName, dataset, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDatasetRequest(string datasetName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/datasets/", false);
            uri.AppendPath(datasetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public async Task<Response<DatasetResource>> GetDatasetAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var message = CreateGetDatasetRequest(datasetName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatasetResource.DeserializeDatasetResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((DatasetResource)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public Response<DatasetResource> GetDataset(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var message = CreateGetDatasetRequest(datasetName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatasetResource.DeserializeDatasetResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((DatasetResource)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteDatasetRequest(string datasetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/datasets/", false);
            uri.AppendPath(datasetName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public async Task<Response> DeleteDatasetAsync(string datasetName, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var message = CreateDeleteDatasetRequest(datasetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public Response DeleteDataset(string datasetName, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var message = CreateDeleteDatasetRequest(datasetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameDatasetRequest(string datasetName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/datasets/", false);
            uri.AppendPath(datasetName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameDatasetAsync(string datasetName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameDatasetRequest(datasetName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Renames a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameDataset(string datasetName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameDatasetRequest(datasetName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDatasetsByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DatasetListResponse>> GetDatasetsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetDatasetsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatasetListResponse.DeserializeDatasetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DatasetListResponse> GetDatasetsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetDatasetsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatasetListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatasetListResponse.DeserializeDatasetListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
