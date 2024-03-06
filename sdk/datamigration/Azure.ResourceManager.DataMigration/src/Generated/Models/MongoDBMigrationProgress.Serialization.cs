// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBMigrationProgress : IUtf8JsonSerializable, IJsonModel<MongoDBMigrationProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBMigrationProgress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBMigrationProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBMigrationProgress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartObject();
                foreach (var item in Databases)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("bytesCopied"u8);
            writer.WriteNumberValue(BytesCopied);
            writer.WritePropertyName("documentsCopied"u8);
            writer.WriteNumberValue(DocumentsCopied);
            writer.WritePropertyName("elapsedTime"u8);
            writer.WriteStringValue(ElapsedTime);
            writer.WritePropertyName("errors"u8);
            writer.WriteStartObject();
            foreach (var item in Errors)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("eventsPending"u8);
            writer.WriteNumberValue(EventsPending);
            writer.WritePropertyName("eventsReplayed"u8);
            writer.WriteNumberValue(EventsReplayed);
            if (Optional.IsDefined(LastEventOn))
            {
                writer.WritePropertyName("lastEventTime"u8);
                writer.WriteStringValue(LastEventOn.Value, "O");
            }
            if (Optional.IsDefined(LastReplayOn))
            {
                writer.WritePropertyName("lastReplayTime"u8);
                writer.WriteStringValue(LastReplayOn.Value, "O");
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType.ToString());
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToString());
            writer.WritePropertyName("totalBytes"u8);
            writer.WriteNumberValue(TotalBytes);
            writer.WritePropertyName("totalDocuments"u8);
            writer.WriteNumberValue(TotalDocuments);
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

        MongoDBMigrationProgress IJsonModel<MongoDBMigrationProgress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBMigrationProgress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBMigrationProgress(document.RootElement, options);
        }

        internal static MongoDBMigrationProgress DeserializeMongoDBMigrationProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, MongoDBDatabaseProgress> databases = default;
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDBError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            DateTimeOffset? lastEventTime = default;
            DateTimeOffset? lastReplayTime = default;
            string name = default;
            string qualifiedName = default;
            MongoDBProgressResultType resultType = default;
            MongoDBMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MongoDBDatabaseProgress> dictionary = new Dictionary<string, MongoDBDatabaseProgress>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBDatabaseProgress.DeserializeMongoDBDatabaseProgress(property0.Value, options));
                    }
                    databases = dictionary;
                    continue;
                }
                if (property.NameEquals("bytesCopied"u8))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"u8))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"u8))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    Dictionary<string, MongoDBError> dictionary = new Dictionary<string, MongoDBError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBError.DeserializeMongoDBError(property0.Value, options));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"u8))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"u8))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = new MongoDBProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MongoDBMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"u8))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBMigrationProgress(
                bytesCopied,
                documentsCopied,
                elapsedTime,
                errors,
                eventsPending,
                eventsReplayed,
                lastEventTime,
                lastReplayTime,
                name,
                qualifiedName,
                resultType,
                state,
                totalBytes,
                totalDocuments,
                serializedAdditionalRawData,
                databases ?? new ChangeTrackingDictionary<string, MongoDBDatabaseProgress>());
        }

        BinaryData IPersistableModel<MongoDBMigrationProgress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBMigrationProgress)} does not support '{options.Format}' format.");
            }
        }

        MongoDBMigrationProgress IPersistableModel<MongoDBMigrationProgress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBMigrationProgress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBMigrationProgress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBMigrationProgress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
