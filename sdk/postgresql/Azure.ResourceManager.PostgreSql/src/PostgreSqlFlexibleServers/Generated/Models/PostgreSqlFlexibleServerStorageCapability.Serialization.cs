// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerStorageCapability
    {
        internal static PostgreSqlFlexibleServerStorageCapability DeserializePostgreSqlFlexibleServerStorageCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> supportedIops = default;
            Optional<long> storageSizeMb = default;
            Optional<string> defaultIopsTier = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerStorageTierCapability>> supportedIopsTiers = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSizeMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultIopsTier"u8))
                {
                    defaultIopsTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedIopsTiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageTierCapability> array = new List<PostgreSqlFlexibleServerStorageTierCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageTierCapability.DeserializePostgreSqlFlexibleServerStorageTierCapability(item));
                    }
                    supportedIopsTiers = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerStorageCapability(Optional.ToNullable(status), reason.Value, Optional.ToNullable(supportedIops), Optional.ToNullable(storageSizeMb), defaultIopsTier.Value, Optional.ToList(supportedIopsTiers));
        }
    }
}
