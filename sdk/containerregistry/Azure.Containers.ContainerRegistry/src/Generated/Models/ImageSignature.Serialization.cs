// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    internal partial class ImageSignature : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Header))
            {
                writer.WritePropertyName("header");
                writer.WriteObjectValue(Header);
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature");
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(Protected))
            {
                writer.WritePropertyName("protected");
                writer.WriteStringValue(Protected);
            }
            writer.WriteEndObject();
        }

        internal static ImageSignature DeserializeImageSignature(JsonElement element)
        {
            Optional<JWK> header = default;
            Optional<string> signature = default;
            Optional<string> @protected = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("header"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    header = JWK.DeserializeJWK(property.Value);
                    continue;
                }
                if (property.NameEquals("signature"))
                {
                    signature = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protected"))
                {
                    @protected = property.Value.GetString();
                    continue;
                }
            }
            return new ImageSignature(header.Value, signature.Value, @protected.Value);
        }
    }
}
