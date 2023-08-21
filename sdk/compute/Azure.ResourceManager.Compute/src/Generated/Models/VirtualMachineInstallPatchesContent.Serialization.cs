// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineInstallPatchesContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MaximumDuration))
            {
                writer.WritePropertyName("maximumDuration"u8);
                writer.WriteStringValue(MaximumDuration.Value, "P");
            }
            writer.WritePropertyName("rebootSetting"u8);
            writer.WriteStringValue(RebootSetting.ToString());
            if (Core.Optional.IsDefined(WindowsParameters))
            {
                writer.WritePropertyName("windowsParameters"u8);
                writer.WriteObjectValue(WindowsParameters);
            }
            if (Core.Optional.IsDefined(LinuxParameters))
            {
                writer.WritePropertyName("linuxParameters"u8);
                writer.WriteObjectValue(LinuxParameters);
            }
            writer.WriteEndObject();
        }
    }
}
