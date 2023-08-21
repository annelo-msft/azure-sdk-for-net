// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class ExtractiveSummarizationLROResult : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Core.Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static ExtractiveSummarizationLROResult DeserializeExtractiveSummarizationLROResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtractiveSummarizationResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            Core.Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = ExtractiveSummarizationResult.DeserializeExtractiveSummarizationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new ExtractiveSummarizationLROResult(lastUpdateDateTime, status, kind, taskName.Value, results);
        }
    }
}
