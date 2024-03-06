// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownCommandProperties))]
    public partial class CommandProperties : IUtf8JsonSerializable, IJsonModel<CommandProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommandProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommandProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommandProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("commandType"u8);
            writer.WriteStringValue(CommandType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        CommandProperties IJsonModel<CommandProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommandProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommandProperties(document.RootElement, options);
        }

        internal static CommandProperties DeserializeCommandProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("commandType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Migrate.SqlServer.AzureDbSqlMi.Complete": return MigrateMISyncCompleteCommandProperties.DeserializeMigrateMISyncCompleteCommandProperties(element, options);
                    case "Migrate.Sync.Complete.Database": return MigrateSyncCompleteCommandProperties.DeserializeMigrateSyncCompleteCommandProperties(element, options);
                    case "cancel": return MongoDBCancelCommand.DeserializeMongoDBCancelCommand(element, options);
                    case "finish": return MongoDBFinishCommand.DeserializeMongoDBFinishCommand(element, options);
                    case "restart": return MongoDBRestartCommand.DeserializeMongoDBRestartCommand(element, options);
                }
            }
            return UnknownCommandProperties.DeserializeUnknownCommandProperties(element, options);
        }

        BinaryData IPersistableModel<CommandProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommandProperties)} does not support '{options.Format}' format.");
            }
        }

        CommandProperties IPersistableModel<CommandProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommandProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommandProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommandProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
