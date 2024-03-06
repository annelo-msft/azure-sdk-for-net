// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    internal partial class DigitalTwinsEndpointResourceListResult : IUtf8JsonSerializable, IJsonModel<DigitalTwinsEndpointResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsEndpointResourceListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DigitalTwinsEndpointResourceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                if (NextLink != null)
                {
                    writer.WritePropertyName("nextLink"u8);
                    writer.WriteStringValue(NextLink);
                }
                else
                {
                    writer.WriteNull("nextLink");
                }
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DigitalTwinsEndpointResourceListResult IJsonModel<DigitalTwinsEndpointResourceListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement, options);
        }

        internal static DigitalTwinsEndpointResourceListResult DeserializeDigitalTwinsEndpointResourceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<DigitalTwinsEndpointResourceData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DigitalTwinsEndpointResourceData> array = new List<DigitalTwinsEndpointResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsEndpointResourceData.DeserializeDigitalTwinsEndpointResourceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DigitalTwinsEndpointResourceListResult(nextLink, value ?? new ChangeTrackingList<DigitalTwinsEndpointResourceData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DigitalTwinsEndpointResourceListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceListResult)} does not support '{options.Format}' format.");
            }
        }

        DigitalTwinsEndpointResourceListResult IPersistableModel<DigitalTwinsEndpointResourceListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDigitalTwinsEndpointResourceListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsEndpointResourceListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
