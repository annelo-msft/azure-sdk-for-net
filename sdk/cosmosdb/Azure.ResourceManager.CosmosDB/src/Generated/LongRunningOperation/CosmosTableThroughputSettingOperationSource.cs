// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosTableThroughputSettingOperationSource : Core.IOperationSource<CosmosTableThroughputSettingResource>
    {
        private readonly ArmClient _client;
        private readonly Dictionary<string, string> _idMappings = new Dictionary<string, string>()
        {
            { "subscriptionId", "Microsoft.Resources/subscriptions" },
            { "resourceGroupName", "Microsoft.Resources/resourceGroups" },
            { "accountName", "Microsoft.DocumentDB/databaseAccounts" },
            { "tableName", "Microsoft.DocumentDB/databaseAccounts/tables" },
        };

        internal CosmosTableThroughputSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosTableThroughputSettingResource Core.IOperationSource<CosmosTableThroughputSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScrubId(ThroughputSettingData.DeserializeThroughputSettingData(document.RootElement));
            return new CosmosTableThroughputSettingResource(_client, data);
        }

        async ValueTask<CosmosTableThroughputSettingResource> Core.IOperationSource<CosmosTableThroughputSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScrubId(ThroughputSettingData.DeserializeThroughputSettingData(document.RootElement));
            return new CosmosTableThroughputSettingResource(_client, data);
        }

        private ThroughputSettingData ScrubId(ThroughputSettingData data)
        {
            if (data.Id.ResourceType == CosmosTableThroughputSettingResource.ResourceType)
                return data;

            var newId = CosmosTableThroughputSettingResource.CreateResourceIdentifier(
                GetName("subscriptionId", data.Id),
                GetName("resourceGroupName", data.Id),
                GetName("accountName", data.Id),
                GetName("tableName", data.Id));

            return new ThroughputSettingData(
                newId,
                newId.Name,
                newId.ResourceType,
                data.SystemData,
                data.Tags,
                data.Location,
                data.Resource,
                data.Identity);
        }

        private string GetName(string param, ResourceIdentifier id)
        {
            while (id.ResourceType != _idMappings[param])
                id = id.Parent;
            return id.Name;
        }
    }
}
