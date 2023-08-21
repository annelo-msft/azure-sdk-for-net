// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ScheduleAndSuspendMode : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ScheduleAt))
            {
                writer.WritePropertyName("scheduleAt"u8);
                writer.WriteStringValue(ScheduleAt, "O");
            }
            writer.WriteEndObject();
        }

        internal static ScheduleAndSuspendMode DeserializeScheduleAndSuspendMode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> scheduleAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ScheduleAndSuspendMode(scheduleAt);
        }
    }
}
