// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareRelationEntity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ref"u8);
            writer.WriteStringValue(Ref);
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role);
            writer.WriteEndObject();
        }

        internal static HealthcareRelationEntity DeserializeHealthcareRelationEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @ref = default;
            string role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ref"u8))
                {
                    @ref = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
            }
            return new HealthcareRelationEntity(@ref, role);
        }
    }
}
