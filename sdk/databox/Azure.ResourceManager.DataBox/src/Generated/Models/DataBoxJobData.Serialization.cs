// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBox
{
    public partial class DataBoxJobData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            if (Core.Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details);
            }
            if (Core.Optional.IsDefined(DeliveryType))
            {
                writer.WritePropertyName("deliveryType"u8);
                writer.WriteStringValue(DeliveryType.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(DeliveryInfo))
            {
                writer.WritePropertyName("deliveryInfo"u8);
                writer.WriteObjectValue(DeliveryInfo);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataBoxJobData DeserializeDataBoxJobData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxSku sku = default;
            Core.Optional<ManagedServiceIdentity> identity = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            DataBoxJobTransferType transferType = default;
            Core.Optional<bool> isCancellable = default;
            Core.Optional<bool> isDeletable = default;
            Core.Optional<bool> isShippingAddressEditable = default;
            Core.Optional<ReverseShippingDetailsEditStatus> reverseShippingDetailsUpdate = default;
            Core.Optional<ReverseTransportPreferenceEditStatus> reverseTransportPreferenceUpdate = default;
            Core.Optional<bool> isPrepareToShipEnabled = default;
            Core.Optional<DataBoxStageName> status = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<ResponseError> error = default;
            Core.Optional<DataBoxBasicJobDetails> details = default;
            Core.Optional<string> cancellationReason = default;
            Core.Optional<JobDeliveryType> deliveryType = default;
            Core.Optional<JobDeliveryInfo> deliveryInfo = default;
            Core.Optional<bool> isCancellableWithoutFee = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DataBoxSku.DeserializeDataBoxSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("transferType"u8))
                        {
                            transferType = property0.Value.GetString().ToDataBoxJobTransferType();
                            continue;
                        }
                        if (property0.NameEquals("isCancellable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isDeletable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeletable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isShippingAddressEditable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isShippingAddressEditable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reverseShippingDetailsUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseShippingDetailsUpdate = property0.Value.GetString().ToReverseShippingDetailsEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("reverseTransportPreferenceUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseTransportPreferenceUpdate = property0.Value.GetString().ToReverseTransportPreferenceEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("isPrepareToShipEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrepareToShipEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DataBoxStageName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            details = DataBoxBasicJobDetails.DeserializeDataBoxBasicJobDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cancellationReason"u8))
                        {
                            cancellationReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryType = property0.Value.GetString().ToJobDeliveryType();
                            continue;
                        }
                        if (property0.NameEquals("deliveryInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryInfo = JobDeliveryInfo.DeserializeJobDeliveryInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isCancellableWithoutFee"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellableWithoutFee = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxJobData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, transferType, Core.Optional.ToNullable(isCancellable), Core.Optional.ToNullable(isDeletable), Core.Optional.ToNullable(isShippingAddressEditable), Core.Optional.ToNullable(reverseShippingDetailsUpdate), Core.Optional.ToNullable(reverseTransportPreferenceUpdate), Core.Optional.ToNullable(isPrepareToShipEnabled), Core.Optional.ToNullable(status), Core.Optional.ToNullable(startTime), error.Value, details.Value, cancellationReason.Value, Core.Optional.ToNullable(deliveryType), deliveryInfo.Value, Core.Optional.ToNullable(isCancellableWithoutFee), sku, identity);
        }
    }
}
