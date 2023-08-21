// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeTrackingInfo
    {
        internal static DataBoxEdgeTrackingInfo DeserializeDataBoxEdgeTrackingInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> serialNumber = default;
            Core.Optional<string> carrierName = default;
            Core.Optional<string> trackingId = default;
            Core.Optional<Uri> trackingUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DataBoxEdgeTrackingInfo(serialNumber.Value, carrierName.Value, trackingId.Value, trackingUrl.Value);
        }
    }
}
