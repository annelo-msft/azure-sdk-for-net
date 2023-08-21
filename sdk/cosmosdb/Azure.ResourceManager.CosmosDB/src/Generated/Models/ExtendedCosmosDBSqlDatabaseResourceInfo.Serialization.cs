// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlDatabaseResourceInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Colls))
            {
                writer.WritePropertyName("_colls"u8);
                writer.WriteStringValue(Colls);
            }
            if (Core.Optional.IsDefined(Users))
            {
                writer.WritePropertyName("_users"u8);
                writer.WriteStringValue(Users);
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(DatabaseName);
            if (Core.Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (Core.Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExtendedCosmosDBSqlDatabaseResourceInfo DeserializeExtendedCosmosDBSqlDatabaseResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> colls = default;
            Core.Optional<string> users = default;
            Core.Optional<string> rid = default;
            Core.Optional<float> ts = default;
            Core.Optional<ETag> etag = default;
            string id = default;
            Core.Optional<ResourceRestoreParameters> restoreParameters = default;
            Core.Optional<CosmosDBAccountCreateMode> createMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_colls"u8))
                {
                    colls = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_users"u8))
                {
                    users = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
            }
            return new ExtendedCosmosDBSqlDatabaseResourceInfo(id, restoreParameters.Value, Core.Optional.ToNullable(createMode), colls.Value, users.Value, rid.Value, Core.Optional.ToNullable(ts), Core.Optional.ToNullable(etag));
        }
    }
}
