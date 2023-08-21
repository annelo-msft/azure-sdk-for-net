// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteLimits : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MaxPercentageCpu))
            {
                writer.WritePropertyName("maxPercentageCpu"u8);
                writer.WriteNumberValue(MaxPercentageCpu.Value);
            }
            if (Core.Optional.IsDefined(MaxMemoryInMb))
            {
                writer.WritePropertyName("maxMemoryInMb"u8);
                writer.WriteNumberValue(MaxMemoryInMb.Value);
            }
            if (Core.Optional.IsDefined(MaxDiskSizeInMb))
            {
                writer.WritePropertyName("maxDiskSizeInMb"u8);
                writer.WriteNumberValue(MaxDiskSizeInMb.Value);
            }
            writer.WriteEndObject();
        }

        internal static SiteLimits DeserializeSiteLimits(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<double> maxPercentageCpu = default;
            Core.Optional<long> maxMemoryInMb = default;
            Core.Optional<long> maxDiskSizeInMb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentageCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentageCpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxMemoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDiskSizeInMb = property.Value.GetInt64();
                    continue;
                }
            }
            return new SiteLimits(Core.Optional.ToNullable(maxPercentageCpu), Core.Optional.ToNullable(maxMemoryInMb), Core.Optional.ToNullable(maxDiskSizeInMb));
        }
    }
}
