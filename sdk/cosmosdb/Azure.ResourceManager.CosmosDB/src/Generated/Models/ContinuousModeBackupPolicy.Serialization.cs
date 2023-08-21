// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ContinuousModeBackupPolicy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ContinuousModeProperties))
            {
                writer.WritePropertyName("continuousModeProperties"u8);
                writer.WriteObjectValue(ContinuousModeProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Core.Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteObjectValue(MigrationState);
            }
            writer.WriteEndObject();
        }

        internal static ContinuousModeBackupPolicy DeserializeContinuousModeBackupPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ContinuousModeProperties> continuousModeProperties = default;
            BackupPolicyType type = default;
            Core.Optional<BackupPolicyMigrationState> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuousModeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuousModeProperties = ContinuousModeProperties.DeserializeContinuousModeProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value);
                    continue;
                }
            }
            return new ContinuousModeBackupPolicy(type, migrationState.Value, continuousModeProperties.Value);
        }
    }
}
