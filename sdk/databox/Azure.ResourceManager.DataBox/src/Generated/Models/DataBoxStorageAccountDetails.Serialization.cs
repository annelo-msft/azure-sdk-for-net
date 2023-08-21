// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxStorageAccountDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountId"u8);
            writer.WriteStringValue(StorageAccountId);
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Core.Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword"u8);
                writer.WriteStringValue(SharePassword);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxStorageAccountDetails DeserializeDataBoxStorageAccountDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier storageAccountId = default;
            DataAccountType dataAccountType = default;
            Core.Optional<string> sharePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("sharePassword"u8))
                {
                    sharePassword = property.Value.GetString();
                    continue;
                }
            }
            return new DataBoxStorageAccountDetails(dataAccountType, sharePassword.Value, storageAccountId);
        }
    }
}
