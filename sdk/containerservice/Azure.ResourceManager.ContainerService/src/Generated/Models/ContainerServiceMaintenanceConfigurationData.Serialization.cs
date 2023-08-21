// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ContainerServiceMaintenanceConfigurationData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(TimesInWeek))
            {
                writer.WritePropertyName("timeInWeek"u8);
                writer.WriteStartArray();
                foreach (var item in TimesInWeek)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(NotAllowedTimes))
            {
                writer.WritePropertyName("notAllowedTime"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedTimes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerServiceMaintenanceConfigurationData DeserializeContainerServiceMaintenanceConfigurationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<IList<ContainerServiceTimeInWeek>> timeInWeek = default;
            Core.Optional<IList<ContainerServiceTimeSpan>> notAllowedTime = default;
            Core.Optional<ContainerServiceMaintenanceWindow> maintenanceWindow = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timeInWeek"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerServiceTimeInWeek> array = new List<ContainerServiceTimeInWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerServiceTimeInWeek.DeserializeContainerServiceTimeInWeek(item));
                            }
                            timeInWeek = array;
                            continue;
                        }
                        if (property0.NameEquals("notAllowedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerServiceTimeSpan> array = new List<ContainerServiceTimeSpan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerServiceTimeSpan.DeserializeContainerServiceTimeSpan(item));
                            }
                            notAllowedTime = array;
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = ContainerServiceMaintenanceWindow.DeserializeContainerServiceMaintenanceWindow(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerServiceMaintenanceConfigurationData(id, name, type, systemData.Value, Core.Optional.ToList(timeInWeek), Core.Optional.ToList(notAllowedTime), maintenanceWindow.Value);
        }
    }
}
