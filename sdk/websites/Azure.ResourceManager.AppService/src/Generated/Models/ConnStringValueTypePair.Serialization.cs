// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ConnStringValueTypePair : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionStringType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static ConnStringValueTypePair DeserializeConnStringValueTypePair(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string value = default;
            ConnectionStringType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToConnectionStringType();
                    continue;
                }
            }
            return new ConnStringValueTypePair(value, type);
        }
    }
}
