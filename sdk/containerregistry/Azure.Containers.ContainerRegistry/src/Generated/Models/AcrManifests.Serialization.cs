// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    public partial class AcrManifests
    {
        internal static AcrManifests DeserializeAcrManifests(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> imageName = default;
            Optional<IReadOnlyList<ManifestAttributesBase>> manifests = default;
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
                if (property.NameEquals("manifests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManifestAttributesBase> array = new List<ManifestAttributesBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestAttributesBase.DeserializeManifestAttributesBase(item));
                    }
                    manifests = array;
                    continue;
                }
            }
            return new AcrManifests(registry.Value, imageName.Value, Optional.ToList(manifests));
        }
    }
}
