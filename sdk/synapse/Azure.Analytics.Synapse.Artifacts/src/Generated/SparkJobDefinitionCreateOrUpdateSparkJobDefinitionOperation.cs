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
    /// <summary> Creates or updates a Spark Job Definition. </summary>
    public partial class SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation : Operation<SparkJobDefinitionResource>, Core.IOperationSource<SparkJobDefinitionResource>
    {
        private readonly OperationInternal<SparkJobDefinitionResource> _operation;

        /// <summary> Initializes a new instance of SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation for mocking. </summary>
        protected SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation()
        {
        }

        internal SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation<SparkJobDefinitionResource> nextLinkOperation = Core.NextLinkOperationImplementation.Create(this, pipeline, request.Method, request.Uri.ToUri(), response, Core.OperationFinalStateVia.Location);
            _operation = new OperationInternal<SparkJobDefinitionResource>(nextLinkOperation, clientDiagnostics, response, "SparkJobDefinitionCreateOrUpdateSparkJobDefinitionOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override SparkJobDefinitionResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<SparkJobDefinitionResource> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<SparkJobDefinitionResource> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SparkJobDefinitionResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SparkJobDefinitionResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SparkJobDefinitionResource Core.IOperationSource<SparkJobDefinitionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SparkJobDefinitionResource.DeserializeSparkJobDefinitionResource(document.RootElement);
        }

        async ValueTask<SparkJobDefinitionResource> Core.IOperationSource<SparkJobDefinitionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SparkJobDefinitionResource.DeserializeSparkJobDefinitionResource(document.RootElement);
        }
    }
}
