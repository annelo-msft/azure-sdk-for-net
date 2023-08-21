// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Core.Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration"u8);
                writer.WriteObjectValue(Registration);
            }
            if (Core.Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login);
            }
            if (Core.Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation"u8);
                writer.WriteObjectValue(Validation);
            }
            if (Core.Optional.IsDefined(IsAutoProvisioned))
            {
                writer.WritePropertyName("isAutoProvisioned"u8);
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppAzureActiveDirectoryConfiguration DeserializeContainerAppAzureActiveDirectoryConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> enabled = default;
            Core.Optional<ContainerAppAzureActiveDirectoryRegistrationConfiguration> registration = default;
            Core.Optional<ContainerAppAzureActiveDirectoryLoginConfiguration> login = default;
            Core.Optional<ContainerAppAzureActiveDirectoryValidationConfiguration> validation = default;
            Core.Optional<bool> isAutoProvisioned = default;
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
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registration = ContainerAppAzureActiveDirectoryRegistrationConfiguration.DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    login = ContainerAppAzureActiveDirectoryLoginConfiguration.DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("validation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validation = ContainerAppAzureActiveDirectoryValidationConfiguration.DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContainerAppAzureActiveDirectoryConfiguration(Core.Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value, Core.Optional.ToNullable(isAutoProvisioned));
        }
    }
}
