// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBRole : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("db"u8);
                writer.WriteStringValue(DBName);
            }
            if (Core.Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role);
            }
            writer.WriteEndObject();
        }

        internal static MongoDBRole DeserializeMongoDBRole(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> db = default;
            Core.Optional<string> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("db"u8))
                {
                    db = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBRole(db.Value, role.Value);
        }
    }
}
