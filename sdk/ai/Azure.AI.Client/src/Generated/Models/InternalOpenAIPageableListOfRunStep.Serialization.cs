// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Client.Models
{
    internal partial class InternalOpenAIPageableListOfRunStep : IUtf8JsonSerializable, IJsonModel<InternalOpenAIPageableListOfRunStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalOpenAIPageableListOfRunStep>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InternalOpenAIPageableListOfRunStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfRunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfRunStep)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("first_id"u8);
            writer.WriteStringValue(FirstId);
            writer.WritePropertyName("last_id"u8);
            writer.WriteStringValue(LastId);
            writer.WritePropertyName("has_more"u8);
            writer.WriteBooleanValue(HasMore);
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

        InternalOpenAIPageableListOfRunStep IJsonModel<InternalOpenAIPageableListOfRunStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfRunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfRunStep)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalOpenAIPageableListOfRunStep(document.RootElement, options);
        }

        internal static InternalOpenAIPageableListOfRunStep DeserializeInternalOpenAIPageableListOfRunStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenAIPageableListOfRunStepObject @object = default;
            IReadOnlyList<RunStep> data = default;
            string firstId = default;
            string lastId = default;
            bool hasMore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = new OpenAIPageableListOfRunStepObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<RunStep> array = new List<RunStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStep.DeserializeRunStep(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("first_id"u8))
                {
                    firstId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("last_id"u8))
                {
                    lastId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("has_more"u8))
                {
                    hasMore = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalOpenAIPageableListOfRunStep(
                @object,
                data,
                firstId,
                lastId,
                hasMore,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalOpenAIPageableListOfRunStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfRunStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfRunStep)} does not support writing '{options.Format}' format.");
            }
        }

        InternalOpenAIPageableListOfRunStep IPersistableModel<InternalOpenAIPageableListOfRunStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfRunStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalOpenAIPageableListOfRunStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfRunStep)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalOpenAIPageableListOfRunStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InternalOpenAIPageableListOfRunStep FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalOpenAIPageableListOfRunStep(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
