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

namespace Azure.ResourceManager.AppContainers
{
    internal class ContainerAppOperationSource : Core.IOperationSource<ContainerAppResource>
    {
        private readonly ArmClient _client;

        internal ContainerAppOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerAppResource Core.IOperationSource<ContainerAppResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerAppData.DeserializeContainerAppData(document.RootElement);
            return new ContainerAppResource(_client, data);
        }

        async ValueTask<ContainerAppResource> Core.IOperationSource<ContainerAppResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerAppData.DeserializeContainerAppData(document.RootElement);
            return new ContainerAppResource(_client, data);
        }
    }
}
