// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class RepositoryWriteableProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeleteEnabled))
            {
                writer.WritePropertyName("deleteEnabled");
                writer.WriteBooleanValue(DeleteEnabled.Value);
            }
            if (Optional.IsDefined(WriteEnabled))
            {
                writer.WritePropertyName("writeEnabled");
                writer.WriteBooleanValue(WriteEnabled.Value);
            }
            if (Optional.IsDefined(ListEnabled))
            {
                writer.WritePropertyName("listEnabled");
                writer.WriteBooleanValue(ListEnabled.Value);
            }
            if (Optional.IsDefined(ReadEnabled))
            {
                writer.WritePropertyName("readEnabled");
                writer.WriteBooleanValue(ReadEnabled.Value);
            }
            if (Optional.IsDefined(TeleportEnabled))
            {
                writer.WritePropertyName("teleportEnabled");
                writer.WriteBooleanValue(TeleportEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static RepositoryWriteableProperties DeserializeRepositoryWriteableProperties(JsonElement element)
        {
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            Optional<bool> teleportEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deleteEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("writeEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("listEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    listEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("teleportEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    teleportEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RepositoryWriteableProperties(Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled), Optional.ToNullable(teleportEnabled));
        }
    }
}
