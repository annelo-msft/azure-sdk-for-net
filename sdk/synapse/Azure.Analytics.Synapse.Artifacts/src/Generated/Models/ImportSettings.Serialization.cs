// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ImportSettingsConverter))]
    public partial class ImportSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ImportSettings DeserializeImportSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SnowflakeImportCopyCommand": return SnowflakeImportCopyCommand.DeserializeSnowflakeImportCopyCommand(element);
                    case "AzureDatabricksDeltaLakeImportCommand": return AzureDatabricksDeltaLakeImportCommand.DeserializeAzureDatabricksDeltaLakeImportCommand(element);
                }
            }
            return UnknownImportSettings.DeserializeUnknownImportSettings(element);
        }

        internal partial class ImportSettingsConverter : JsonConverter<ImportSettings>
        {
            public override void Write(Utf8JsonWriter writer, ImportSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ImportSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeImportSettings(document.RootElement);
            }
        }
    }
}
