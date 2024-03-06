// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterConnectivityProfile : IUtf8JsonSerializable, IJsonModel<ClusterConnectivityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterConnectivityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterConnectivityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterConnectivityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterConnectivityProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("web"u8);
                writer.WriteObjectValue(Web);
            }
            if (Optional.IsCollectionDefined(Ssh))
            {
                writer.WritePropertyName("ssh"u8);
                writer.WriteStartArray();
                foreach (var item in Ssh)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ClusterConnectivityProfile IJsonModel<ClusterConnectivityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterConnectivityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterConnectivityProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterConnectivityProfile(document.RootElement, options);
        }

        internal static ClusterConnectivityProfile DeserializeClusterConnectivityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebConnectivityEndpoint web = default;
            IReadOnlyList<SshConnectivityEndpoint> ssh = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("web"u8))
                {
                    web = WebConnectivityEndpoint.DeserializeWebConnectivityEndpoint(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ssh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SshConnectivityEndpoint> array = new List<SshConnectivityEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SshConnectivityEndpoint.DeserializeSshConnectivityEndpoint(item, options));
                    }
                    ssh = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterConnectivityProfile(web, ssh ?? new ChangeTrackingList<SshConnectivityEndpoint>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterConnectivityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterConnectivityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterConnectivityProfile)} does not support '{options.Format}' format.");
            }
        }

        ClusterConnectivityProfile IPersistableModel<ClusterConnectivityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterConnectivityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterConnectivityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterConnectivityProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterConnectivityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
