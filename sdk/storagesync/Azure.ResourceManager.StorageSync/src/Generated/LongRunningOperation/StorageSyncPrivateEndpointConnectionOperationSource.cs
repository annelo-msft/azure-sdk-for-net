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

namespace Azure.ResourceManager.StorageSync
{
    internal class StorageSyncPrivateEndpointConnectionOperationSource : Core.IOperationSource<StorageSyncPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal StorageSyncPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageSyncPrivateEndpointConnectionResource Core.IOperationSource<StorageSyncPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageSyncPrivateEndpointConnectionData.DeserializeStorageSyncPrivateEndpointConnectionData(document.RootElement);
            return new StorageSyncPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<StorageSyncPrivateEndpointConnectionResource> Core.IOperationSource<StorageSyncPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageSyncPrivateEndpointConnectionData.DeserializeStorageSyncPrivateEndpointConnectionData(document.RootElement);
            return new StorageSyncPrivateEndpointConnectionResource(_client, data);
        }
    }
}
