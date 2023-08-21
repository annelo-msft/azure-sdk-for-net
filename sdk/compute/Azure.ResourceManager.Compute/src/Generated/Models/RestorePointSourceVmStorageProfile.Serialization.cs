// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointSourceVmStorageProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (Core.Optional.IsCollectionDefined(DataDiskList))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RestorePointSourceVmStorageProfile DeserializeRestorePointSourceVmStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<RestorePointSourceVmOSDisk> osDisk = default;
            Core.Optional<IList<RestorePointSourceVmDataDisk>> dataDisks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = RestorePointSourceVmOSDisk.DeserializeRestorePointSourceVmOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorePointSourceVmDataDisk> array = new List<RestorePointSourceVmDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorePointSourceVmDataDisk.DeserializeRestorePointSourceVmDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
            }
            return new RestorePointSourceVmStorageProfile(osDisk.Value, Core.Optional.ToList(dataDisks));
        }
    }
}
