// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class MetricBaselineRestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MetricBaselineRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MetricBaselineRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://management.azure.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string resourceUri, string metricName, string timespan, TimeSpan? interval, string aggregation, string sensitivities, ResultType? resultType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/microsoft.insights/baseline/", false);
            uri.AppendPath(metricName, true);
            if (timespan != null)
            {
                uri.AppendQuery("timespan", timespan, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value, "P", true);
            }
            if (aggregation != null)
            {
                uri.AppendQuery("aggregation", aggregation, true);
            }
            if (sensitivities != null)
            {
                uri.AppendQuery("sensitivities", sensitivities, true);
            }
            if (resultType != null)
            {
                uri.AppendQuery("resultType", resultType.Value.ToSerialString(), true);
            }
            uri.AppendQuery("api-version", "2017-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> **Gets the baseline values for a specific metric**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. It has the following structure: subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}. For example: subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1. </param>
        /// <param name="metricName"> The name of the metric to retrieve the baseline for. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="aggregation"> The aggregation type of the metric to retrieve the baseline for. </param>
        /// <param name="sensitivities"> The list of sensitivities (comma separated) to retrieve. </param>
        /// <param name="resultType"> Allows retrieving only metadata of the baseline. On data request all information is retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="metricName"/> is null. </exception>
        public async Task<Response<BaselineResponse>> GetAsync(string resourceUri, string metricName, string timespan = null, TimeSpan? interval = null, string aggregation = null, string sensitivities = null, ResultType? resultType = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (metricName == null)
            {
                throw new ArgumentNullException(nameof(metricName));
            }

            using var message = CreateGetRequest(resourceUri, metricName, timespan, interval, aggregation, sensitivities, resultType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BaselineResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BaselineResponse.DeserializeBaselineResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> **Gets the baseline values for a specific metric**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. It has the following structure: subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}. For example: subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1. </param>
        /// <param name="metricName"> The name of the metric to retrieve the baseline for. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="aggregation"> The aggregation type of the metric to retrieve the baseline for. </param>
        /// <param name="sensitivities"> The list of sensitivities (comma separated) to retrieve. </param>
        /// <param name="resultType"> Allows retrieving only metadata of the baseline. On data request all information is retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="metricName"/> is null. </exception>
        public Response<BaselineResponse> Get(string resourceUri, string metricName, string timespan = null, TimeSpan? interval = null, string aggregation = null, string sensitivities = null, ResultType? resultType = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (metricName == null)
            {
                throw new ArgumentNullException(nameof(metricName));
            }

            using var message = CreateGetRequest(resourceUri, metricName, timespan, interval, aggregation, sensitivities, resultType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BaselineResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BaselineResponse.DeserializeBaselineResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCalculateBaselineRequest(string resourceUri, TimeSeriesInformation timeSeriesInformation)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/microsoft.insights/calculatebaseline", false);
            uri.AppendQuery("api-version", "2017-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(timeSeriesInformation);
            request.Content = content;
            return message;
        }

        /// <summary> **Lists the baseline values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. It has the following structure: subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}. For example: subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1. </param>
        /// <param name="timeSeriesInformation"> Information that need to be specified to calculate a baseline on a time series. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="timeSeriesInformation"/> is null. </exception>
        public async Task<Response<CalculateBaselineResponse>> CalculateBaselineAsync(string resourceUri, TimeSeriesInformation timeSeriesInformation, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (timeSeriesInformation == null)
            {
                throw new ArgumentNullException(nameof(timeSeriesInformation));
            }

            using var message = CreateCalculateBaselineRequest(resourceUri, timeSeriesInformation);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CalculateBaselineResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CalculateBaselineResponse.DeserializeCalculateBaselineResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> **Lists the baseline values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. It has the following structure: subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}. For example: subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1. </param>
        /// <param name="timeSeriesInformation"> Information that need to be specified to calculate a baseline on a time series. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="timeSeriesInformation"/> is null. </exception>
        public Response<CalculateBaselineResponse> CalculateBaseline(string resourceUri, TimeSeriesInformation timeSeriesInformation, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (timeSeriesInformation == null)
            {
                throw new ArgumentNullException(nameof(timeSeriesInformation));
            }

            using var message = CreateCalculateBaselineRequest(resourceUri, timeSeriesInformation);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CalculateBaselineResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CalculateBaselineResponse.DeserializeCalculateBaselineResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
