// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FormatReadSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatReadSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static FormatReadSettings DeserializeFormatReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BinaryReadSettings": return BinaryReadSettings.DeserializeBinaryReadSettings(element);
                    case "JsonReadSettings": return JsonReadSettings.DeserializeJsonReadSettings(element);
                    case "XmlReadSettings": return XmlReadSettings.DeserializeXmlReadSettings(element);
                    case "DelimitedTextReadSettings": return DelimitedTextReadSettings.DeserializeDelimitedTextReadSettings(element);
                }
            }
            return UnknownFormatReadSettings.DeserializeUnknownFormatReadSettings(element);
        }
    }
}
