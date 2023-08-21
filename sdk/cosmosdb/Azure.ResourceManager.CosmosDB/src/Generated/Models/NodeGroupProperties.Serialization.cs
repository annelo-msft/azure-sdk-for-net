// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class NodeGroupProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Core.Optional.IsDefined(DiskSizeInGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeInGB.Value);
            }
            if (Core.Optional.IsDefined(EnableHa))
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(EnableHa.Value);
            }
            writer.WriteEndObject();
        }

        internal static NodeGroupProperties DeserializeNodeGroupProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> sku = default;
            Core.Optional<long> diskSizeGB = default;
            Core.Optional<bool> enableHa = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enableHa"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableHa = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NodeGroupProperties(sku.Value, Core.Optional.ToNullable(diskSizeGB), Core.Optional.ToNullable(enableHa));
        }
    }
}
