// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(PolybaseSettingsConverter))]
    public partial class PolybaseSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RejectType))
            {
                writer.WritePropertyName("rejectType"u8);
                writer.WriteStringValue(RejectType.Value.ToString());
            }
            if (Core.Optional.IsDefined(RejectValue))
            {
                writer.WritePropertyName("rejectValue"u8);
                writer.WriteObjectValue(RejectValue);
            }
            if (Core.Optional.IsDefined(RejectSampleValue))
            {
                writer.WritePropertyName("rejectSampleValue"u8);
                writer.WriteObjectValue(RejectSampleValue);
            }
            if (Core.Optional.IsDefined(UseTypeDefault))
            {
                writer.WritePropertyName("useTypeDefault"u8);
                writer.WriteObjectValue(UseTypeDefault);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static PolybaseSettings DeserializePolybaseSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<PolybaseSettingsRejectType> rejectType = default;
            Core.Optional<object> rejectValue = default;
            Core.Optional<object> rejectSampleValue = default;
            Core.Optional<object> useTypeDefault = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rejectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectType = new PolybaseSettingsRejectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rejectValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rejectSampleValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectSampleValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("useTypeDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTypeDefault = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolybaseSettings(Core.Optional.ToNullable(rejectType), rejectValue.Value, rejectSampleValue.Value, useTypeDefault.Value, additionalProperties);
        }

        internal partial class PolybaseSettingsConverter : JsonConverter<PolybaseSettings>
        {
            public override void Write(Utf8JsonWriter writer, PolybaseSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PolybaseSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolybaseSettings(document.RootElement);
            }
        }
    }
}
