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
    internal partial class CassandraDataCenterListResult
    {
        internal static CassandraDataCenterListResult DeserializeCassandraDataCenterListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<CassandraDataCenterData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraDataCenterData> array = new List<CassandraDataCenterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterData.DeserializeCassandraDataCenterData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CassandraDataCenterListResult(Core.Optional.ToList(value));
        }
    }
}
