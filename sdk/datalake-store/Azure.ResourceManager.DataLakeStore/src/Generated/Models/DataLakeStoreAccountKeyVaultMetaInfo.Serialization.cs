// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountKeyVaultMetaInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultResourceId"u8);
            writer.WriteStringValue(KeyVaultResourceId);
            writer.WritePropertyName("encryptionKeyName"u8);
            writer.WriteStringValue(EncryptionKeyName);
            writer.WritePropertyName("encryptionKeyVersion"u8);
            writer.WriteStringValue(EncryptionKeyVersion);
            writer.WriteEndObject();
        }

        internal static DataLakeStoreAccountKeyVaultMetaInfo DeserializeDataLakeStoreAccountKeyVaultMetaInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyVaultResourceId = default;
            string encryptionKeyName = default;
            string encryptionKeyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultResourceId"u8))
                {
                    keyVaultResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKeyName"u8))
                {
                    encryptionKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKeyVersion"u8))
                {
                    encryptionKeyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeStoreAccountKeyVaultMetaInfo(keyVaultResourceId, encryptionKeyName, encryptionKeyVersion);
        }
    }
}
