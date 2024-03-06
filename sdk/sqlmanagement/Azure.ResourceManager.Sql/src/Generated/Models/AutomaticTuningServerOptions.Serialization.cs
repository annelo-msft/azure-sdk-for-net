// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class AutomaticTuningServerOptions : IUtf8JsonSerializable, IJsonModel<AutomaticTuningServerOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomaticTuningServerOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomaticTuningServerOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticTuningServerOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomaticTuningServerOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActualState))
            {
                writer.WritePropertyName("actualState"u8);
                writer.WriteStringValue(ActualState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReasonCode))
            {
                writer.WritePropertyName("reasonCode"u8);
                writer.WriteNumberValue(ReasonCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReasonDesc))
            {
                writer.WritePropertyName("reasonDesc"u8);
                writer.WriteStringValue(ReasonDesc.Value.ToSerialString());
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

        AutomaticTuningServerOptions IJsonModel<AutomaticTuningServerOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticTuningServerOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomaticTuningServerOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomaticTuningServerOptions(document.RootElement, options);
        }

        internal static AutomaticTuningServerOptions DeserializeAutomaticTuningServerOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutomaticTuningOptionModeDesired? desiredState = default;
            AutomaticTuningOptionModeActual? actualState = default;
            int? reasonCode = default;
            AutomaticTuningServerReason? reasonDesc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desiredState = property.Value.GetString().ToAutomaticTuningOptionModeDesired();
                    continue;
                }
                if (property.NameEquals("actualState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actualState = property.Value.GetString().ToAutomaticTuningOptionModeActual();
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reasonDesc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonDesc = property.Value.GetString().ToAutomaticTuningServerReason();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomaticTuningServerOptions(desiredState, actualState, reasonCode, reasonDesc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomaticTuningServerOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticTuningServerOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomaticTuningServerOptions)} does not support '{options.Format}' format.");
            }
        }

        AutomaticTuningServerOptions IPersistableModel<AutomaticTuningServerOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticTuningServerOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomaticTuningServerOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomaticTuningServerOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomaticTuningServerOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
