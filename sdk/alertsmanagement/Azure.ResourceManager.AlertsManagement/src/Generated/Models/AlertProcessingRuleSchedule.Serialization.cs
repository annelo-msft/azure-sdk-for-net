// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleSchedule : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertProcessingRuleSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EffectiveFrom))
            {
                writer.WritePropertyName("effectiveFrom"u8);
                writer.WriteStringValue(EffectiveFrom.Value, "O");
            }
            if (Optional.IsDefined(EffectiveUntil))
            {
                writer.WritePropertyName("effectiveUntil"u8);
                writer.WriteStringValue(EffectiveUntil.Value, "O");
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsCollectionDefined(Recurrences))
            {
                writer.WritePropertyName("recurrences"u8);
                writer.WriteStartArray();
                foreach (var item in Recurrences)
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

        AlertProcessingRuleSchedule IJsonModel<AlertProcessingRuleSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleSchedule(document.RootElement, options);
        }

        internal static AlertProcessingRuleSchedule DeserializeAlertProcessingRuleSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? effectiveFrom = default;
            DateTimeOffset? effectiveUntil = default;
            string timeZone = default;
            IList<AlertProcessingRuleRecurrence> recurrences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("effectiveFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("effectiveUntil"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recurrences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlertProcessingRuleRecurrence> array = new List<AlertProcessingRuleRecurrence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingRuleRecurrence.DeserializeAlertProcessingRuleRecurrence(item, options));
                    }
                    recurrences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertProcessingRuleSchedule(effectiveFrom, effectiveUntil, timeZone, recurrences ?? new ChangeTrackingList<AlertProcessingRuleRecurrence>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlertProcessingRuleSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleSchedule)} does not support '{options.Format}' format.");
            }
        }

        AlertProcessingRuleSchedule IPersistableModel<AlertProcessingRuleSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertProcessingRuleSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
