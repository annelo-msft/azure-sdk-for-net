// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountSasPolicy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sasExpirationPeriod"u8);
            writer.WriteStringValue(SasExpirationPeriod);
            writer.WritePropertyName("expirationAction"u8);
            writer.WriteStringValue(ExpirationAction.ToString());
            writer.WriteEndObject();
        }

        internal static StorageAccountSasPolicy DeserializeStorageAccountSasPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sasExpirationPeriod = default;
            ExpirationAction expirationAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasExpirationPeriod"u8))
                {
                    sasExpirationPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationAction"u8))
                {
                    expirationAction = new ExpirationAction(property.Value.GetString());
                    continue;
                }
            }
            return new StorageAccountSasPolicy(sasExpirationPeriod, expirationAction);
        }
    }
}
