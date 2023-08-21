// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineScaleSetHardwareProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(VmSizeProperties))
            {
                writer.WritePropertyName("vmSizeProperties"u8);
                writer.WriteObjectValue(VmSizeProperties);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetHardwareProfile DeserializeVirtualMachineScaleSetHardwareProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<VirtualMachineSizeProperties> vmSizeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSizeProperties = VirtualMachineSizeProperties.DeserializeVirtualMachineSizeProperties(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetHardwareProfile(vmSizeProperties.Value);
        }
    }
}
