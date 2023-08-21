// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ExportRecurrencePeriod : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("from"u8);
            writer.WriteStringValue(From, "O");
            if (Core.Optional.IsDefined(To))
            {
                writer.WritePropertyName("to"u8);
                writer.WriteStringValue(To.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ExportRecurrencePeriod DeserializeExportRecurrencePeriod(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset @from = default;
            Core.Optional<DateTimeOffset> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    to = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ExportRecurrencePeriod(@from, Core.Optional.ToNullable(to));
        }
    }
}
