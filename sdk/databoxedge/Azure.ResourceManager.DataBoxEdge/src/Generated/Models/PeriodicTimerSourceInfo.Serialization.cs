// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class PeriodicTimerSourceInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("schedule"u8);
            writer.WriteStringValue(Schedule);
            if (Core.Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteStringValue(Topic);
            }
            writer.WriteEndObject();
        }

        internal static PeriodicTimerSourceInfo DeserializePeriodicTimerSourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            string schedule = default;
            Core.Optional<string> topic = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    schedule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    topic = property.Value.GetString();
                    continue;
                }
            }
            return new PeriodicTimerSourceInfo(startTime, schedule, topic.Value);
        }
    }
}
