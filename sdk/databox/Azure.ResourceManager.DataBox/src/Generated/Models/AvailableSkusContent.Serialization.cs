// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AvailableSkusContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Core.Optional.IsCollectionDefined(SkuNames))
            {
                writer.WritePropertyName("skuNames"u8);
                writer.WriteStartArray();
                foreach (var item in SkuNames)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
