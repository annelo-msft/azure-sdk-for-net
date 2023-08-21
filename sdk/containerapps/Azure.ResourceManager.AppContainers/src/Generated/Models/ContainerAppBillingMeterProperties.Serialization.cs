// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppBillingMeterProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(WorkloadProfileCategory))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(WorkloadProfileCategory);
            }
            if (Core.Optional.IsDefined(MeterType))
            {
                writer.WritePropertyName("meterType"u8);
                writer.WriteStringValue(MeterType);
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppBillingMeterProperties DeserializeContainerAppBillingMeterProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> category = default;
            Core.Optional<string> meterType = default;
            Core.Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterType"u8))
                {
                    meterType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppBillingMeterProperties(category.Value, meterType.Value, displayName.Value);
        }
    }
}
