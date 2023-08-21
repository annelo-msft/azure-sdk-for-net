// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsFirewallRulePatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StartIPAddress))
            {
                writer.WritePropertyName("startIpAddress"u8);
                writer.WriteStringValue(StartIPAddress.ToString());
            }
            if (Core.Optional.IsDefined(EndIPAddress))
            {
                writer.WritePropertyName("endIpAddress"u8);
                writer.WriteStringValue(EndIPAddress.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
