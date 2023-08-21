// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class GalleryIdentifier : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static GalleryIdentifier DeserializeGalleryIdentifier(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> uniqueName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueName"u8))
                {
                    uniqueName = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryIdentifier(uniqueName.Value);
        }
    }
}
