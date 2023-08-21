// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RuleEngineQueueSelectorAttachment : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rule"u8);
            writer.WriteObjectValue(Rule);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static RuleEngineQueueSelectorAttachment DeserializeRuleEngineQueueSelectorAttachment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule rule = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rule"u8))
                {
                    rule = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new RuleEngineQueueSelectorAttachment(kind, rule);
        }
    }
}
