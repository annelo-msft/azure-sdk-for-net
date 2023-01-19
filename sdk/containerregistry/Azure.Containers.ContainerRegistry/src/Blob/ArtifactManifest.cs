// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    [CodeGenModel("Manifest")]
    [CodeGenSuppress("DeserializeArtifactManifest", typeof(JsonElement))]
    public abstract partial class ArtifactManifest
    {
    }
}
