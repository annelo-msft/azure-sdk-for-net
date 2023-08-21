// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceCertificateOrderPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartObject();
                foreach (var item in Certificates)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(DistinguishedName))
            {
                writer.WritePropertyName("distinguishedName"u8);
                writer.WriteStringValue(DistinguishedName);
            }
            if (Core.Optional.IsDefined(ValidityInYears))
            {
                writer.WritePropertyName("validityInYears"u8);
                writer.WriteNumberValue(ValidityInYears.Value);
            }
            if (Core.Optional.IsDefined(KeySize))
            {
                writer.WritePropertyName("keySize"u8);
                writer.WriteNumberValue(KeySize.Value);
            }
            if (Core.Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(IsAutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteBooleanValue(IsAutoRenew.Value);
            }
            if (Core.Optional.IsDefined(Csr))
            {
                writer.WritePropertyName("csr"u8);
                writer.WriteStringValue(Csr);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceCertificateOrderPatch DeserializeAppServiceCertificateOrderPatch(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<IDictionary<string, AppServiceCertificateProperties>> certificates = default;
            Core.Optional<string> distinguishedName = default;
            Core.Optional<string> domainVerificationToken = default;
            Core.Optional<int> validityInYears = default;
            Core.Optional<int> keySize = default;
            Core.Optional<CertificateProductType> productType = default;
            Core.Optional<bool> autoRenew = default;
            Core.Optional<ProvisioningState> provisioningState = default;
            Core.Optional<CertificateOrderStatus> status = default;
            Core.Optional<AppServiceCertificateDetails> signedCertificate = default;
            Core.Optional<string> csr = default;
            Core.Optional<AppServiceCertificateDetails> intermediate = default;
            Core.Optional<AppServiceCertificateDetails> root = default;
            Core.Optional<string> serialNumber = default;
            Core.Optional<DateTimeOffset> lastCertificateIssuanceTime = default;
            Core.Optional<DateTimeOffset> expirationTime = default;
            Core.Optional<bool> isPrivateKeyExternal = default;
            Core.Optional<IReadOnlyList<AppServiceCertificateNotRenewableReason>> appServiceCertificateNotRenewableReasons = default;
            Core.Optional<DateTimeOffset> nextAutoRenewalTimeStamp = default;
            Core.Optional<CertificateOrderContact> contact = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AppServiceCertificateProperties> dictionary = new Dictionary<string, AppServiceCertificateProperties>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AppServiceCertificateProperties.DeserializeAppServiceCertificateProperties(property1.Value));
                            }
                            certificates = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("distinguishedName"u8))
                        {
                            distinguishedName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainVerificationToken"u8))
                        {
                            domainVerificationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validityInYears"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validityInYears = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productType = property0.Value.GetString().ToCertificateProductType();
                            continue;
                        }
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToCertificateOrderStatus();
                            continue;
                        }
                        if (property0.NameEquals("signedCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signedCertificate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("csr"u8))
                        {
                            csr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("intermediate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intermediate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("root"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            root = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastCertificateIssuanceTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCertificateIssuanceTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("isPrivateKeyExternal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrivateKeyExternal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServiceCertificateNotRenewableReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceCertificateNotRenewableReason> array = new List<AppServiceCertificateNotRenewableReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AppServiceCertificateNotRenewableReason(item.GetString()));
                            }
                            appServiceCertificateNotRenewableReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("nextAutoRenewalTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextAutoRenewalTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = CertificateOrderContact.DeserializeCertificateOrderContact(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceCertificateOrderPatch(id, name, type, systemData.Value, Core.Optional.ToDictionary(certificates), distinguishedName.Value, domainVerificationToken.Value, Core.Optional.ToNullable(validityInYears), Core.Optional.ToNullable(keySize), Core.Optional.ToNullable(productType), Core.Optional.ToNullable(autoRenew), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(status), signedCertificate.Value, csr.Value, intermediate.Value, root.Value, serialNumber.Value, Core.Optional.ToNullable(lastCertificateIssuanceTime), Core.Optional.ToNullable(expirationTime), Core.Optional.ToNullable(isPrivateKeyExternal), Core.Optional.ToList(appServiceCertificateNotRenewableReasons), Core.Optional.ToNullable(nextAutoRenewalTimeStamp), contact.Value, kind.Value);
        }
    }
}
