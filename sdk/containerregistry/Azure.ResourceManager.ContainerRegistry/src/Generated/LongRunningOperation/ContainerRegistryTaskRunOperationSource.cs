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

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryTaskRunOperationSource : Core.IOperationSource<ContainerRegistryTaskRunResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryTaskRunOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryTaskRunResource Core.IOperationSource<ContainerRegistryTaskRunResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerRegistryTaskRunData.DeserializeContainerRegistryTaskRunData(document.RootElement);
            return new ContainerRegistryTaskRunResource(_client, data);
        }

        async ValueTask<ContainerRegistryTaskRunResource> Core.IOperationSource<ContainerRegistryTaskRunResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerRegistryTaskRunData.DeserializeContainerRegistryTaskRunData(document.RootElement);
            return new ContainerRegistryTaskRunResource(_client, data);
        }
    }
}
