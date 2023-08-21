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
    [JsonConverter(typeof(NotebookResourceConverter))]
    public partial class NotebookResource : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static NotebookResource DeserializeNotebookResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            string name = default;
            Core.Optional<string> type = default;
            Core.Optional<string> etag = default;
            Notebook properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = Notebook.DeserializeNotebook(property.Value);
                    continue;
                }
            }
            return new NotebookResource(id.Value, name, type.Value, etag.Value, properties);
        }

        internal partial class NotebookResourceConverter : JsonConverter<NotebookResource>
        {
            public override void Write(Utf8JsonWriter writer, NotebookResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookResource(document.RootElement);
            }
        }
    }
}
