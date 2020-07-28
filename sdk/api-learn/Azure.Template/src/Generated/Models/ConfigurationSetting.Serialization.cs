// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Learn.AppConfig.Models
{
    public partial class ConfigurationSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Key != null)
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            if (ContentType != null)
            {
                writer.WritePropertyName("content_type");
                writer.WriteStringValue(ContentType);
            }
            if (Value != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (LastModified != null)
            {
                writer.WritePropertyName("last_modified");
                writer.WriteStringValue(LastModified.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ConfigurationSetting DeserializeConfigurationSetting(JsonElement element)
        {
            string key = default;
            string contentType = default;
            string value = default;
            DateTimeOffset? lastModified = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content_type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("last_modified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ConfigurationSetting(key, contentType, value, lastModified);
        }
    }
}
