// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ImmutableStorageWithVersioning : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ImmutableStorageWithVersioning DeserializeImmutableStorageWithVersioning(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> enabled = default;
            Core.Optional<DateTimeOffset> timeStamp = default;
            Core.Optional<ImmutableStorageWithVersioningMigrationState> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("timeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = new ImmutableStorageWithVersioningMigrationState(property.Value.GetString());
                    continue;
                }
            }
            return new ImmutableStorageWithVersioning(Core.Optional.ToNullable(enabled), Core.Optional.ToNullable(timeStamp), Core.Optional.ToNullable(migrationState));
        }
    }
}
