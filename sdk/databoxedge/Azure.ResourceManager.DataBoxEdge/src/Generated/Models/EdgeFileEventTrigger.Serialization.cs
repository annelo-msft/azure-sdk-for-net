// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeFileEventTrigger : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sourceInfo"u8);
            writer.WriteObjectValue(SourceInfo);
            writer.WritePropertyName("sinkInfo"u8);
            writer.WriteObjectValue(SinkInfo);
            if (Core.Optional.IsDefined(CustomContextTag))
            {
                writer.WritePropertyName("customContextTag"u8);
                writer.WriteStringValue(CustomContextTag);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EdgeFileEventTrigger DeserializeEdgeFileEventTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerEventType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            EdgeFileSourceInfo sourceInfo = default;
            DataBoxEdgeRoleSinkInfo sinkInfo = default;
            Core.Optional<string> customContextTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new TriggerEventType(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("sourceInfo"u8))
                        {
                            sourceInfo = EdgeFileSourceInfo.DeserializeEdgeFileSourceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sinkInfo"u8))
                        {
                            sinkInfo = DataBoxEdgeRoleSinkInfo.DeserializeDataBoxEdgeRoleSinkInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customContextTag"u8))
                        {
                            customContextTag = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EdgeFileEventTrigger(id, name, type, systemData.Value, kind, sourceInfo, sinkInfo, customContextTag.Value);
        }
    }
}
