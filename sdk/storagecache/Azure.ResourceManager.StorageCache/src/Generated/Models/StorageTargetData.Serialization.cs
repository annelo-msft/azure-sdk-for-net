// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    public partial class StorageTargetData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Junctions))
            {
                writer.WritePropertyName("junctions"u8);
                writer.WriteStartArray();
                foreach (var item in Junctions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(TargetType))
            {
                writer.WritePropertyName("targetType"u8);
                writer.WriteStringValue(TargetType.Value.ToString());
            }
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Core.Optional.IsDefined(Nfs3))
            {
                writer.WritePropertyName("nfs3"u8);
                writer.WriteObjectValue(Nfs3);
            }
            if (Core.Optional.IsDefined(Clfs))
            {
                writer.WritePropertyName("clfs"u8);
                writer.WriteObjectValue(Clfs);
            }
            if (Core.Optional.IsDefined(Unknown))
            {
                writer.WritePropertyName("unknown"u8);
                writer.WriteObjectValue(Unknown);
            }
            if (Core.Optional.IsDefined(BlobNfs))
            {
                writer.WritePropertyName("blobNfs"u8);
                writer.WriteObjectValue(BlobNfs);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageTargetData DeserializeStorageTargetData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<IList<NamespaceJunction>> junctions = default;
            Core.Optional<StorageTargetType> targetType = default;
            Core.Optional<StorageCacheProvisioningStateType> provisioningState = default;
            Core.Optional<StorageTargetOperationalStateType> state = default;
            Core.Optional<Nfs3Target> nfs3 = default;
            Core.Optional<ClfsTarget> clfs = default;
            Core.Optional<UnknownTarget> unknown = default;
            Core.Optional<BlobNfsTarget> blobNfs = default;
            Core.Optional<int> allocationPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("junctions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NamespaceJunction> array = new List<NamespaceJunction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NamespaceJunction.DeserializeNamespaceJunction(item));
                            }
                            junctions = array;
                            continue;
                        }
                        if (property0.NameEquals("targetType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetType = new StorageTargetType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageCacheProvisioningStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new StorageTargetOperationalStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nfs3"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nfs3 = Nfs3Target.DeserializeNfs3Target(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clfs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clfs = Models.ClfsTarget.DeserializeClfsTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("unknown"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unknown = UnknownTarget.DeserializeUnknownTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("blobNfs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobNfs = BlobNfsTarget.DeserializeBlobNfsTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allocationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationPercentage = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageTargetData(id, name, type, systemData.Value, Core.Optional.ToList(junctions), Core.Optional.ToNullable(targetType), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(state), nfs3.Value, clfs.Value, unknown.Value, blobNfs.Value, Core.Optional.ToNullable(allocationPercentage), Core.Optional.ToNullable(location));
        }
    }
}
