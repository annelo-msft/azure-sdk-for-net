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
    [JsonConverter(typeof(AzureDatabricksDeltaLakeExportCommandConverter))]
    public partial class AzureDatabricksDeltaLakeExportCommand : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteObjectValue(DateFormat);
            }
            if (Core.Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat"u8);
                writer.WriteObjectValue(TimestampFormat);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureDatabricksDeltaLakeExportCommand DeserializeAzureDatabricksDeltaLakeExportCommand(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<object> dateFormat = default;
            Core.Optional<object> timestampFormat = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("timestampFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksDeltaLakeExportCommand(type, additionalProperties, dateFormat.Value, timestampFormat.Value);
        }

        internal partial class AzureDatabricksDeltaLakeExportCommandConverter : JsonConverter<AzureDatabricksDeltaLakeExportCommand>
        {
            public override void Write(Utf8JsonWriter writer, AzureDatabricksDeltaLakeExportCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDatabricksDeltaLakeExportCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement);
            }
        }
    }
}
