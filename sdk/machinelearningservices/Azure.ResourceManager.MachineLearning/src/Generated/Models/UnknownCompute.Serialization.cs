// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownCompute : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
            if (Optional.IsDefined(ComputeLocation))
            {
                writer.WritePropertyName("computeLocation"u8);
                writer.WriteStringValue(ComputeLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedOn"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProvisioningErrors))
            {
                if (ProvisioningErrors != null)
                {
                    writer.WritePropertyName("provisioningErrors"u8);
                    writer.WriteStartArray();
                    foreach (var item in ProvisioningErrors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("provisioningErrors");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(IsAttachedCompute))
            {
                writer.WritePropertyName("isAttachedCompute"u8);
                writer.WriteBooleanValue(IsAttachedCompute.Value);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
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

        MachineLearningComputeProperties IJsonModel<MachineLearningComputeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeProperties(document.RootElement, options);
        }

        internal static UnknownCompute DeserializeUnknownCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeType computeType = "Unknown";
            string computeLocation = default;
            MachineLearningProvisioningState? provisioningState = default;
            string description = default;
            DateTimeOffset? createdOn = default;
            DateTimeOffset? modifiedOn = default;
            ResourceIdentifier resourceId = default;
            IReadOnlyList<MachineLearningError> provisioningErrors = default;
            bool? isAttachedCompute = default;
            bool? disableLocalAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeLocation"u8))
                {
                    computeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningErrors = null;
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item, options));
                    }
                    provisioningErrors = array;
                    continue;
                }
                if (property.NameEquals("isAttachedCompute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAttachedCompute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownCompute(
                computeType,
                computeLocation,
                provisioningState,
                description,
                createdOn,
                modifiedOn,
                resourceId,
                provisioningErrors ?? new ChangeTrackingList<MachineLearningError>(),
                isAttachedCompute,
                disableLocalAuth,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningComputeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeProperties IPersistableModel<MachineLearningComputeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
