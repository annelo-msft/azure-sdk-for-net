// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    internal partial class ContainerCapabilitiesListResult
    {
        internal static ContainerCapabilitiesListResult DeserializeContainerCapabilitiesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ContainerCapabilities>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerCapabilities> array = new List<ContainerCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerCapabilities.DeserializeContainerCapabilities(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerCapabilitiesListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
