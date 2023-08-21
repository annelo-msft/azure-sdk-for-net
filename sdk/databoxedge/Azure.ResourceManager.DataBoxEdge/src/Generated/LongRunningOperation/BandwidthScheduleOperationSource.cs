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

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class BandwidthScheduleOperationSource : Core.IOperationSource<BandwidthScheduleResource>
    {
        private readonly ArmClient _client;

        internal BandwidthScheduleOperationSource(ArmClient client)
        {
            _client = client;
        }

        BandwidthScheduleResource Core.IOperationSource<BandwidthScheduleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BandwidthScheduleData.DeserializeBandwidthScheduleData(document.RootElement);
            return new BandwidthScheduleResource(_client, data);
        }

        async ValueTask<BandwidthScheduleResource> Core.IOperationSource<BandwidthScheduleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BandwidthScheduleData.DeserializeBandwidthScheduleData(document.RootElement);
            return new BandwidthScheduleResource(_client, data);
        }
    }
}
