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
    [JsonConverter(typeof(EncryptionDetailsConverter))]
    public partial class EncryptionDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Cmk))
            {
                writer.WritePropertyName("cmk"u8);
                writer.WriteObjectValue(Cmk);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionDetails DeserializeEncryptionDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> doubleEncryptionEnabled = default;
            Core.Optional<CustomerManagedKeyDetails> cmk = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("doubleEncryptionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    doubleEncryptionEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cmk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cmk = CustomerManagedKeyDetails.DeserializeCustomerManagedKeyDetails(property.Value);
                    continue;
                }
            }
            return new EncryptionDetails(Core.Optional.ToNullable(doubleEncryptionEnabled), cmk.Value);
        }

        internal partial class EncryptionDetailsConverter : JsonConverter<EncryptionDetails>
        {
            public override void Write(Utf8JsonWriter writer, EncryptionDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EncryptionDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEncryptionDetails(document.RootElement);
            }
        }
    }
}
