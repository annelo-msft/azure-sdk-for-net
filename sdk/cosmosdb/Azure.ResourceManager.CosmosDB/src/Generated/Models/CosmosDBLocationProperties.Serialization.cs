// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBLocationProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBLocationProperties DeserializeCosmosDBLocationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> supportsAvailabilityZone = default;
            Core.Optional<bool> isResidencyRestricted = default;
            Core.Optional<IReadOnlyList<CosmosDBBackupStorageRedundancy>> backupStorageRedundancies = default;
            Core.Optional<bool> isSubscriptionRegionAccessAllowedForRegular = default;
            Core.Optional<bool> isSubscriptionRegionAccessAllowedForAz = default;
            Core.Optional<CosmosDBStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportsAvailabilityZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportsAvailabilityZone = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isResidencyRestricted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResidencyRestricted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupStorageRedundancies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBBackupStorageRedundancy> array = new List<CosmosDBBackupStorageRedundancy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CosmosDBBackupStorageRedundancy(item.GetString()));
                    }
                    backupStorageRedundancies = array;
                    continue;
                }
                if (property.NameEquals("isSubscriptionRegionAccessAllowedForRegular"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSubscriptionRegionAccessAllowedForRegular = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSubscriptionRegionAccessAllowedForAz"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSubscriptionRegionAccessAllowedForAz = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBStatus(property.Value.GetString());
                    continue;
                }
            }
            return new CosmosDBLocationProperties(Core.Optional.ToNullable(supportsAvailabilityZone), Core.Optional.ToNullable(isResidencyRestricted), Core.Optional.ToList(backupStorageRedundancies), Core.Optional.ToNullable(isSubscriptionRegionAccessAllowedForRegular), Core.Optional.ToNullable(isSubscriptionRegionAccessAllowedForAz), Core.Optional.ToNullable(status));
        }
    }
}
