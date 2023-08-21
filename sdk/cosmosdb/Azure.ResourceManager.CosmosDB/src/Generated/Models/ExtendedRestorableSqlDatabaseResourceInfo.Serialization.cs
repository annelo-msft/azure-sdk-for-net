// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedRestorableSqlDatabaseResourceInfo
    {
        internal static ExtendedRestorableSqlDatabaseResourceInfo DeserializeExtendedRestorableSqlDatabaseResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> rid = default;
            Core.Optional<CosmosDBOperationType> operationType = default;
            Core.Optional<string> eventTimestamp = default;
            Core.Optional<string> ownerId = default;
            Core.Optional<string> ownerResourceId = default;
            Core.Optional<RestorableSqlDatabasePropertiesResourceDatabase> database = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    database = RestorableSqlDatabasePropertiesResourceDatabase.DeserializeRestorableSqlDatabasePropertiesResourceDatabase(property.Value);
                    continue;
                }
            }
            return new ExtendedRestorableSqlDatabaseResourceInfo(rid.Value, Core.Optional.ToNullable(operationType), eventTimestamp.Value, ownerId.Value, ownerResourceId.Value, database.Value);
        }
    }
}
