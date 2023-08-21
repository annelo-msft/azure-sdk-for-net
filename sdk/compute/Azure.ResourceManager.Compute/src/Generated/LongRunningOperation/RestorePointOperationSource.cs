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
    internal class RestorePointOperationSource : Core.IOperationSource<RestorePointResource>
    {
        private readonly ArmClient _client;

        internal RestorePointOperationSource(ArmClient client)
        {
            _client = client;
        }

        RestorePointResource Core.IOperationSource<RestorePointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RestorePointData.DeserializeRestorePointData(document.RootElement);
            return new RestorePointResource(_client, data);
        }

        async ValueTask<RestorePointResource> Core.IOperationSource<RestorePointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RestorePointData.DeserializeRestorePointData(document.RootElement);
            return new RestorePointResource(_client, data);
        }
    }
}
