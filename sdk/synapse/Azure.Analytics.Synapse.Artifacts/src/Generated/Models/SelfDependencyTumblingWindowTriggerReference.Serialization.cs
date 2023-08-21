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
    [JsonConverter(typeof(SelfDependencyTumblingWindowTriggerReferenceConverter))]
    public partial class SelfDependencyTumblingWindowTriggerReference : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("offset"u8);
            writer.WriteStringValue(Offset);
            if (Core.Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SelfDependencyTumblingWindowTriggerReference DeserializeSelfDependencyTumblingWindowTriggerReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offset = default;
            Core.Optional<string> size = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SelfDependencyTumblingWindowTriggerReference(type, offset, size.Value);
        }

        internal partial class SelfDependencyTumblingWindowTriggerReferenceConverter : JsonConverter<SelfDependencyTumblingWindowTriggerReference>
        {
            public override void Write(Utf8JsonWriter writer, SelfDependencyTumblingWindowTriggerReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SelfDependencyTumblingWindowTriggerReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSelfDependencyTumblingWindowTriggerReference(document.RootElement);
            }
        }
    }
}
