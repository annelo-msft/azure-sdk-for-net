// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppEnvironmentVariable : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Core.Optional.IsDefined(SecretRef))
            {
                writer.WritePropertyName("secretRef"u8);
                writer.WriteStringValue(SecretRef);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppEnvironmentVariable DeserializeContainerAppEnvironmentVariable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> value = default;
            Core.Optional<string> secretRef = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretRef"u8))
                {
                    secretRef = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppEnvironmentVariable(name.Value, value.Value, secretRef.Value);
        }
    }
}
