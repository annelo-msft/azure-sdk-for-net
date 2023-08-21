// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SnapshotRestoreRequest : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SnapshotTime))
            {
                writer.WritePropertyName("snapshotTime"u8);
                writer.WriteStringValue(SnapshotTime);
            }
            if (Core.Optional.IsDefined(RecoverySource))
            {
                writer.WritePropertyName("recoverySource"u8);
                writer.WriteObjectValue(RecoverySource);
            }
            if (Core.Optional.IsDefined(CanOverwrite))
            {
                writer.WritePropertyName("overwrite"u8);
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (Core.Optional.IsDefined(RecoverConfiguration))
            {
                writer.WritePropertyName("recoverConfiguration"u8);
                writer.WriteBooleanValue(RecoverConfiguration.Value);
            }
            if (Core.Optional.IsDefined(IgnoreConflictingHostNames))
            {
                writer.WritePropertyName("ignoreConflictingHostNames"u8);
                writer.WriteBooleanValue(IgnoreConflictingHostNames.Value);
            }
            if (Core.Optional.IsDefined(UseDRSecondary))
            {
                writer.WritePropertyName("useDRSecondary"u8);
                writer.WriteBooleanValue(UseDRSecondary.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SnapshotRestoreRequest DeserializeSnapshotRestoreRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> snapshotTime = default;
            Core.Optional<SnapshotRecoverySource> recoverySource = default;
            Core.Optional<bool> overwrite = default;
            Core.Optional<bool> recoverConfiguration = default;
            Core.Optional<bool> ignoreConflictingHostNames = default;
            Core.Optional<bool> useDRSecondary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("snapshotTime"u8))
                        {
                            snapshotTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverySource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverySource = SnapshotRecoverySource.DeserializeSnapshotRecoverySource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("overwrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("recoverConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverConfiguration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useDRSecondary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useDRSecondary = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SnapshotRestoreRequest(id, name, type, systemData.Value, snapshotTime.Value, recoverySource.Value, Core.Optional.ToNullable(overwrite), Core.Optional.ToNullable(recoverConfiguration), Core.Optional.ToNullable(ignoreConflictingHostNames), Core.Optional.ToNullable(useDRSecondary), kind.Value);
        }
    }
}
