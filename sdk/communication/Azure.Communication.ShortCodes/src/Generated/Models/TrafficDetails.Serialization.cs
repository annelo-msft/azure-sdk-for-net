// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class TrafficDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TotalMonthlyVolume))
            {
                writer.WritePropertyName("totalMonthlyVolume"u8);
                writer.WriteNumberValue(TotalMonthlyVolume.Value);
            }
            if (Core.Optional.IsDefined(MonthlyAverageMessagesFromUser))
            {
                writer.WritePropertyName("monthlyAverageMessagesFromUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesFromUser.Value);
            }
            if (Core.Optional.IsDefined(MonthlyAverageMessagesToUser))
            {
                writer.WritePropertyName("monthlyAverageMessagesToUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesToUser.Value);
            }
            if (Core.Optional.IsDefined(IsSpiky))
            {
                writer.WritePropertyName("isSpiky"u8);
                writer.WriteBooleanValue(IsSpiky.Value);
            }
            if (Core.Optional.IsDefined(SpikeDetails))
            {
                writer.WritePropertyName("spikeDetails"u8);
                writer.WriteStringValue(SpikeDetails);
            }
            if (Core.Optional.IsDefined(EstimatedRampUpTimeInDays))
            {
                writer.WritePropertyName("estimatedRampUpTimeInDays"u8);
                writer.WriteNumberValue(EstimatedRampUpTimeInDays.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficDetails DeserializeTrafficDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> totalMonthlyVolume = default;
            Core.Optional<int> monthlyAverageMessagesFromUser = default;
            Core.Optional<int> monthlyAverageMessagesToUser = default;
            Core.Optional<bool> isSpiky = default;
            Core.Optional<string> spikeDetails = default;
            Core.Optional<int> estimatedRampUpTimeInDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMonthlyVolume"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMonthlyVolume = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesFromUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesFromUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesToUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesToUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSpiky"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSpiky = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("spikeDetails"u8))
                {
                    spikeDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("estimatedRampUpTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedRampUpTimeInDays = property.Value.GetInt32();
                    continue;
                }
            }
            return new TrafficDetails(Core.Optional.ToNullable(totalMonthlyVolume), Core.Optional.ToNullable(monthlyAverageMessagesFromUser), Core.Optional.ToNullable(monthlyAverageMessagesToUser), Core.Optional.ToNullable(isSpiky), spikeDetails.Value, Core.Optional.ToNullable(estimatedRampUpTimeInDays));
        }
    }
}
