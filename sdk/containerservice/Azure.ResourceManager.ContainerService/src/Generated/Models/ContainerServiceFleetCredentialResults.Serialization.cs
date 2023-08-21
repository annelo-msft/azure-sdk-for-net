// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceFleetCredentialResults
    {
        internal static ContainerServiceFleetCredentialResults DeserializeContainerServiceFleetCredentialResults(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ContainerServiceFleetCredentialResult>> kubeconfigs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubeconfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceFleetCredentialResult> array = new List<ContainerServiceFleetCredentialResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceFleetCredentialResult.DeserializeContainerServiceFleetCredentialResult(item));
                    }
                    kubeconfigs = array;
                    continue;
                }
            }
            return new ContainerServiceFleetCredentialResults(Core.Optional.ToList(kubeconfigs));
        }
    }
}
