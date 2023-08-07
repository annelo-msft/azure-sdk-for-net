// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IsolationDomainProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Encapsulation))
            {
                writer.WritePropertyName("encapsulation"u8);
                writer.WriteStringValue(Encapsulation.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NeighborGroupIds))
            {
                writer.WritePropertyName("neighborGroupIds"u8);
                writer.WriteStartArray();
                foreach (var item in NeighborGroupIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IsolationDomainProperties DeserializeIsolationDomainProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IsolationDomainEncapsulationType> encapsulation = default;
            Optional<IList<ResourceIdentifier>> neighborGroupIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encapsulation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encapsulation = new IsolationDomainEncapsulationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("neighborGroupIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    neighborGroupIds = array;
                    continue;
                }
            }
            return new IsolationDomainProperties(Optional.ToNullable(encapsulation), Optional.ToList(neighborGroupIds));
        }
    }
}
