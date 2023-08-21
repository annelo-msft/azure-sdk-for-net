// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class PatchSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(EnableHotpatching))
            {
                writer.WritePropertyName("enableHotpatching"u8);
                writer.WriteBooleanValue(EnableHotpatching.Value);
            }
            if (Core.Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(AutomaticByPlatformSettings))
            {
                writer.WritePropertyName("automaticByPlatformSettings"u8);
                writer.WriteObjectValue(AutomaticByPlatformSettings);
            }
            writer.WriteEndObject();
        }

        internal static PatchSettings DeserializePatchSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<WindowsVmGuestPatchMode> patchMode = default;
            Core.Optional<bool> enableHotpatching = default;
            Core.Optional<WindowsPatchAssessmentMode> assessmentMode = default;
            Core.Optional<WindowsVmGuestPatchAutomaticByPlatformSettings> automaticByPlatformSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchMode = new WindowsVmGuestPatchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableHotpatching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableHotpatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("assessmentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentMode = new WindowsPatchAssessmentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automaticByPlatformSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticByPlatformSettings = WindowsVmGuestPatchAutomaticByPlatformSettings.DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(property.Value);
                    continue;
                }
            }
            return new PatchSettings(Core.Optional.ToNullable(patchMode), Core.Optional.ToNullable(enableHotpatching), Core.Optional.ToNullable(assessmentMode), automaticByPlatformSettings.Value);
        }
    }
}
