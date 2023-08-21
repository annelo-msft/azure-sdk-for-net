// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterAzureMonitorProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteObjectValue(Metrics);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAzureMonitorProfile DeserializeManagedClusterAzureMonitorProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ManagedClusterMonitorProfileMetrics> metrics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metrics = ManagedClusterMonitorProfileMetrics.DeserializeManagedClusterMonitorProfileMetrics(property.Value);
                    continue;
                }
            }
            return new ManagedClusterAzureMonitorProfile(metrics.Value);
        }
    }
}
