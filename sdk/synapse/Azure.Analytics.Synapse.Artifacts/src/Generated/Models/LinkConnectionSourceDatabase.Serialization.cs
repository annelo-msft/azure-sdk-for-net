// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkConnectionSourceDatabaseConverter))]
    public partial class LinkConnectionSourceDatabase : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                writer.WriteObjectValue(LinkedService);
            }
            if (Core.Optional.IsDefined(TypeProperties))
            {
                writer.WritePropertyName("typeProperties"u8);
                writer.WriteObjectValue(TypeProperties);
            }
            writer.WriteEndObject();
        }

        internal static LinkConnectionSourceDatabase DeserializeLinkConnectionSourceDatabase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<LinkedServiceReference> linkedService = default;
            Core.Optional<LinkConnectionSourceDatabaseTypeProperties> typeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    typeProperties = LinkConnectionSourceDatabaseTypeProperties.DeserializeLinkConnectionSourceDatabaseTypeProperties(property.Value);
                    continue;
                }
            }
            return new LinkConnectionSourceDatabase(linkedService.Value, typeProperties.Value);
        }

        internal partial class LinkConnectionSourceDatabaseConverter : JsonConverter<LinkConnectionSourceDatabase>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionSourceDatabase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkConnectionSourceDatabase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionSourceDatabase(document.RootElement);
            }
        }
    }
}
