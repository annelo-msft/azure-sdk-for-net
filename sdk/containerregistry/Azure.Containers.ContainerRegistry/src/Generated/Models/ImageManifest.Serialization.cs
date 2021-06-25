// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    internal partial class ImageManifest
    {
        internal static ImageManifest DeserializeImageManifest(JsonElement element)
        {
            if (element.TryGetProperty("mediaType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ManifestWrapper": return CombinedManifest.DeserializeCombinedManifest(element);
                    case "application/vnd.docker.distribution.manifest.list.v2+json": return DockerManifestList.DeserializeDockerManifestList(element);
                    case "application/vnd.docker.distribution.manifest.v2+json": return DockerManifestV2.DeserializeDockerManifestV2(element);
                    case "application/vnd.oci.image.index.v1+json": return OciIndex.DeserializeOciIndex(element);
                    case "application/vnd.oci.image.manifest.v1+json": return DockerManifestV1.DeserializeDockerManifestV1(element);
                }
            }
            int schemaVersion = default;
            string mediaType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaVersion"))
                {
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
            }
            return new ImageManifest(schemaVersion, mediaType);
        }
    }
}
