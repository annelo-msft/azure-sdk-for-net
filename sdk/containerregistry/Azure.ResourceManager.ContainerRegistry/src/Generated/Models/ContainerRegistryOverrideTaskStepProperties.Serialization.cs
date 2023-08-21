// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryOverrideTaskStepProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Core.Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(File);
            }
            if (Core.Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Core.Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(UpdateTriggerToken))
            {
                writer.WritePropertyName("updateTriggerToken"u8);
                writer.WriteStringValue(UpdateTriggerToken);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryOverrideTaskStepProperties DeserializeContainerRegistryOverrideTaskStepProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> contextPath = default;
            Core.Optional<string> file = default;
            Core.Optional<IList<ContainerRegistryRunArgument>> arguments = default;
            Core.Optional<string> target = default;
            Core.Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            Core.Optional<string> updateTriggerToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("updateTriggerToken"u8))
                {
                    updateTriggerToken = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryOverrideTaskStepProperties(contextPath.Value, file.Value, Core.Optional.ToList(arguments), target.Value, Core.Optional.ToList(values), updateTriggerToken.Value);
        }
    }
}
