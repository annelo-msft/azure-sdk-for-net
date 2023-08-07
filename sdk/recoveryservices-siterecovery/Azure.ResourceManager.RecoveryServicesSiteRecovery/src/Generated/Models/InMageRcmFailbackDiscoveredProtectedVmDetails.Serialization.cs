// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackDiscoveredProtectedVmDetails
    {
        internal static InMageRcmFailbackDiscoveredProtectedVmDetails DeserializeInMageRcmFailbackDiscoveredProtectedVmDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vCenterId = default;
            Optional<string> vCenterFqdn = default;
            Optional<IReadOnlyList<string>> datastores = default;
            Optional<IReadOnlyList<IPAddress>> ipAddresses = default;
            Optional<string> vmwareToolsStatus = default;
            Optional<string> powerStatus = default;
            Optional<string> vmFqdn = default;
            Optional<string> osName = default;
            Optional<DateTimeOffset> createdTimestamp = default;
            Optional<DateTimeOffset> updatedTimestamp = default;
            Optional<bool> isDeleted = default;
            Optional<DateTimeOffset> lastDiscoveryTimeInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCenterId"u8))
                {
                    vCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterFqdn"u8))
                {
                    vCenterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastores"u8))
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
                    datastores = array;
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("vmwareToolsStatus"u8))
                {
                    vmwareToolsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerStatus"u8))
                {
                    powerStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmFqdn"u8))
                {
                    vmFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isDeleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastDiscoveryTimeInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDiscoveryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new InMageRcmFailbackDiscoveredProtectedVmDetails(vCenterId.Value, vCenterFqdn.Value, Optional.ToList(datastores), Optional.ToList(ipAddresses), vmwareToolsStatus.Value, powerStatus.Value, vmFqdn.Value, osName.Value, Optional.ToNullable(createdTimestamp), Optional.ToNullable(updatedTimestamp), Optional.ToNullable(isDeleted), Optional.ToNullable(lastDiscoveryTimeInUtc));
        }
    }
}
