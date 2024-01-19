// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestPropertiesValidationRulesContentValidation : IUtf8JsonSerializable, IJsonModel<WebTestPropertiesValidationRulesContentValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebTestPropertiesValidationRulesContentValidation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebTestPropertiesValidationRulesContentValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRulesContentValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesValidationRulesContentValidation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentMatch))
            {
                writer.WritePropertyName("ContentMatch"u8);
                writer.WriteStringValue(ContentMatch);
            }
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("IgnoreCase"u8);
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Optional.IsDefined(PassIfTextFound))
            {
                writer.WritePropertyName("PassIfTextFound"u8);
                writer.WriteBooleanValue(PassIfTextFound.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        WebTestPropertiesValidationRulesContentValidation IJsonModel<WebTestPropertiesValidationRulesContentValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRulesContentValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestPropertiesValidationRulesContentValidation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestPropertiesValidationRulesContentValidation(document.RootElement, options);
        }

        internal static WebTestPropertiesValidationRulesContentValidation DeserializeWebTestPropertiesValidationRulesContentValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> contentMatch = default;
            Optional<bool> ignoreCase = default;
            Optional<bool> passIfTextFound = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ContentMatch"u8))
                {
                    contentMatch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IgnoreCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("PassIfTextFound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    passIfTextFound = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebTestPropertiesValidationRulesContentValidation(contentMatch.Value, Optional.ToNullable(ignoreCase), Optional.ToNullable(passIfTextFound), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebTestPropertiesValidationRulesContentValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRulesContentValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesValidationRulesContentValidation)} does not support '{options.Format}' format.");
            }
        }

        WebTestPropertiesValidationRulesContentValidation IPersistableModel<WebTestPropertiesValidationRulesContentValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestPropertiesValidationRulesContentValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebTestPropertiesValidationRulesContentValidation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebTestPropertiesValidationRulesContentValidation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebTestPropertiesValidationRulesContentValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
