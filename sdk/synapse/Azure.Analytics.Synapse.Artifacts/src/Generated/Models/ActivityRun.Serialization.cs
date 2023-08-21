// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityRunConverter))]
    public partial class ActivityRun
    {
        internal static ActivityRun DeserializeActivityRun(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> pipelineName = default;
            Core.Optional<string> pipelineRunId = default;
            Core.Optional<string> activityName = default;
            Core.Optional<string> activityType = default;
            Core.Optional<string> activityRunId = default;
            Core.Optional<string> linkedServiceName = default;
            Core.Optional<string> status = default;
            Core.Optional<DateTimeOffset> activityRunStart = default;
            Core.Optional<DateTimeOffset> activityRunEnd = default;
            Core.Optional<int> durationInMs = default;
            Core.Optional<object> input = default;
            Core.Optional<object> output = default;
            Core.Optional<object> error = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    pipelineRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityName"u8))
                {
                    activityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityType"u8))
                {
                    activityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunId"u8))
                {
                    activityRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityRunEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityRun(pipelineName.Value, pipelineRunId.Value, activityName.Value, activityType.Value, activityRunId.Value, linkedServiceName.Value, status.Value, Core.Optional.ToNullable(activityRunStart), Core.Optional.ToNullable(activityRunEnd), Core.Optional.ToNullable(durationInMs), input.Value, output.Value, error.Value, additionalProperties);
        }

        internal partial class ActivityRunConverter : JsonConverter<ActivityRun>
        {
            public override void Write(Utf8JsonWriter writer, ActivityRun model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ActivityRun Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityRun(document.RootElement);
            }
        }
    }
}
