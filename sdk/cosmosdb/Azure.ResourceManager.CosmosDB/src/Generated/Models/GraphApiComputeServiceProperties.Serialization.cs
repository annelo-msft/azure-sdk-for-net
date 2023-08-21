// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GraphApiComputeServiceProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(GraphApiComputeEndpoint))
            {
                writer.WritePropertyName("graphApiComputeEndpoint"u8);
                writer.WriteStringValue(GraphApiComputeEndpoint);
            }
            if (Core.Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize"u8);
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Core.Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType"u8);
            writer.WriteStringValue(ServiceType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static GraphApiComputeServiceProperties DeserializeGraphApiComputeServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> graphApiComputeEndpoint = default;
            Core.Optional<IReadOnlyList<GraphApiComputeRegionalService>> locations = default;
            Core.Optional<DateTimeOffset> creationTime = default;
            Core.Optional<CosmosDBServiceSize> instanceSize = default;
            Core.Optional<int> instanceCount = default;
            CosmosDBServiceType serviceType = default;
            Core.Optional<CosmosDBServiceStatus> status = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("graphApiComputeEndpoint"u8))
                {
                    graphApiComputeEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GraphApiComputeRegionalService> array = new List<GraphApiComputeRegionalService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GraphApiComputeRegionalService.DeserializeGraphApiComputeRegionalService(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceSize = new CosmosDBServiceSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = new CosmosDBServiceType(property.Value.GetString());
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
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GraphApiComputeServiceProperties(Core.Optional.ToNullable(creationTime), Core.Optional.ToNullable(instanceSize), Core.Optional.ToNullable(instanceCount), serviceType, Core.Optional.ToNullable(status), additionalProperties, graphApiComputeEndpoint.Value, Core.Optional.ToList(locations));
        }
    }
}
