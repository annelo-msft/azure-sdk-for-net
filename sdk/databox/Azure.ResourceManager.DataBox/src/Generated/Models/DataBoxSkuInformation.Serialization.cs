// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxSkuInformation
    {
        internal static DataBoxSkuInformation DeserializeDataBoxSkuInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DataBoxSku> sku = default;
            Core.Optional<bool> enabled = default;
            Core.Optional<IReadOnlyList<DataLocationToServiceLocationMap>> dataLocationToServiceLocationMap = default;
            Core.Optional<DataBoxSkuCapacity> capacity = default;
            Core.Optional<IReadOnlyList<DataBoxSkuCost>> costs = default;
            Core.Optional<IReadOnlyList<string>> apiVersions = default;
            Core.Optional<SkuDisabledReason> disabledReason = default;
            Core.Optional<string> disabledReasonMessage = default;
            Core.Optional<string> requiredFeature = default;
            Core.Optional<IReadOnlyList<string>> countriesWithinCommerceBoundary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DataBoxSku.DeserializeDataBoxSku(property.Value);
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataLocationToServiceLocationMap"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLocationToServiceLocationMap> array = new List<DataLocationToServiceLocationMap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.DataLocationToServiceLocationMap.DeserializeDataLocationToServiceLocationMap(item));
                            }
                            dataLocationToServiceLocationMap = array;
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = DataBoxSkuCapacity.DeserializeDataBoxSkuCapacity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("costs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxSkuCost> array = new List<DataBoxSkuCost>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxSkuCost.DeserializeDataBoxSkuCost(item));
                            }
                            costs = array;
                            continue;
                        }
                        if (property0.NameEquals("apiVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            apiVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("disabledReason"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disabledReason = property0.Value.GetString().ToSkuDisabledReason();
                            continue;
                        }
                        if (property0.NameEquals("disabledReasonMessage"u8))
                        {
                            disabledReasonMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredFeature"u8))
                        {
                            requiredFeature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("countriesWithinCommerceBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            countriesWithinCommerceBoundary = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxSkuInformation(sku.Value, Core.Optional.ToNullable(enabled), Core.Optional.ToList(dataLocationToServiceLocationMap), capacity.Value, Core.Optional.ToList(costs), Core.Optional.ToList(apiVersions), Core.Optional.ToNullable(disabledReason), disabledReasonMessage.Value, requiredFeature.Value, Core.Optional.ToList(countriesWithinCommerceBoundary));
        }
    }
}
