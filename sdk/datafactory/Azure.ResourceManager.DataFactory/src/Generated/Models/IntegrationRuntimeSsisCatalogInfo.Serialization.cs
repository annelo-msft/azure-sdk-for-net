// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeSsisCatalogInfo : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeSsisCatalogInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeSsisCatalogInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeSsisCatalogInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisCatalogInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeSsisCatalogInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogServerEndpoint))
            {
                writer.WritePropertyName("catalogServerEndpoint"u8);
                writer.WriteStringValue(CatalogServerEndpoint);
            }
            if (Optional.IsDefined(CatalogAdminUserName))
            {
                writer.WritePropertyName("catalogAdminUserName"u8);
                writer.WriteStringValue(CatalogAdminUserName);
            }
            if (Optional.IsDefined(CatalogAdminPassword))
            {
                writer.WritePropertyName("catalogAdminPassword"u8);
                JsonSerializer.Serialize(writer, CatalogAdminPassword);
            }
            if (Optional.IsDefined(CatalogPricingTier))
            {
                writer.WritePropertyName("catalogPricingTier"u8);
                writer.WriteStringValue(CatalogPricingTier.Value.ToString());
            }
            if (Optional.IsDefined(DualStandbyPairName))
            {
                writer.WritePropertyName("dualStandbyPairName"u8);
                writer.WriteStringValue(DualStandbyPairName);
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

        IntegrationRuntimeSsisCatalogInfo IJsonModel<IntegrationRuntimeSsisCatalogInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisCatalogInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeSsisCatalogInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeSsisCatalogInfo(document.RootElement, options);
        }

        internal static IntegrationRuntimeSsisCatalogInfo DeserializeIntegrationRuntimeSsisCatalogInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> catalogServerEndpoint = default;
            Optional<string> catalogAdminUserName = default;
            Optional<DataFactorySecretString> catalogAdminPassword = default;
            Optional<IntegrationRuntimeSsisCatalogPricingTier> catalogPricingTier = default;
            Optional<string> dualStandbyPairName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogServerEndpoint"u8))
                {
                    catalogServerEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminUserName"u8))
                {
                    catalogAdminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogAdminPassword = JsonSerializer.Deserialize<DataFactorySecretString>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("catalogPricingTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogPricingTier = new IntegrationRuntimeSsisCatalogPricingTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dualStandbyPairName"u8))
                {
                    dualStandbyPairName = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisCatalogInfo(catalogServerEndpoint.Value, catalogAdminUserName.Value, catalogAdminPassword, Optional.ToNullable(catalogPricingTier), dualStandbyPairName.Value, additionalProperties);
        }

        BinaryData IPersistableModel<IntegrationRuntimeSsisCatalogInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisCatalogInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeSsisCatalogInfo)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeSsisCatalogInfo IPersistableModel<IntegrationRuntimeSsisCatalogInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisCatalogInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeSsisCatalogInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeSsisCatalogInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeSsisCatalogInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
