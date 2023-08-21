// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class ArtifactManifestPlatform
    {
        internal static ArtifactManifestPlatform DeserializeArtifactManifestPlatform(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string digest = default;
            Core.Optional<ArtifactArchitecture> architecture = default;
            Core.Optional<ArtifactOperatingSystem> os = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    architecture = new ArtifactArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("os"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    os = new ArtifactOperatingSystem(property.Value.GetString());
                    continue;
                }
            }
            return new ArtifactManifestPlatform(digest, Core.Optional.ToNullable(architecture), Core.Optional.ToNullable(os));
        }
    }
}
