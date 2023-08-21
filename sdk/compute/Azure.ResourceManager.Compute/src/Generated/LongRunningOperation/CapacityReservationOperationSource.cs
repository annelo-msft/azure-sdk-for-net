// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    internal class CapacityReservationOperationSource : Core.IOperationSource<CapacityReservationResource>
    {
        private readonly ArmClient _client;

        internal CapacityReservationOperationSource(ArmClient client)
        {
            _client = client;
        }

        CapacityReservationResource Core.IOperationSource<CapacityReservationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CapacityReservationData.DeserializeCapacityReservationData(document.RootElement);
            return new CapacityReservationResource(_client, data);
        }

        async ValueTask<CapacityReservationResource> Core.IOperationSource<CapacityReservationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CapacityReservationData.DeserializeCapacityReservationData(document.RootElement);
            return new CapacityReservationResource(_client, data);
        }
    }
}
