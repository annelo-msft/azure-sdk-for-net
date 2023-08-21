// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class MsSqlServerProviderInstanceProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Core.Optional.IsDefined(DBPort))
            {
                writer.WritePropertyName("dbPort"u8);
                writer.WriteStringValue(DBPort);
            }
            if (Core.Optional.IsDefined(DBUsername))
            {
                writer.WritePropertyName("dbUsername"u8);
                writer.WriteStringValue(DBUsername);
            }
            if (Core.Optional.IsDefined(DBPassword))
            {
                writer.WritePropertyName("dbPassword"u8);
                writer.WriteStringValue(DBPassword);
            }
            if (Core.Optional.IsDefined(DBPasswordUri))
            {
                writer.WritePropertyName("dbPasswordUri"u8);
                writer.WriteStringValue(DBPasswordUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid"u8);
                writer.WriteStringValue(SapSid);
            }
            if (Core.Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Core.Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
            writer.WriteEndObject();
        }

        internal static MsSqlServerProviderInstanceProperties DeserializeMsSqlServerProviderInstanceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> hostname = default;
            Core.Optional<string> dbPort = default;
            Core.Optional<string> dbUsername = default;
            Core.Optional<string> dbPassword = default;
            Core.Optional<Uri> dbPasswordUri = default;
            Core.Optional<string> sapSid = default;
            Core.Optional<SapSslPreference> sslPreference = default;
            Core.Optional<Uri> sslCertificateUri = default;
            string providerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPort"u8))
                {
                    dbPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUsername"u8))
                {
                    dbUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPassword"u8))
                {
                    dbPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapSid"u8))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
            }
            return new MsSqlServerProviderInstanceProperties(providerType, hostname.Value, dbPort.Value, dbUsername.Value, dbPassword.Value, dbPasswordUri.Value, sapSid.Value, Core.Optional.ToNullable(sslPreference), sslCertificateUri.Value);
        }
    }
}
