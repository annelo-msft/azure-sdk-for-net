// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlTriggerResourceInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(TriggerName);
            if (Core.Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            if (Core.Optional.IsDefined(TriggerType))
            {
                writer.WritePropertyName("triggerType"u8);
                writer.WriteStringValue(TriggerType.Value.ToString());
            }
            if (Core.Optional.IsDefined(TriggerOperation))
            {
                writer.WritePropertyName("triggerOperation"u8);
                writer.WriteStringValue(TriggerOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExtendedCosmosDBSqlTriggerResourceInfo DeserializeExtendedCosmosDBSqlTriggerResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> rid = default;
            Core.Optional<float> ts = default;
            Core.Optional<ETag> etag = default;
            string id = default;
            Core.Optional<string> body = default;
            Core.Optional<CosmosDBSqlTriggerType> triggerType = default;
            Core.Optional<CosmosDBSqlTriggerOperation> triggerOperation = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("body"u8))
                {
                    body = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerType = new CosmosDBSqlTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerOperation = new CosmosDBSqlTriggerOperation(property.Value.GetString());
                    continue;
                }
            }
            return new ExtendedCosmosDBSqlTriggerResourceInfo(id, body.Value, Core.Optional.ToNullable(triggerType), Core.Optional.ToNullable(triggerOperation), rid.Value, Core.Optional.ToNullable(ts), Core.Optional.ToNullable(etag));
        }
    }
}
