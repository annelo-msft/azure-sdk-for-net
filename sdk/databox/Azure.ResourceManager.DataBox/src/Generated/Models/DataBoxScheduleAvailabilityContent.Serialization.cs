// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxScheduleAvailabilityContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageLocation"u8);
            writer.WriteStringValue(StorageLocation);
            writer.WritePropertyName("skuName"u8);
            writer.WriteStringValue(SkuName.ToSerialString());
            if (Core.Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            writer.WriteEndObject();
        }
    }
}
