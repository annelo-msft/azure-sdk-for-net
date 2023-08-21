// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class RelationshipTypeFieldMapping : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("profileFieldName"u8);
            writer.WriteStringValue(ProfileFieldName);
            writer.WritePropertyName("relatedProfileKeyProperty"u8);
            writer.WriteStringValue(RelatedProfileKeyProperty);
            writer.WriteEndObject();
        }

        internal static RelationshipTypeFieldMapping DeserializeRelationshipTypeFieldMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileFieldName = default;
            string relatedProfileKeyProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileFieldName"u8))
                {
                    profileFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relatedProfileKeyProperty"u8))
                {
                    relatedProfileKeyProperty = property.Value.GetString();
                    continue;
                }
            }
            return new RelationshipTypeFieldMapping(profileFieldName, relatedProfileKeyProperty);
        }
    }
}
