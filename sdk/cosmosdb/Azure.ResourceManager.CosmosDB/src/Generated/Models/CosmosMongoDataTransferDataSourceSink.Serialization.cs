// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosMongoDataTransferDataSourceSink : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("collectionName"u8);
            writer.WriteStringValue(CollectionName);
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
            writer.WriteEndObject();
        }

        internal static CosmosMongoDataTransferDataSourceSink DeserializeCosmosMongoDataTransferDataSourceSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string collectionName = default;
            DataTransferComponent component = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionName"u8))
                {
                    collectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
            }
            return new CosmosMongoDataTransferDataSourceSink(component, databaseName, collectionName);
        }
    }
}
