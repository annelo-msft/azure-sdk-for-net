// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBFirewallRuleData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("startIpAddress"u8);
            writer.WriteStringValue(StartIPAddress);
            writer.WritePropertyName("endIpAddress"u8);
            writer.WriteStringValue(EndIPAddress);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBFirewallRuleData DeserializeCosmosDBFirewallRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<CosmosDBProvisioningState> provisioningState = default;
            string startIPAddress = default;
            string endIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CosmosDBProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startIpAddress"u8))
                        {
                            startIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endIpAddress"u8))
                        {
                            endIPAddress = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CosmosDBFirewallRuleData(id, name, type, systemData.Value, Core.Optional.ToNullable(provisioningState), startIPAddress, endIPAddress);
        }
    }
}
