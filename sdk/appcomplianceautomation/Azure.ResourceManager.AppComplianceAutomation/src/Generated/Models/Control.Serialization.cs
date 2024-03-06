// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class Control : IUtf8JsonSerializable, IJsonModel<Control>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Control>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Control>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Control>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Control)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ControlId))
            {
                writer.WritePropertyName("controlId"u8);
                writer.WriteStringValue(ControlId);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlShortName))
            {
                writer.WritePropertyName("controlShortName"u8);
                writer.WriteStringValue(ControlShortName);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlFullName))
            {
                writer.WritePropertyName("controlFullName"u8);
                writer.WriteStringValue(ControlFullName);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlType))
            {
                writer.WritePropertyName("controlType"u8);
                writer.WriteStringValue(ControlType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ControlDescription))
            {
                writer.WritePropertyName("controlDescription"u8);
                writer.WriteStringValue(ControlDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlDescriptionHyperLink))
            {
                writer.WritePropertyName("controlDescriptionHyperLink"u8);
                writer.WriteStringValue(ControlDescriptionHyperLink);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlStatus))
            {
                writer.WritePropertyName("controlStatus"u8);
                writer.WriteStringValue(ControlStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Assessments))
            {
                writer.WritePropertyName("assessments"u8);
                writer.WriteStartArray();
                foreach (var item in Assessments)
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

        Control IJsonModel<Control>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Control>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Control)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControl(document.RootElement, options);
        }

        internal static Control DeserializeControl(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string controlId = default;
            string controlShortName = default;
            string controlFullName = default;
            ControlType? controlType = default;
            string controlDescription = default;
            string controlDescriptionHyperLink = default;
            ControlStatus? controlStatus = default;
            IReadOnlyList<Assessment> assessments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlId"u8))
                {
                    controlId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlShortName"u8))
                {
                    controlShortName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlFullName"u8))
                {
                    controlFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlType = new ControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlDescription"u8))
                {
                    controlDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlDescriptionHyperLink"u8))
                {
                    controlDescriptionHyperLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlStatus = new ControlStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Assessment> array = new List<Assessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Assessment.DeserializeAssessment(item, options));
                    }
                    assessments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Control(
                controlId,
                controlShortName,
                controlFullName,
                controlType,
                controlDescription,
                controlDescriptionHyperLink,
                controlStatus,
                assessments ?? new ChangeTrackingList<Assessment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Control>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Control>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Control)} does not support '{options.Format}' format.");
            }
        }

        Control IPersistableModel<Control>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Control>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeControl(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Control)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Control>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
