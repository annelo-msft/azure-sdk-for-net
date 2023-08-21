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
    internal class DataBoxEdgeRoleOperationSource : Core.IOperationSource<DataBoxEdgeRoleResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeRoleOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeRoleResource Core.IOperationSource<DataBoxEdgeRoleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeRoleData.DeserializeDataBoxEdgeRoleData(document.RootElement);
            return new DataBoxEdgeRoleResource(_client, data);
        }

        async ValueTask<DataBoxEdgeRoleResource> Core.IOperationSource<DataBoxEdgeRoleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeRoleData.DeserializeDataBoxEdgeRoleData(document.RootElement);
            return new DataBoxEdgeRoleResource(_client, data);
        }
    }
}
