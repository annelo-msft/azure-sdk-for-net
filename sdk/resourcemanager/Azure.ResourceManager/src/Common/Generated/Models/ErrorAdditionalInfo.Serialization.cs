// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(ErrorAdditionalInfoConverter))]
    public partial class ErrorAdditionalInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ErrorAdditionalInfo DeserializeErrorAdditionalInfo(JsonElement element)
        {
            Optional<ResourceType> type = default;
            Optional<object> info = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    info = property.Value.GetObject();
                    continue;
                }
            }
            return new ErrorAdditionalInfo(type, info.Value);
        }

        internal partial class ErrorAdditionalInfoConverter : JsonConverter<ErrorAdditionalInfo>
        {
            public override void Write(Utf8JsonWriter writer, ErrorAdditionalInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ErrorAdditionalInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeErrorAdditionalInfo(document.RootElement);
            }
        }
    }
}
