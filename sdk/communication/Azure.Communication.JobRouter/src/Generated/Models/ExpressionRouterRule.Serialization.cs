// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ExpressionRouterRule : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static ExpressionRouterRule DeserializeExpressionRouterRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> language = default;
            string expression = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressionRouterRule(kind, language.Value, expression);
        }
    }
}
