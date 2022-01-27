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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
    public partial class SiteSlotPrivateEndpointConnectionCreateOrUpdateOperation : Operation<SiteSlotPrivateEndpointConnection>, IOperationSource<SiteSlotPrivateEndpointConnection>
    {
        private readonly OperationInternals<SiteSlotPrivateEndpointConnection> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SiteSlotPrivateEndpointConnectionCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotPrivateEndpointConnectionCreateOrUpdateOperation()
        {
        }

        internal SiteSlotPrivateEndpointConnectionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteSlotPrivateEndpointConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteSlotPrivateEndpointConnectionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotPrivateEndpointConnection Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotPrivateEndpointConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotPrivateEndpointConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteSlotPrivateEndpointConnection IOperationSource<SiteSlotPrivateEndpointConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new SiteSlotPrivateEndpointConnection(_armClient, data);
        }

        async ValueTask<SiteSlotPrivateEndpointConnection> IOperationSource<SiteSlotPrivateEndpointConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new SiteSlotPrivateEndpointConnection(_armClient, data);
        }
    }
}
