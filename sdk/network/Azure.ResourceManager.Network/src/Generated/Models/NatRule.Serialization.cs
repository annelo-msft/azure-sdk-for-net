// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NatRule : IUtf8JsonSerializable, IJsonModel<NatRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NatRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NatRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NatRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NatRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPProtocols))
            {
                writer.WritePropertyName("ipProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in IPProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationAddresses))
            {
                writer.WritePropertyName("destinationAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPorts))
            {
                writer.WritePropertyName("destinationPorts"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TranslatedAddress))
            {
                writer.WritePropertyName("translatedAddress"u8);
                writer.WriteStringValue(TranslatedAddress);
            }
            if (Optional.IsDefined(TranslatedPort))
            {
                writer.WritePropertyName("translatedPort"u8);
                writer.WriteStringValue(TranslatedPort);
            }
            if (Optional.IsCollectionDefined(SourceIPGroups))
            {
                writer.WritePropertyName("sourceIpGroups"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TranslatedFqdn))
            {
                writer.WritePropertyName("translatedFqdn"u8);
                writer.WriteStringValue(TranslatedFqdn);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
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

        NatRule IJsonModel<NatRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NatRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NatRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNatRule(document.RootElement, options);
        }

        internal static NatRule DeserializeNatRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FirewallPolicyRuleNetworkProtocol> ipProtocols = default;
            IList<string> sourceAddresses = default;
            IList<string> destinationAddresses = default;
            IList<string> destinationPorts = default;
            string translatedAddress = default;
            string translatedPort = default;
            IList<string> sourceIPGroups = default;
            string translatedFqdn = default;
            string name = default;
            string description = default;
            FirewallPolicyRuleType ruleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyRuleNetworkProtocol> array = new List<FirewallPolicyRuleNetworkProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new FirewallPolicyRuleNetworkProtocol(item.GetString()));
                    }
                    ipProtocols = array;
                    continue;
                }
                if (property.NameEquals("sourceAddresses"u8))
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
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"u8))
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
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"u8))
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
                    destinationPorts = array;
                    continue;
                }
                if (property.NameEquals("translatedAddress"u8))
                {
                    translatedAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translatedPort"u8))
                {
                    translatedPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"u8))
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
                    sourceIPGroups = array;
                    continue;
                }
                if (property.NameEquals("translatedFqdn"u8))
                {
                    translatedFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NatRule(
                name,
                description,
                ruleType,
                serializedAdditionalRawData,
                ipProtocols ?? new ChangeTrackingList<FirewallPolicyRuleNetworkProtocol>(),
                sourceAddresses ?? new ChangeTrackingList<string>(),
                destinationAddresses ?? new ChangeTrackingList<string>(),
                destinationPorts ?? new ChangeTrackingList<string>(),
                translatedAddress,
                translatedPort,
                sourceIPGroups ?? new ChangeTrackingList<string>(),
                translatedFqdn);
        }

        BinaryData IPersistableModel<NatRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NatRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NatRule)} does not support '{options.Format}' format.");
            }
        }

        NatRule IPersistableModel<NatRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NatRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNatRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NatRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NatRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
