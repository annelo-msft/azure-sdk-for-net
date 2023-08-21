// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class BudgetFilterProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            if (Core.Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteObjectValue(Tags);
            }
            writer.WriteEndObject();
        }

        internal static BudgetFilterProperties DeserializeBudgetFilterProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<BudgetComparisonExpression> dimensions = default;
            Core.Optional<BudgetComparisonExpression> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensions = BudgetComparisonExpression.DeserializeBudgetComparisonExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = BudgetComparisonExpression.DeserializeBudgetComparisonExpression(property.Value);
                    continue;
                }
            }
            return new BudgetFilterProperties(dimensions.Value, tags.Value);
        }
    }
}
