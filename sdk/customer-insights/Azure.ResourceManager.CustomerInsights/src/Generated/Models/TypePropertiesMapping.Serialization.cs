// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class TypePropertiesMapping : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourcePropertyName"u8);
            writer.WriteStringValue(SourcePropertyName);
            writer.WritePropertyName("targetPropertyName"u8);
            writer.WriteStringValue(TargetPropertyName);
            if (Core.Optional.IsDefined(LinkType))
            {
                writer.WritePropertyName("linkType"u8);
                writer.WriteStringValue(LinkType.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static TypePropertiesMapping DeserializeTypePropertiesMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourcePropertyName = default;
            string targetPropertyName = default;
            Core.Optional<LinkType> linkType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePropertyName"u8))
                {
                    sourcePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPropertyName"u8))
                {
                    targetPropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkType = property.Value.GetString().ToLinkType();
                    continue;
                }
            }
            return new TypePropertiesMapping(sourcePropertyName, targetPropertyName, Core.Optional.ToNullable(linkType));
        }
    }
}
