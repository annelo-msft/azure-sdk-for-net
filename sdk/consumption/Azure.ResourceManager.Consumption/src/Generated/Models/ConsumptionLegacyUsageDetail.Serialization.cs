// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionLegacyUsageDetail
    {
        internal static ConsumptionLegacyUsageDetail DeserializeConsumptionLegacyUsageDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UsageDetailsKind kind = default;
            Core.Optional<ETag> etag = default;
            Core.Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> billingAccountId = default;
            Core.Optional<string> billingAccountName = default;
            Core.Optional<DateTimeOffset> billingPeriodStartDate = default;
            Core.Optional<DateTimeOffset> billingPeriodEndDate = default;
            Core.Optional<string> billingProfileId = default;
            Core.Optional<string> billingProfileName = default;
            Core.Optional<string> accountOwnerId = default;
            Core.Optional<string> accountName = default;
            Core.Optional<string> subscriptionId = default;
            Core.Optional<string> subscriptionName = default;
            Core.Optional<DateTimeOffset> date = default;
            Core.Optional<string> product = default;
            Core.Optional<string> partNumber = default;
            Core.Optional<Guid> meterId = default;
            Core.Optional<ConsumptionMeterDetailsInfo> meterDetails = default;
            Core.Optional<decimal> quantity = default;
            Core.Optional<decimal> effectivePrice = default;
            Core.Optional<decimal> cost = default;
            Core.Optional<decimal> unitPrice = default;
            Core.Optional<string> billingCurrency = default;
            Core.Optional<string> resourceLocation = default;
            Core.Optional<string> consumedService = default;
            Core.Optional<string> resourceId = default;
            Core.Optional<string> resourceName = default;
            Core.Optional<string> serviceInfo1 = default;
            Core.Optional<string> serviceInfo2 = default;
            Core.Optional<string> additionalInfo = default;
            Core.Optional<string> invoiceSection = default;
            Core.Optional<string> costCenter = default;
            Core.Optional<string> resourceGroup = default;
            Core.Optional<string> reservationId = default;
            Core.Optional<string> reservationName = default;
            Core.Optional<string> productOrderId = default;
            Core.Optional<string> productOrderName = default;
            Core.Optional<string> offerId = default;
            Core.Optional<bool> isAzureCreditEligible = default;
            Core.Optional<string> term = default;
            Core.Optional<string> publisherName = default;
            Core.Optional<string> publisherType = default;
            Core.Optional<string> planName = default;
            Core.Optional<string> chargeType = default;
            Core.Optional<string> frequency = default;
            Core.Optional<decimal> payGPrice = default;
            Core.Optional<string> benefitId = default;
            Core.Optional<string> benefitName = default;
            Core.Optional<ConsumptionPricingModelType> pricingModel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new UsageDetailsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            billingAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingAccountName"u8))
                        {
                            billingAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            billingPeriodStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            billingPeriodEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerId"u8))
                        {
                            accountOwnerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionName"u8))
                        {
                            subscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("date"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            date = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partNumber"u8))
                        {
                            partNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("meterDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            meterDetails = ConsumptionMeterDetailsInfo.DeserializeConsumptionMeterDetailsInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("effectivePrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            effectivePrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("cost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cost = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("unitPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unitPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceLocation"u8))
                        {
                            resourceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumedService"u8))
                        {
                            consumedService = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceName"u8))
                        {
                            resourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo1"u8))
                        {
                            serviceInfo1 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo2"u8))
                        {
                            serviceInfo2 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalInfo"u8))
                        {
                            additionalInfo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSection"u8))
                        {
                            invoiceSection = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"u8))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"u8))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationName"u8))
                        {
                            reservationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderId"u8))
                        {
                            productOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderName"u8))
                        {
                            productOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAzureCreditEligible"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureCreditEligible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"u8))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherType"u8))
                        {
                            publisherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("planName"u8))
                        {
                            planName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("chargeType"u8))
                        {
                            chargeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("payGPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            payGPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("benefitId"u8))
                        {
                            benefitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitName"u8))
                        {
                            benefitName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pricingModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pricingModel = new ConsumptionPricingModelType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionLegacyUsageDetail(id, name, type, systemData.Value, kind, Core.Optional.ToNullable(etag), Core.Optional.ToDictionary(tags), billingAccountId.Value, billingAccountName.Value, Core.Optional.ToNullable(billingPeriodStartDate), Core.Optional.ToNullable(billingPeriodEndDate), billingProfileId.Value, billingProfileName.Value, accountOwnerId.Value, accountName.Value, subscriptionId.Value, subscriptionName.Value, Core.Optional.ToNullable(date), product.Value, partNumber.Value, Core.Optional.ToNullable(meterId), meterDetails.Value, Core.Optional.ToNullable(quantity), Core.Optional.ToNullable(effectivePrice), Core.Optional.ToNullable(cost), Core.Optional.ToNullable(unitPrice), billingCurrency.Value, resourceLocation.Value, consumedService.Value, resourceId.Value, resourceName.Value, serviceInfo1.Value, serviceInfo2.Value, additionalInfo.Value, invoiceSection.Value, costCenter.Value, resourceGroup.Value, reservationId.Value, reservationName.Value, productOrderId.Value, productOrderName.Value, offerId.Value, Core.Optional.ToNullable(isAzureCreditEligible), term.Value, publisherName.Value, publisherType.Value, planName.Value, chargeType.Value, frequency.Value, Core.Optional.ToNullable(payGPrice), benefitId.Value, benefitName.Value, Core.Optional.ToNullable(pricingModel));
        }
    }
}
