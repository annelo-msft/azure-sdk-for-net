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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VirtualNetworkOperationSource : Core.IOperationSource<VirtualNetworkResource>
    {
        private readonly ArmClient _client;

        internal VirtualNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualNetworkResource Core.IOperationSource<VirtualNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualNetworkData.DeserializeVirtualNetworkData(document.RootElement);
            return new VirtualNetworkResource(_client, data);
        }

        async ValueTask<VirtualNetworkResource> Core.IOperationSource<VirtualNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualNetworkData.DeserializeVirtualNetworkData(document.RootElement);
            return new VirtualNetworkResource(_client, data);
        }
    }
}
