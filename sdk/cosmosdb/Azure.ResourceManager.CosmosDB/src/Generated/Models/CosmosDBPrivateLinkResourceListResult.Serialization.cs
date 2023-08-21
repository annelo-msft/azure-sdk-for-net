// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBPrivateLinkResourceListResult
    {
        internal static CosmosDBPrivateLinkResourceListResult DeserializeCosmosDBPrivateLinkResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<CosmosDBPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBPrivateLinkResourceData> array = new List<CosmosDBPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBPrivateLinkResourceData.DeserializeCosmosDBPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBPrivateLinkResourceListResult(Core.Optional.ToList(value));
        }
    }
}
