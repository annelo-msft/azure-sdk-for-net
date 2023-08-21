// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class KustoPoolListResult
    {
        internal static KustoPoolListResult DeserializeKustoPoolListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<SynapseKustoPoolData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseKustoPoolData> array = new List<SynapseKustoPoolData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseKustoPoolData.DeserializeSynapseKustoPoolData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KustoPoolListResult(Core.Optional.ToList(value));
        }
    }
}
