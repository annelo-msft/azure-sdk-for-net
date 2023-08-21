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
    internal class DataBoxEdgeStorageAccountOperationSource : Core.IOperationSource<DataBoxEdgeStorageAccountResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeStorageAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeStorageAccountResource Core.IOperationSource<DataBoxEdgeStorageAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeStorageAccountData.DeserializeDataBoxEdgeStorageAccountData(document.RootElement);
            return new DataBoxEdgeStorageAccountResource(_client, data);
        }

        async ValueTask<DataBoxEdgeStorageAccountResource> Core.IOperationSource<DataBoxEdgeStorageAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeStorageAccountData.DeserializeDataBoxEdgeStorageAccountData(document.RootElement);
            return new DataBoxEdgeStorageAccountResource(_client, data);
        }
    }
}
