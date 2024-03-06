// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataLakeStorageAccountDetailsConverter))]
    public partial class DataLakeStorageAccountDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountUrl))
            {
                writer.WritePropertyName("accountUrl"u8);
                writer.WriteStringValue(AccountUrl);
            }
            if (Optional.IsDefined(Filesystem))
            {
                writer.WritePropertyName("filesystem"u8);
                writer.WriteStringValue(Filesystem);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeStorageAccountDetails DeserializeDataLakeStorageAccountDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountUrl = default;
            string filesystem = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountUrl"u8))
                {
                    accountUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filesystem"u8))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeStorageAccountDetails(accountUrl, filesystem);
        }

        internal partial class DataLakeStorageAccountDetailsConverter : JsonConverter<DataLakeStorageAccountDetails>
        {
            public override void Write(Utf8JsonWriter writer, DataLakeStorageAccountDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataLakeStorageAccountDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataLakeStorageAccountDetails(document.RootElement);
            }
        }
    }
}
