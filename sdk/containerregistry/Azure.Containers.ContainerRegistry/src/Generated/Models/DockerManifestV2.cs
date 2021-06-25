// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    /// <summary> Returns the requested Docker V2 Manifest file. </summary>
    internal partial class DockerManifestV2 : ImageManifest
    {
        /// <summary> Initializes a new instance of DockerManifestV2. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        internal DockerManifestV2(int schemaVersion) : base(schemaVersion)
        {
            Layers = new ChangeTrackingList<ContentDescriptor>();
            MediaType = "application/vnd.docker.distribution.manifest.v2+json";
        }

        /// <summary> Initializes a new instance of DockerManifestV2. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="configDescriptor"> V2 image config descriptor. </param>
        /// <param name="layers"> List of V2 image layer information. </param>
        internal DockerManifestV2(int schemaVersion, string mediaType, ContentDescriptor configDescriptor, IReadOnlyList<ContentDescriptor> layers) : base(schemaVersion, mediaType)
        {
            ConfigDescriptor = configDescriptor;
            Layers = layers;
            MediaType = mediaType ?? "application/vnd.docker.distribution.manifest.v2+json";
        }
        /// <summary> List of V2 image layer information. </summary>
        public IReadOnlyList<ContentDescriptor> Layers { get; }
    }
}
