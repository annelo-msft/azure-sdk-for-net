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

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBSqlTriggerOperationSource : Core.IOperationSource<CosmosDBSqlTriggerResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBSqlTriggerOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBSqlTriggerResource Core.IOperationSource<CosmosDBSqlTriggerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBSqlTriggerData.DeserializeCosmosDBSqlTriggerData(document.RootElement);
            return new CosmosDBSqlTriggerResource(_client, data);
        }

        async ValueTask<CosmosDBSqlTriggerResource> Core.IOperationSource<CosmosDBSqlTriggerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBSqlTriggerData.DeserializeCosmosDBSqlTriggerData(document.RootElement);
            return new CosmosDBSqlTriggerResource(_client, data);
        }
    }
}
