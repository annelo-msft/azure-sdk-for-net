// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class HardwareProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MemorySizeMB))
            {
                writer.WritePropertyName("memorySizeMB"u8);
                writer.WriteNumberValue(MemorySizeMB.Value);
            }
            if (Core.Optional.IsDefined(NumCpus))
            {
                writer.WritePropertyName("numCPUs"u8);
                writer.WriteNumberValue(NumCpus.Value);
            }
            if (Core.Optional.IsDefined(NumCoresPerSocket))
            {
                writer.WritePropertyName("numCoresPerSocket"u8);
                writer.WriteNumberValue(NumCoresPerSocket.Value);
            }
            writer.WriteEndObject();
        }

        internal static HardwareProfile DeserializeHardwareProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> memorySizeMB = default;
            Core.Optional<int> numCpus = default;
            Core.Optional<int> numCoresPerSocket = default;
            Core.Optional<bool> cpuHotAddEnabled = default;
            Core.Optional<bool> cpuHotRemoveEnabled = default;
            Core.Optional<bool> memoryHotAddEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memorySizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memorySizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numCpus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numCoresPerSocket"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numCoresPerSocket = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuHotAddEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuHotAddEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuHotRemoveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuHotRemoveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("memoryHotAddEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryHotAddEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new HardwareProfile(Core.Optional.ToNullable(memorySizeMB), Core.Optional.ToNullable(numCpus), Core.Optional.ToNullable(numCoresPerSocket), Core.Optional.ToNullable(cpuHotAddEnabled), Core.Optional.ToNullable(cpuHotRemoveEnabled), Core.Optional.ToNullable(memoryHotAddEnabled));
        }
    }
}
