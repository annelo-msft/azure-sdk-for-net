// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppAuthConfigData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteObjectValue(Platform);
            }
            if (Core.Optional.IsDefined(GlobalValidation))
            {
                writer.WritePropertyName("globalValidation"u8);
                writer.WriteObjectValue(GlobalValidation);
            }
            if (Core.Optional.IsDefined(IdentityProviders))
            {
                writer.WritePropertyName("identityProviders"u8);
                writer.WriteObjectValue(IdentityProviders);
            }
            if (Core.Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login);
            }
            if (Core.Optional.IsDefined(HttpSettings))
            {
                writer.WritePropertyName("httpSettings"u8);
                writer.WriteObjectValue(HttpSettings);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerAppAuthConfigData DeserializeContainerAppAuthConfigData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ContainerAppAuthPlatform> platform = default;
            Core.Optional<ContainerAppGlobalValidation> globalValidation = default;
            Core.Optional<ContainerAppIdentityProvidersConfiguration> identityProviders = default;
            Core.Optional<ContainerAppLogin> login = default;
            Core.Optional<ContainerAppHttpSettings> httpSettings = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("platform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platform = ContainerAppAuthPlatform.DeserializeContainerAppAuthPlatform(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("globalValidation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalValidation = ContainerAppGlobalValidation.DeserializeContainerAppGlobalValidation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("identityProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identityProviders = ContainerAppIdentityProvidersConfiguration.DeserializeContainerAppIdentityProvidersConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("login"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            login = ContainerAppLogin.DeserializeContainerAppLogin(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpSettings = ContainerAppHttpSettings.DeserializeContainerAppHttpSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerAppAuthConfigData(id, name, type, systemData.Value, platform.Value, globalValidation.Value, identityProviders.Value, login.Value, httpSettings.Value);
        }
    }
}
