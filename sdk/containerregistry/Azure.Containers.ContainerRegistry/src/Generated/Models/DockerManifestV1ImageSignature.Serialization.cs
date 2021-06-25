// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    internal partial class DockerManifestV1ImageSignature
    {
        internal static DockerManifestV1ImageSignature DeserializeDockerManifestV1ImageSignature(JsonElement element)
        {
            Optional<DockerManifestV1Jwk> header = default;
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
                    header = DockerManifestV1Jwk.DeserializeDockerManifestV1Jwk(property.Value);
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
            return new DockerManifestV1ImageSignature(header.Value, signature.Value, @protected.Value);
        }
    }
}
