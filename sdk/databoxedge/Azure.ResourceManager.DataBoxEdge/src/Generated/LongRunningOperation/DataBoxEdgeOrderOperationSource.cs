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
    internal class DataBoxEdgeOrderOperationSource : Core.IOperationSource<DataBoxEdgeOrderResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeOrderOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeOrderResource Core.IOperationSource<DataBoxEdgeOrderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeOrderData.DeserializeDataBoxEdgeOrderData(document.RootElement);
            return new DataBoxEdgeOrderResource(_client, data);
        }

        async ValueTask<DataBoxEdgeOrderResource> Core.IOperationSource<DataBoxEdgeOrderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeOrderData.DeserializeDataBoxEdgeOrderData(document.RootElement);
            return new DataBoxEdgeOrderResource(_client, data);
        }
    }
}
