// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeComputeProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Core.Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Core.Optional.IsDefined(NumberOfNodes))
            {
                writer.WritePropertyName("numberOfNodes"u8);
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (Core.Optional.IsDefined(MaxParallelExecutionsPerNode))
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode"u8);
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (Core.Optional.IsDefined(DataFlowProperties))
            {
                writer.WritePropertyName("dataFlowProperties"u8);
                writer.WriteObjectValue(DataFlowProperties);
            }
            if (Core.Optional.IsDefined(VnetProperties))
            {
                writer.WritePropertyName("vNetProperties"u8);
                writer.WriteObjectValue(VnetProperties);
            }
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

        internal static SynapseIntegrationRuntimeComputeProperties DeserializeSynapseIntegrationRuntimeComputeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AzureLocation> location = default;
            Core.Optional<string> nodeSize = default;
            Core.Optional<int> numberOfNodes = default;
            Core.Optional<int> maxParallelExecutionsPerNode = default;
            Core.Optional<SynapseIntegrationRuntimeDataFlowProperties> dataFlowProperties = default;
            Core.Optional<SynapseIntegrationRuntimeVnetProperties> vNetProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlowProperties = SynapseIntegrationRuntimeDataFlowProperties.DeserializeSynapseIntegrationRuntimeDataFlowProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("vNetProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vNetProperties = SynapseIntegrationRuntimeVnetProperties.DeserializeSynapseIntegrationRuntimeVnetProperties(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeComputeProperties(Core.Optional.ToNullable(location), nodeSize.Value, Core.Optional.ToNullable(numberOfNodes), Core.Optional.ToNullable(maxParallelExecutionsPerNode), dataFlowProperties.Value, vNetProperties.Value, additionalProperties);
        }
    }
}
