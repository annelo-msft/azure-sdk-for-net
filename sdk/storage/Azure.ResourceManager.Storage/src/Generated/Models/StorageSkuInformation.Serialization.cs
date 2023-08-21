// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageSkuInformation
    {
        internal static StorageSkuInformation DeserializeStorageSkuInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageSkuName name = default;
            Core.Optional<StorageSkuTier> tier = default;
            Core.Optional<string> resourceType = default;
            Core.Optional<StorageKind> kind = default;
            Core.Optional<IReadOnlyList<string>> locations = default;
            Core.Optional<IReadOnlyList<StorageSkuCapability>> capabilities = default;
            Core.Optional<IReadOnlyList<StorageSkuRestriction>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new StorageSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = property.Value.GetString().ToStorageSkuTier();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new StorageKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"u8))
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
                    locations = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSkuCapability> array = new List<StorageSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSkuCapability.DeserializeStorageSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSkuRestriction> array = new List<StorageSkuRestriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSkuRestriction.DeserializeStorageSkuRestriction(item));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new StorageSkuInformation(name, Core.Optional.ToNullable(tier), resourceType.Value, Core.Optional.ToNullable(kind), Core.Optional.ToList(locations), Core.Optional.ToList(capabilities), Core.Optional.ToList(restrictions));
        }
    }
}
