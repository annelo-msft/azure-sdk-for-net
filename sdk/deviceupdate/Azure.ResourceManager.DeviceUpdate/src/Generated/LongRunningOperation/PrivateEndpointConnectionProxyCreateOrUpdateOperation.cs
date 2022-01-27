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
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account. </summary>
    public partial class PrivateEndpointConnectionProxyCreateOrUpdateOperation : Operation<PrivateEndpointConnectionProxy>, IOperationSource<PrivateEndpointConnectionProxy>
    {
        private readonly OperationInternals<PrivateEndpointConnectionProxy> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyCreateOrUpdateOperation for mocking. </summary>
        protected PrivateEndpointConnectionProxyCreateOrUpdateOperation()
        {
        }

        internal PrivateEndpointConnectionProxyCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PrivateEndpointConnectionProxy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "PrivateEndpointConnectionProxyCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PrivateEndpointConnectionProxy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateEndpointConnectionProxy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateEndpointConnectionProxy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PrivateEndpointConnectionProxy IOperationSource<PrivateEndpointConnectionProxy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateEndpointConnectionProxyData.DeserializePrivateEndpointConnectionProxyData(document.RootElement);
            return new PrivateEndpointConnectionProxy(_armClient, data);
        }

        async ValueTask<PrivateEndpointConnectionProxy> IOperationSource<PrivateEndpointConnectionProxy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateEndpointConnectionProxyData.DeserializePrivateEndpointConnectionProxyData(document.RootElement);
            return new PrivateEndpointConnectionProxy(_armClient, data);
        }
    }
}
