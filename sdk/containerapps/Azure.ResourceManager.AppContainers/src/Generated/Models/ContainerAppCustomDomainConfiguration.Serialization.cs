// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCustomDomainConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix"u8);
                writer.WriteStringValue(DnsSuffix);
            }
            if (Core.Optional.IsDefined(CertificateValue))
            {
                writer.WritePropertyName("certificateValue"u8);
                writer.WriteBase64StringValue(CertificateValue, "D");
            }
            if (Core.Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword"u8);
                writer.WriteStringValue(CertificatePassword);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppCustomDomainConfiguration DeserializeContainerAppCustomDomainConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> customDomainVerificationId = default;
            Core.Optional<string> dnsSuffix = default;
            Core.Optional<byte[]> certificateValue = default;
            Core.Optional<string> certificatePassword = default;
            Core.Optional<DateTimeOffset> expirationDate = default;
            Core.Optional<string> thumbprint = default;
            Core.Optional<string> subjectName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customDomainVerificationId"u8))
                {
                    customDomainVerificationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsSuffix"u8))
                {
                    dnsSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateValue = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("certificatePassword"u8))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppCustomDomainConfiguration(customDomainVerificationId.Value, dnsSuffix.Value, certificateValue.Value, certificatePassword.Value, Core.Optional.ToNullable(expirationDate), thumbprint.Value, subjectName.Value);
        }
    }
}
