// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseSqlPoolBlobAuditingPolicyData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Core.Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Core.Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Core.Optional.IsCollectionDefined(AuditActionsAndGroups))
            {
                writer.WritePropertyName("auditActionsAndGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AuditActionsAndGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(StorageAccountSubscriptionId))
            {
                writer.WritePropertyName("storageAccountSubscriptionId"u8);
                writer.WriteStringValue(StorageAccountSubscriptionId.Value);
            }
            if (Core.Optional.IsDefined(IsStorageSecondaryKeyInUse))
            {
                writer.WritePropertyName("isStorageSecondaryKeyInUse"u8);
                writer.WriteBooleanValue(IsStorageSecondaryKeyInUse.Value);
            }
            if (Core.Optional.IsDefined(IsAzureMonitorTargetEnabled))
            {
                writer.WritePropertyName("isAzureMonitorTargetEnabled"u8);
                writer.WriteBooleanValue(IsAzureMonitorTargetEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseSqlPoolBlobAuditingPolicyData DeserializeSynapseSqlPoolBlobAuditingPolicyData(JsonElement element)
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
            Core.Optional<SynapseBlobAuditingPolicyState> state = default;
            Core.Optional<string> storageEndpoint = default;
            Core.Optional<string> storageAccountAccessKey = default;
            Core.Optional<int> retentionDays = default;
            Core.Optional<IList<string>> auditActionsAndGroups = default;
            Core.Optional<Guid> storageAccountSubscriptionId = default;
            Core.Optional<bool> isStorageSecondaryKeyInUse = default;
            Core.Optional<bool> isAzureMonitorTargetEnabled = default;
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSynapseBlobAuditingPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("auditActionsAndGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            auditActionsAndGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSubscriptionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isStorageSecondaryKeyInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isStorageSecondaryKeyInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAzureMonitorTargetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureMonitorTargetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseSqlPoolBlobAuditingPolicyData(id, name, type, systemData.Value, kind.Value, Core.Optional.ToNullable(state), storageEndpoint.Value, storageAccountAccessKey.Value, Core.Optional.ToNullable(retentionDays), Core.Optional.ToList(auditActionsAndGroups), Core.Optional.ToNullable(storageAccountSubscriptionId), Core.Optional.ToNullable(isStorageSecondaryKeyInUse), Core.Optional.ToNullable(isAzureMonitorTargetEnabled));
        }
    }
}
