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
    internal class VCenterOperationSource : Core.IOperationSource<VCenterResource>
    {
        private readonly ArmClient _client;

        internal VCenterOperationSource(ArmClient client)
        {
            _client = client;
        }

        VCenterResource Core.IOperationSource<VCenterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VCenterData.DeserializeVCenterData(document.RootElement);
            return new VCenterResource(_client, data);
        }

        async ValueTask<VCenterResource> Core.IOperationSource<VCenterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VCenterData.DeserializeVCenterData(document.RootElement);
            return new VCenterResource(_client, data);
        }
    }
}
