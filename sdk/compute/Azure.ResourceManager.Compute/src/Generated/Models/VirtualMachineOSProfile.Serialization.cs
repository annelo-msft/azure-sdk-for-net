// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineOSProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ComputerName))
            {
                writer.WritePropertyName("computerName"u8);
                writer.WriteStringValue(ComputerName);
            }
            if (Core.Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Core.Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Core.Optional.IsDefined(CustomData))
            {
                writer.WritePropertyName("customData"u8);
                writer.WriteStringValue(CustomData);
            }
            if (Core.Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (Core.Optional.IsDefined(LinuxConfiguration))
            {
                writer.WritePropertyName("linuxConfiguration"u8);
                writer.WriteObjectValue(LinuxConfiguration);
            }
            if (Core.Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AllowExtensionOperations))
            {
                writer.WritePropertyName("allowExtensionOperations"u8);
                writer.WriteBooleanValue(AllowExtensionOperations.Value);
            }
            if (Core.Optional.IsDefined(RequireGuestProvisionSignal))
            {
                writer.WritePropertyName("requireGuestProvisionSignal"u8);
                writer.WriteBooleanValue(RequireGuestProvisionSignal.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineOSProfile DeserializeVirtualMachineOSProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> computerName = default;
            Core.Optional<string> adminUsername = default;
            Core.Optional<string> adminPassword = default;
            Core.Optional<string> customData = default;
            Core.Optional<WindowsConfiguration> windowsConfiguration = default;
            Core.Optional<LinuxConfiguration> linuxConfiguration = default;
            Core.Optional<IList<VaultSecretGroup>> secrets = default;
            Core.Optional<bool> allowExtensionOperations = default;
            Core.Optional<bool> requireGuestProvisionSignal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"u8))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customData"u8))
                {
                    customData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxConfiguration = LinuxConfiguration.DeserializeLinuxConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VaultSecretGroup> array = new List<VaultSecretGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultSecretGroup.DeserializeVaultSecretGroup(item));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("allowExtensionOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowExtensionOperations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireGuestProvisionSignal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireGuestProvisionSignal = property.Value.GetBoolean();
                    continue;
                }
            }
            return new VirtualMachineOSProfile(computerName.Value, adminUsername.Value, adminPassword.Value, customData.Value, windowsConfiguration.Value, linuxConfiguration.Value, Core.Optional.ToList(secrets), Core.Optional.ToNullable(allowExtensionOperations), Core.Optional.ToNullable(requireGuestProvisionSignal));
        }
    }
}
