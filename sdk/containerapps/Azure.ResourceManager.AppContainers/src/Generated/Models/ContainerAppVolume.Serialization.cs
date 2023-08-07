// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageName))
            {
                writer.WritePropertyName("storageName"u8);
                writer.WriteStringValue(StorageName);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppVolume DeserializeContainerAppVolume(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ContainerAppStorageType> storageType = default;
            Optional<string> storageName = default;
            Optional<IList<SecretVolumeItem>> secrets = default;
            Optional<string> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new ContainerAppStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageName"u8))
                {
                    storageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecretVolumeItem> array = new List<SecretVolumeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecretVolumeItem.DeserializeSecretVolumeItem(item));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppVolume(name.Value, Optional.ToNullable(storageType), storageName.Value, Optional.ToList(secrets), mountOptions.Value);
        }
    }
}
