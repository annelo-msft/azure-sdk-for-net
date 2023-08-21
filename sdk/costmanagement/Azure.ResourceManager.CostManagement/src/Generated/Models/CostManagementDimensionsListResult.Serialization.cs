// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    internal partial class CostManagementDimensionsListResult
    {
        internal static CostManagementDimensionsListResult DeserializeCostManagementDimensionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<CostManagementDimension>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CostManagementDimension> array = new List<CostManagementDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CostManagementDimension.DeserializeCostManagementDimension(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CostManagementDimensionsListResult(Core.Optional.ToList(value));
        }
    }
}
