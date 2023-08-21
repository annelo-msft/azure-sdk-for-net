// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlUpsertSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(UseTempDB))
            {
                writer.WritePropertyName("useTempDB"u8);
                JsonSerializer.Serialize(writer, UseTempDB);
            }
            if (Core.Optional.IsDefined(InterimSchemaName))
            {
                writer.WritePropertyName("interimSchemaName"u8);
                JsonSerializer.Serialize(writer, InterimSchemaName);
            }
            if (Core.Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                JsonSerializer.Serialize(writer, Keys);
            }
            writer.WriteEndObject();
        }

        internal static SqlUpsertSettings DeserializeSqlUpsertSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DataFactoryElement<bool>> useTempDB = default;
            Core.Optional<DataFactoryElement<string>> interimSchemaName = default;
            Core.Optional<DataFactoryElement<IList<string>>> keys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("useTempDB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTempDB = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("interimSchemaName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interimSchemaName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keys = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property.Value.GetRawText());
                    continue;
                }
            }
            return new SqlUpsertSettings(useTempDB.Value, interimSchemaName.Value, keys.Value);
        }
    }
}
