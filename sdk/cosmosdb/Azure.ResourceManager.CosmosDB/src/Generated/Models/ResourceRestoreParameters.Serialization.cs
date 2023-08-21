// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ResourceRestoreParameters : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RestoreSource))
            {
                writer.WritePropertyName("restoreSource"u8);
                writer.WriteStringValue(RestoreSource);
            }
            if (Core.Optional.IsDefined(RestoreTimestampInUtc))
            {
                writer.WritePropertyName("restoreTimestampInUtc"u8);
                writer.WriteStringValue(RestoreTimestampInUtc.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ResourceRestoreParameters DeserializeResourceRestoreParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> restoreSource = default;
            Core.Optional<DateTimeOffset> restoreTimestampInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restoreSource"u8))
                {
                    restoreSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTimestampInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreTimestampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ResourceRestoreParameters(restoreSource.Value, Core.Optional.ToNullable(restoreTimestampInUtc));
        }
    }
}
