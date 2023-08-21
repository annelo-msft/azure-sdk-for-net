// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceDateSpan : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start, "D");
            writer.WritePropertyName("end"u8);
            writer.WriteStringValue(End, "D");
            writer.WriteEndObject();
        }

        internal static ContainerServiceDateSpan DeserializeContainerServiceDateSpan(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset start = default;
            DateTimeOffset end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetDateTimeOffset("D");
                    continue;
                }
            }
            return new ContainerServiceDateSpan(start, end);
        }
    }
}
