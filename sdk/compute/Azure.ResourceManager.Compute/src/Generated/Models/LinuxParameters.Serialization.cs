// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class LinuxParameters : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(ClassificationsToInclude))
            {
                writer.WritePropertyName("classificationsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationsToInclude)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(PackageNameMasksToInclude))
            {
                writer.WritePropertyName("packageNameMasksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(PackageNameMasksToExclude))
            {
                writer.WritePropertyName("packageNameMasksToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(MaintenanceRunId))
            {
                writer.WritePropertyName("maintenanceRunId"u8);
                writer.WriteStringValue(MaintenanceRunId);
            }
            writer.WriteEndObject();
        }
    }
}
