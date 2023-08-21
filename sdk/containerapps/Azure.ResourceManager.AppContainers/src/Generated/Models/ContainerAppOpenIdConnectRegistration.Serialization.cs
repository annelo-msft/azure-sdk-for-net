// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectRegistration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Core.Optional.IsDefined(ClientCredential))
            {
                writer.WritePropertyName("clientCredential"u8);
                writer.WriteObjectValue(ClientCredential);
            }
            if (Core.Optional.IsDefined(OpenIdConnectConfiguration))
            {
                writer.WritePropertyName("openIdConnectConfiguration"u8);
                writer.WriteObjectValue(OpenIdConnectConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppOpenIdConnectRegistration DeserializeContainerAppOpenIdConnectRegistration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> clientId = default;
            Core.Optional<ContainerAppOpenIdConnectClientCredential> clientCredential = default;
            Core.Optional<ContainerAppOpenIdConnectConfig> openIdConnectConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCredential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCredential = ContainerAppOpenIdConnectClientCredential.DeserializeContainerAppOpenIdConnectClientCredential(property.Value);
                    continue;
                }
                if (property.NameEquals("openIdConnectConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openIdConnectConfiguration = ContainerAppOpenIdConnectConfig.DeserializeContainerAppOpenIdConnectConfig(property.Value);
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectRegistration(clientId.Value, clientCredential.Value, openIdConnectConfiguration.Value);
        }
    }
}
