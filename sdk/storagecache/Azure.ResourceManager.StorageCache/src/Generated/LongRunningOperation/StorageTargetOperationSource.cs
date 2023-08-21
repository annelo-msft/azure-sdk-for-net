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

namespace Azure.ResourceManager.StorageCache
{
    internal class StorageTargetOperationSource : Core.IOperationSource<StorageTargetResource>
    {
        private readonly ArmClient _client;

        internal StorageTargetOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageTargetResource Core.IOperationSource<StorageTargetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageTargetData.DeserializeStorageTargetData(document.RootElement);
            return new StorageTargetResource(_client, data);
        }

        async ValueTask<StorageTargetResource> Core.IOperationSource<StorageTargetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageTargetData.DeserializeStorageTargetData(document.RootElement);
            return new StorageTargetResource(_client, data);
        }
    }
}
