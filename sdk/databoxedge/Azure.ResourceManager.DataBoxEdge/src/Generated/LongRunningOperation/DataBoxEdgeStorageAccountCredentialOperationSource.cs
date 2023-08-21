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
    internal class DataBoxEdgeStorageAccountCredentialOperationSource : Core.IOperationSource<DataBoxEdgeStorageAccountCredentialResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeStorageAccountCredentialOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeStorageAccountCredentialResource Core.IOperationSource<DataBoxEdgeStorageAccountCredentialResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeStorageAccountCredentialData.DeserializeDataBoxEdgeStorageAccountCredentialData(document.RootElement);
            return new DataBoxEdgeStorageAccountCredentialResource(_client, data);
        }

        async ValueTask<DataBoxEdgeStorageAccountCredentialResource> Core.IOperationSource<DataBoxEdgeStorageAccountCredentialResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeStorageAccountCredentialData.DeserializeDataBoxEdgeStorageAccountCredentialData(document.RootElement);
            return new DataBoxEdgeStorageAccountCredentialResource(_client, data);
        }
    }
}
