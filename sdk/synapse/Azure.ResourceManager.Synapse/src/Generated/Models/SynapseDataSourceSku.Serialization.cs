// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataSourceSku : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            if (Core.Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WritePropertyName("size"u8);
            writer.WriteStringValue(Size.ToString());
            writer.WriteEndObject();
        }

        internal static SynapseDataSourceSku DeserializeSynapseDataSourceSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseSkuName name = default;
            Core.Optional<int> capacity = default;
            KustoPoolSkuSize size = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new SynapseSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = new KustoPoolSkuSize(property.Value.GetString());
                    continue;
                }
            }
            return new SynapseDataSourceSku(name, Core.Optional.ToNullable(capacity), size);
        }
    }
}
