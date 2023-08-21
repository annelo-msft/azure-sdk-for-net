// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPs : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(PublicIPs))
            {
                writer.WritePropertyName("publicIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterLoadBalancerProfileOutboundIPs DeserializeManagedClusterLoadBalancerProfileOutboundIPs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<WritableSubResource>> publicIPs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPs = array;
                    continue;
                }
            }
            return new ManagedClusterLoadBalancerProfileOutboundIPs(Core.Optional.ToList(publicIPs));
        }
    }
}
