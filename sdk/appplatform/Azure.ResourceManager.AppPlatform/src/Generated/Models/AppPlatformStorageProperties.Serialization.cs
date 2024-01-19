// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    [PersistableModelProxy(typeof(UnknownStorageProperties))]
    public partial class AppPlatformStorageProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformStorageProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformStorageProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformStorageProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformStorageProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageType"u8);
            writer.WriteStringValue(StorageType.ToString());
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

        AppPlatformStorageProperties IJsonModel<AppPlatformStorageProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformStorageProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformStorageProperties(document.RootElement, options);
        }

        internal static AppPlatformStorageProperties DeserializeAppPlatformStorageProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("storageType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageAccount": return AppPlatformStorageAccount.DeserializeAppPlatformStorageAccount(element);
                }
            }
            return UnknownStorageProperties.DeserializeUnknownStorageProperties(element);
        }

        BinaryData IPersistableModel<AppPlatformStorageProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformStorageProperties IPersistableModel<AppPlatformStorageProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformStorageProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformStorageProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
