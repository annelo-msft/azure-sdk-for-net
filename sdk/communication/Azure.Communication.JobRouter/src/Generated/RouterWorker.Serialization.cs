// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterWorker : IUtf8JsonSerializable, IJsonModel<RouterWorker>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterWorker>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouterWorker>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorker>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterWorker)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Queues))
            {
                writer.WritePropertyName("queues"u8);
                writer.WriteStartArray();
                foreach (var item in Queues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsCollectionDefined(_labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in _labels)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(_tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in _tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteStartArray();
                foreach (var item in Channels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Offers))
            {
                writer.WritePropertyName("offers"u8);
                writer.WriteStartArray();
                foreach (var item in Offers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AssignedJobs))
            {
                writer.WritePropertyName("assignedJobs"u8);
                writer.WriteStartArray();
                foreach (var item in AssignedJobs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LoadRatio))
            {
                writer.WritePropertyName("loadRatio"u8);
                writer.WriteNumberValue(LoadRatio.Value);
            }
            if (Optional.IsDefined(AvailableForOffers))
            {
                writer.WritePropertyName("availableForOffers"u8);
                writer.WriteBooleanValue(AvailableForOffers.Value);
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

        RouterWorker IJsonModel<RouterWorker>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorker>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterWorker)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterWorker(document.RootElement, options);
        }

        internal static RouterWorker DeserializeRouterWorker(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag etag = default;
            string id = default;
            Optional<RouterWorkerState> state = default;
            Optional<IList<string>> queues = default;
            Optional<int> capacity = default;
            Optional<IDictionary<string, BinaryData>> labels = default;
            Optional<IDictionary<string, BinaryData>> tags = default;
            Optional<IList<RouterChannel>> channels = default;
            Optional<IReadOnlyList<RouterJobOffer>> offers = default;
            Optional<IReadOnlyList<RouterWorkerAssignment>> assignedJobs = default;
            Optional<double> loadRatio = default;
            Optional<bool> availableForOffers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new RouterWorkerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    queues = array;
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("channels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterChannel> array = new List<RouterChannel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterChannel.DeserializeRouterChannel(item));
                    }
                    channels = array;
                    continue;
                }
                if (property.NameEquals("offers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterJobOffer> array = new List<RouterJobOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterJobOffer.DeserializeRouterJobOffer(item));
                    }
                    offers = array;
                    continue;
                }
                if (property.NameEquals("assignedJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerAssignment> array = new List<RouterWorkerAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerAssignment.DeserializeRouterWorkerAssignment(item));
                    }
                    assignedJobs = array;
                    continue;
                }
                if (property.NameEquals("loadRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadRatio = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("availableForOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableForOffers = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterWorker(etag, id, Optional.ToNullable(state), Optional.ToList(queues), Optional.ToNullable(capacity), Optional.ToDictionary(labels), Optional.ToDictionary(tags), Optional.ToList(channels), Optional.ToList(offers), Optional.ToList(assignedJobs), Optional.ToNullable(loadRatio), Optional.ToNullable(availableForOffers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterWorker>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorker>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouterWorker)} does not support '{options.Format}' format.");
            }
        }

        RouterWorker IPersistableModel<RouterWorker>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorker>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterWorker(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouterWorker)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterWorker>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterWorker FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterWorker(document.RootElement);
        }
    }
}
