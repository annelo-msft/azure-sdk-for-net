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
    internal class AmlFileSystemOperationSource : Core.IOperationSource<AmlFileSystemResource>
    {
        private readonly ArmClient _client;

        internal AmlFileSystemOperationSource(ArmClient client)
        {
            _client = client;
        }

        AmlFileSystemResource Core.IOperationSource<AmlFileSystemResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AmlFileSystemData.DeserializeAmlFileSystemData(document.RootElement);
            return new AmlFileSystemResource(_client, data);
        }

        async ValueTask<AmlFileSystemResource> Core.IOperationSource<AmlFileSystemResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AmlFileSystemData.DeserializeAmlFileSystemData(document.RootElement);
            return new AmlFileSystemResource(_client, data);
        }
    }
}
