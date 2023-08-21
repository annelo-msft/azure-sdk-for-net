// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAadRegistration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(OpenIdIssuer))
            {
                writer.WritePropertyName("openIdIssuer"u8);
                writer.WriteStringValue(OpenIdIssuer);
            }
            if (Core.Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Core.Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
            }
            if (Core.Optional.IsDefined(ClientSecretCertificateThumbprintString))
            {
                writer.WritePropertyName("clientSecretCertificateThumbprint"u8);
                writer.WriteStringValue(ClientSecretCertificateThumbprintString);
            }
            if (Core.Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                writer.WritePropertyName("clientSecretCertificateSubjectAlternativeName"u8);
                writer.WriteStringValue(ClientSecretCertificateSubjectAlternativeName);
            }
            if (Core.Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                writer.WritePropertyName("clientSecretCertificateIssuer"u8);
                writer.WriteStringValue(ClientSecretCertificateIssuer);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceAadRegistration DeserializeAppServiceAadRegistration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> openIdIssuer = default;
            Core.Optional<string> clientId = default;
            Core.Optional<string> clientSecretSettingName = default;
            Core.Optional<string> clientSecretCertificateThumbprint = default;
            Core.Optional<string> clientSecretCertificateSubjectAlternativeName = default;
            Core.Optional<string> clientSecretCertificateIssuer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openIdIssuer"u8))
                {
                    openIdIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateThumbprint"u8))
                {
                    clientSecretCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateSubjectAlternativeName"u8))
                {
                    clientSecretCertificateSubjectAlternativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateIssuer"u8))
                {
                    clientSecretCertificateIssuer = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceAadRegistration(openIdIssuer.Value, clientId.Value, clientSecretSettingName.Value, clientSecretCertificateThumbprint.Value, clientSecretCertificateSubjectAlternativeName.Value, clientSecretCertificateIssuer.Value);
        }
    }
}
