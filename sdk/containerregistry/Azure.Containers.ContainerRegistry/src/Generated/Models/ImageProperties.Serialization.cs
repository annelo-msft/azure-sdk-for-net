// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class ImageProperties
    {
        internal static ImageProperties DeserializeImageProperties(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> imageName = default;
            Optional<ManifestAttributesBase> manifest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    manifest = ManifestAttributesBase.DeserializeManifestAttributesBase(property.Value);
                    continue;
                }
            }
            return new ImageProperties(registry.Value, imageName.Value, manifest.Value);
        }
    }
}
