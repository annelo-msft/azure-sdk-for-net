// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinitionPropertiesItem
    {
        internal static CanonicalProfileDefinitionPropertiesItem DeserializeCanonicalProfileDefinitionPropertiesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> profileName = default;
            Core.Optional<string> profilePropertyName = default;
            Core.Optional<int> rank = default;
            Core.Optional<CanonicalPropertyValueType> type = default;
            Core.Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyName"u8))
                {
                    profilePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rank"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rank = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new CanonicalPropertyValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new CanonicalProfileDefinitionPropertiesItem(profileName.Value, profilePropertyName.Value, Core.Optional.ToNullable(rank), Core.Optional.ToNullable(type), value.Value);
        }
    }
}
