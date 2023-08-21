// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class SingleScopeBenefitRecommendationProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteStringValue(LookBackPeriod.Value.ToString());
            }
            if (Core.Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage);
            }
            if (Core.Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Core.Optional.IsDefined(CommitmentGranularity))
            {
                writer.WritePropertyName("commitmentGranularity"u8);
                writer.WriteStringValue(CommitmentGranularity.Value.ToString());
            }
            if (Core.Optional.IsDefined(RecommendationDetails))
            {
                writer.WritePropertyName("recommendationDetails"u8);
                writer.WriteObjectValue(RecommendationDetails);
            }
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
            writer.WriteEndObject();
        }

        internal static SingleScopeBenefitRecommendationProperties DeserializeSingleScopeBenefitRecommendationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> subscriptionId = default;
            Core.Optional<string> resourceGroup = default;
            Core.Optional<DateTimeOffset> firstConsumptionDate = default;
            Core.Optional<DateTimeOffset> lastConsumptionDate = default;
            Core.Optional<LookBackPeriod> lookBackPeriod = default;
            Core.Optional<int> totalHours = default;
            Core.Optional<RecommendationUsageDetails> usage = default;
            Core.Optional<string> armSkuName = default;
            Core.Optional<BenefitRecommendationPeriodTerm> term = default;
            Core.Optional<BenefitRecommendationUsageGrain> commitmentGranularity = default;
            Core.Optional<string> currencyCode = default;
            Core.Optional<decimal> costWithoutBenefit = default;
            Core.Optional<AllSavingsBenefitDetails> recommendationDetails = default;
            Core.Optional<AllSavingsList> allRecommendationDetails = default;
            BenefitRecommendationScope scope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lookBackPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lookBackPeriod = new LookBackPeriod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = RecommendationUsageDetails.DeserializeRecommendationUsageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("armSkuName"u8))
                {
                    armSkuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("term"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    term = new BenefitRecommendationPeriodTerm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentGranularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentGranularity = new BenefitRecommendationUsageGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("costWithoutBenefit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    costWithoutBenefit = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("recommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendationDetails = AllSavingsBenefitDetails.DeserializeAllSavingsBenefitDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("allRecommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allRecommendationDetails = AllSavingsList.DeserializeAllSavingsList(property.Value);
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = new BenefitRecommendationScope(property.Value.GetString());
                    continue;
                }
            }
            return new SingleScopeBenefitRecommendationProperties(Core.Optional.ToNullable(firstConsumptionDate), Core.Optional.ToNullable(lastConsumptionDate), Core.Optional.ToNullable(lookBackPeriod), Core.Optional.ToNullable(totalHours), usage.Value, armSkuName.Value, Core.Optional.ToNullable(term), Core.Optional.ToNullable(commitmentGranularity), currencyCode.Value, Core.Optional.ToNullable(costWithoutBenefit), recommendationDetails.Value, allRecommendationDetails.Value, scope, subscriptionId.Value, resourceGroup.Value);
        }
    }
}
