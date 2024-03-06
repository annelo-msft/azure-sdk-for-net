// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryNetworkMappingProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryNetworkMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryNetworkMappingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryNetworkMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryNetworkMappingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(PrimaryNetworkFriendlyName))
            {
                writer.WritePropertyName("primaryNetworkFriendlyName"u8);
                writer.WriteStringValue(PrimaryNetworkFriendlyName);
            }
            if (Optional.IsDefined(PrimaryNetworkId))
            {
                writer.WritePropertyName("primaryNetworkId"u8);
                writer.WriteStringValue(PrimaryNetworkId);
            }
            if (Optional.IsDefined(PrimaryFabricFriendlyName))
            {
                writer.WritePropertyName("primaryFabricFriendlyName"u8);
                writer.WriteStringValue(PrimaryFabricFriendlyName);
            }
            if (Optional.IsDefined(RecoveryNetworkFriendlyName))
            {
                writer.WritePropertyName("recoveryNetworkFriendlyName"u8);
                writer.WriteStringValue(RecoveryNetworkFriendlyName);
            }
            if (Optional.IsDefined(RecoveryNetworkId))
            {
                writer.WritePropertyName("recoveryNetworkId"u8);
                writer.WriteStringValue(RecoveryNetworkId);
            }
            if (Optional.IsDefined(RecoveryFabricArmId))
            {
                writer.WritePropertyName("recoveryFabricArmId"u8);
                writer.WriteStringValue(RecoveryFabricArmId);
            }
            if (Optional.IsDefined(RecoveryFabricFriendlyName))
            {
                writer.WritePropertyName("recoveryFabricFriendlyName"u8);
                writer.WriteStringValue(RecoveryFabricFriendlyName);
            }
            if (Optional.IsDefined(FabricSpecificSettings))
            {
                writer.WritePropertyName("fabricSpecificSettings"u8);
                writer.WriteObjectValue(FabricSpecificSettings);
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

        SiteRecoveryNetworkMappingProperties IJsonModel<SiteRecoveryNetworkMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryNetworkMappingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryNetworkMappingProperties(document.RootElement, options);
        }

        internal static SiteRecoveryNetworkMappingProperties DeserializeSiteRecoveryNetworkMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string state = default;
            string primaryNetworkFriendlyName = default;
            ResourceIdentifier primaryNetworkId = default;
            string primaryFabricFriendlyName = default;
            string recoveryNetworkFriendlyName = default;
            ResourceIdentifier recoveryNetworkId = default;
            ResourceIdentifier recoveryFabricArmId = default;
            string recoveryFabricFriendlyName = default;
            NetworkMappingFabricSpecificSettings fabricSpecificSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkFriendlyName"u8))
                {
                    primaryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkFriendlyName"u8))
                {
                    recoveryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificSettings = NetworkMappingFabricSpecificSettings.DeserializeNetworkMappingFabricSpecificSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryNetworkMappingProperties(
                state,
                primaryNetworkFriendlyName,
                primaryNetworkId,
                primaryFabricFriendlyName,
                recoveryNetworkFriendlyName,
                recoveryNetworkId,
                recoveryFabricArmId,
                recoveryFabricFriendlyName,
                fabricSpecificSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryNetworkMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryNetworkMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryNetworkMappingProperties IPersistableModel<SiteRecoveryNetworkMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryNetworkMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryNetworkMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryNetworkMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
