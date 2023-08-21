// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeNetworkAdapter
    {
        internal static DataBoxEdgeNetworkAdapter DeserializeDataBoxEdgeNetworkAdapter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> adapterId = default;
            Core.Optional<DataBoxEdgeNetworkAdapterPosition> adapterPosition = default;
            Core.Optional<int> index = default;
            Core.Optional<Guid> nodeId = default;
            Core.Optional<string> networkAdapterName = default;
            Core.Optional<string> label = default;
            Core.Optional<string> macAddress = default;
            Core.Optional<long> linkSpeed = default;
            Core.Optional<DataBoxEdgeNetworkAdapterStatus> status = default;
            Core.Optional<DataBoxEdgeNetworkAdapterRdmaStatus> rdmaStatus = default;
            Core.Optional<DataBoxEdgeNetworkAdapterDhcpStatus> dhcpStatus = default;
            Core.Optional<DataBoxEdgeIPv4Config> ipv4Configuration = default;
            Core.Optional<DataBoxEdgeIPv6Config> ipv6Configuration = default;
            Core.Optional<string> ipv6LinkLocalAddress = default;
            Core.Optional<IReadOnlyList<string>> dnsServers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adapterId"u8))
                {
                    adapterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adapterPosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adapterPosition = DataBoxEdgeNetworkAdapterPosition.DeserializeDataBoxEdgeNetworkAdapterPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("networkAdapterName"u8))
                {
                    networkAdapterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataBoxEdgeNetworkAdapterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdmaStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdmaStatus = new DataBoxEdgeNetworkAdapterRdmaStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dhcpStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dhcpStatus = new DataBoxEdgeNetworkAdapterDhcpStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv4Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4Configuration = DataBoxEdgeIPv4Config.DeserializeDataBoxEdgeIPv4Config(property.Value);
                    continue;
                }
                if (property.NameEquals("ipv6Configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6Configuration = DataBoxEdgeIPv6Config.DeserializeDataBoxEdgeIPv6Config(property.Value);
                    continue;
                }
                if (property.NameEquals("ipv6LinkLocalAddress"u8))
                {
                    ipv6LinkLocalAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
            }
            return new DataBoxEdgeNetworkAdapter(adapterId.Value, adapterPosition.Value, Core.Optional.ToNullable(index), Core.Optional.ToNullable(nodeId), networkAdapterName.Value, label.Value, macAddress.Value, Core.Optional.ToNullable(linkSpeed), Core.Optional.ToNullable(status), Core.Optional.ToNullable(rdmaStatus), Core.Optional.ToNullable(dhcpStatus), ipv4Configuration.Value, ipv6Configuration.Value, ipv6LinkLocalAddress.Value, Core.Optional.ToList(dnsServers));
        }
    }
}
