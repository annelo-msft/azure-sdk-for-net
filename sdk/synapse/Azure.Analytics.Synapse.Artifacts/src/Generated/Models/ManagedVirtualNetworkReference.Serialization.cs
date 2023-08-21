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
    [JsonConverter(typeof(ManagedVirtualNetworkReferenceConverter))]
    public partial class ManagedVirtualNetworkReference : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteStringValue(ReferenceName);
            writer.WriteEndObject();
        }

        internal static ManagedVirtualNetworkReference DeserializeManagedVirtualNetworkReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedVirtualNetworkReferenceType type = default;
            string referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ManagedVirtualNetworkReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedVirtualNetworkReference(type, referenceName);
        }

        internal partial class ManagedVirtualNetworkReferenceConverter : JsonConverter<ManagedVirtualNetworkReference>
        {
            public override void Write(Utf8JsonWriter writer, ManagedVirtualNetworkReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ManagedVirtualNetworkReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeManagedVirtualNetworkReference(document.RootElement);
            }
        }
    }
}
