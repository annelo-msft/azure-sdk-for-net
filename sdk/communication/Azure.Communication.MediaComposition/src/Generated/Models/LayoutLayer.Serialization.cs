// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class LayoutLayer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zIndex"u8);
            writer.WriteNumberValue(ZIndex);
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static LayoutLayer DeserializeLayoutLayer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int zIndex = default;
            LayerVisibility? visibility = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zIndex"u8))
                {
                    zIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visibility = new LayerVisibility(property.Value.GetString());
                    continue;
                }
            }
            return new LayoutLayer(zIndex, visibility);
        }
    }
}
