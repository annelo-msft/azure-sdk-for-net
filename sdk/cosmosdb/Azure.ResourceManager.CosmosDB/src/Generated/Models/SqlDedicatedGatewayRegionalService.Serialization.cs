// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SqlDedicatedGatewayRegionalService
    {
        internal static SqlDedicatedGatewayRegionalService DeserializeSqlDedicatedGatewayRegionalService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> sqlDedicatedGatewayEndpoint = default;
            Core.Optional<string> name = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<CosmosDBServiceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlDedicatedGatewayEndpoint"u8))
                {
                    sqlDedicatedGatewayEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBServiceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new SqlDedicatedGatewayRegionalService(name.Value, Core.Optional.ToNullable(location), Core.Optional.ToNullable(status), sqlDedicatedGatewayEndpoint.Value);
        }
    }
}
