// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryKeyVaultProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteStringValue(Identity);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryKeyVaultProperties DeserializeContainerRegistryKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> keyIdentifier = default;
            Core.Optional<string> versionedKeyIdentifier = default;
            Core.Optional<string> identity = default;
            Core.Optional<bool> keyRotationEnabled = default;
            Core.Optional<DateTimeOffset> lastKeyRotationTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("versionedKeyIdentifier"u8))
                {
                    versionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyRotationEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyRotationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ContainerRegistryKeyVaultProperties(keyIdentifier.Value, versionedKeyIdentifier.Value, identity.Value, Core.Optional.ToNullable(keyRotationEnabled), Core.Optional.ToNullable(lastKeyRotationTimestamp));
        }
    }
}
