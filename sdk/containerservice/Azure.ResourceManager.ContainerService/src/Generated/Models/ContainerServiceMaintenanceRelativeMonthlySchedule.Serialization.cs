// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceRelativeMonthlySchedule : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("intervalMonths"u8);
            writer.WriteNumberValue(IntervalMonths);
            writer.WritePropertyName("weekIndex"u8);
            writer.WriteStringValue(WeekIndex.ToString());
            writer.WritePropertyName("dayOfWeek"u8);
            writer.WriteStringValue(DayOfWeek.ToString());
            writer.WriteEndObject();
        }

        internal static ContainerServiceMaintenanceRelativeMonthlySchedule DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalMonths = default;
            ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex weekIndex = default;
            ContainerServiceWeekDay dayOfWeek = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalMonths"u8))
                {
                    intervalMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weekIndex"u8))
                {
                    weekIndex = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    dayOfWeek = new ContainerServiceWeekDay(property.Value.GetString());
                    continue;
                }
            }
            return new ContainerServiceMaintenanceRelativeMonthlySchedule(intervalMonths, weekIndex, dayOfWeek);
        }
    }
}
