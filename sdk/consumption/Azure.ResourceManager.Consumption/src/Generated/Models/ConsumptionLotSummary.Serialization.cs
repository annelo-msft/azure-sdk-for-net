// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionLotSummary : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConsumptionLotSummary DeserializeConsumptionLotSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ConsumptionAmount> originalAmount = default;
            Core.Optional<ConsumptionAmount> closedBalance = default;
            Core.Optional<ConsumptionLotSource> source = default;
            Core.Optional<DateTimeOffset> startDate = default;
            Core.Optional<DateTimeOffset> expirationDate = default;
            Core.Optional<string> poNumber = default;
            Core.Optional<DateTimeOffset> purchasedDate = default;
            Core.Optional<ConsumptionLotStatus> status = default;
            Core.Optional<string> creditCurrency = default;
            Core.Optional<string> billingCurrency = default;
            Core.Optional<ConsumptionAmountWithExchangeRate> originalAmountInBillingCurrency = default;
            Core.Optional<ConsumptionAmountWithExchangeRate> closedBalanceInBillingCurrency = default;
            Core.Optional<ConsumptionReseller> reseller = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("originalAmount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originalAmount = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalance = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new ConsumptionLotSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("poNumber"u8))
                        {
                            poNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ConsumptionLotStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creditCurrency"u8))
                        {
                            creditCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("originalAmountInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originalAmountInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalanceInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalanceInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = ConsumptionReseller.DeserializeConsumptionReseller(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionLotSummary(id, name, type, systemData.Value, originalAmount.Value, closedBalance.Value, Core.Optional.ToNullable(source), Core.Optional.ToNullable(startDate), Core.Optional.ToNullable(expirationDate), poNumber.Value, Core.Optional.ToNullable(purchasedDate), Core.Optional.ToNullable(status), creditCurrency.Value, billingCurrency.Value, originalAmountInBillingCurrency.Value, closedBalanceInBillingCurrency.Value, reseller.Value, Core.Optional.ToNullable(eTag));
        }
    }
}
