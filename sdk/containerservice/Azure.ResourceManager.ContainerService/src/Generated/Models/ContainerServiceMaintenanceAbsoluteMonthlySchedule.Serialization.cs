// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceAbsoluteMonthlySchedule : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("intervalMonths"u8);
            writer.WriteNumberValue(IntervalMonths);
            writer.WritePropertyName("dayOfMonth"u8);
            writer.WriteNumberValue(DayOfMonth);
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

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceAbsoluteMonthlySchedule DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalMonths = default;
            int dayOfMonth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalMonths"u8))
                {
                    intervalMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfMonth"u8))
                {
                    dayOfMonth = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceMaintenanceAbsoluteMonthlySchedule(intervalMonths, dayOfMonth, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
