// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringCachePerformance
    {
        internal static CloudTieringCachePerformance DeserializeCloudTieringCachePerformance(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Core.Optional<long> cacheHitBytes = default;
            Core.Optional<long> cacheMissBytes = default;
            Core.Optional<int> cacheHitBytesPercent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cacheHitBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheMissBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheMissBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheHitBytesPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytesPercent = property.Value.GetInt32();
                    continue;
                }
            }
            return new CloudTieringCachePerformance(Core.Optional.ToNullable(lastUpdatedTimestamp), Core.Optional.ToNullable(cacheHitBytes), Core.Optional.ToNullable(cacheMissBytes), Core.Optional.ToNullable(cacheHitBytesPercent));
        }
    }
}
