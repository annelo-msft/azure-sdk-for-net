// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownStoreWriteSettings))]
    public partial class StoreWriteSettings : IUtf8JsonSerializable, IJsonModel<StoreWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StoreWriteSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StoreWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoreWriteSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreWriteSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior"u8);
                JsonSerializer.Serialize(writer, CopyBehavior);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        StoreWriteSettings IJsonModel<StoreWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoreWriteSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStoreWriteSettings(document.RootElement, options);
        }

        internal static StoreWriteSettings DeserializeStoreWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobFSWriteSettings": return AzureBlobFSWriteSettings.DeserializeAzureBlobFSWriteSettings(element);
                    case "AzureBlobStorageWriteSettings": return AzureBlobStorageWriteSettings.DeserializeAzureBlobStorageWriteSettings(element);
                    case "AzureDataLakeStoreWriteSettings": return AzureDataLakeStoreWriteSettings.DeserializeAzureDataLakeStoreWriteSettings(element);
                    case "AzureFileStorageWriteSettings": return AzureFileStorageWriteSettings.DeserializeAzureFileStorageWriteSettings(element);
                    case "FileServerWriteSettings": return FileServerWriteSettings.DeserializeFileServerWriteSettings(element);
                    case "LakeHouseWriteSettings": return LakeHouseWriteSettings.DeserializeLakeHouseWriteSettings(element);
                    case "SftpWriteSettings": return SftpWriteSettings.DeserializeSftpWriteSettings(element);
                }
            }
            return UnknownStoreWriteSettings.DeserializeUnknownStoreWriteSettings(element);
        }

        BinaryData IPersistableModel<StoreWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StoreWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        StoreWriteSettings IPersistableModel<StoreWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStoreWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StoreWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StoreWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
