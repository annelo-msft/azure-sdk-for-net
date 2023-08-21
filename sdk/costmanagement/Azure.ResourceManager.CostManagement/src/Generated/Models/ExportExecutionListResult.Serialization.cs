// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    internal partial class ExportExecutionListResult : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ExportExecutionListResult DeserializeExportExecutionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ExportRun>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExportRun> array = new List<ExportRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExportRun.DeserializeExportRun(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExportExecutionListResult(Core.Optional.ToList(value));
        }
    }
}
