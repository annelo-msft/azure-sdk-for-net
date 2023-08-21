// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeOrderData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ContactInformation))
            {
                writer.WritePropertyName("contactInformation"u8);
                writer.WriteObjectValue(ContactInformation);
            }
            if (Core.Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (Core.Optional.IsDefined(ShipmentType))
            {
                writer.WritePropertyName("shipmentType"u8);
                writer.WriteStringValue(ShipmentType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeOrderData DeserializeDataBoxEdgeOrderData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> orderId = default;
            Core.Optional<DataBoxEdgeContactDetails> contactInformation = default;
            Core.Optional<DataBoxEdgeShippingAddress> shippingAddress = default;
            Core.Optional<DataBoxEdgeOrderStatus> currentStatus = default;
            Core.Optional<IReadOnlyList<DataBoxEdgeOrderStatus>> orderHistory = default;
            Core.Optional<string> serialNumber = default;
            Core.Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> deliveryTrackingInfo = default;
            Core.Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> returnTrackingInfo = default;
            Core.Optional<DataBoxEdgeShipmentType> shipmentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("orderId"u8))
                        {
                            orderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contactInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactInformation = DataBoxEdgeContactDetails.DeserializeDataBoxEdgeContactDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shippingAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shippingAddress = DataBoxEdgeShippingAddress.DeserializeDataBoxEdgeShippingAddress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentStatus = DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("orderHistory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeOrderStatus> array = new List<DataBoxEdgeOrderStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(item));
                            }
                            orderHistory = array;
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item));
                            }
                            deliveryTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("returnTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item));
                            }
                            returnTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("shipmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shipmentType = new DataBoxEdgeShipmentType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxEdgeOrderData(id, name, type, systemData.Value, kind.Value, orderId.Value, contactInformation.Value, shippingAddress.Value, currentStatus.Value, Core.Optional.ToList(orderHistory), serialNumber.Value, Core.Optional.ToList(deliveryTrackingInfo), Core.Optional.ToList(returnTrackingInfo), Core.Optional.ToNullable(shipmentType));
        }
    }
}
