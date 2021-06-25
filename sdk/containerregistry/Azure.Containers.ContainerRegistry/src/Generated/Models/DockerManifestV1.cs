// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    /// <summary> Returns the requested V1 manifest file. </summary>
    internal partial class DockerManifestV1 : ImageManifest
    {
        /// <summary> Initializes a new instance of DockerManifestV1. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        internal DockerManifestV1(int schemaVersion) : base(schemaVersion)
        {
            FsLayers = new ChangeTrackingList<DockerManifestV1FsLayer>();
            History = new ChangeTrackingList<DockerManifestV1History>();
            Signatures = new ChangeTrackingList<DockerManifestV1ImageSignature>();
            MediaType = "application/vnd.oci.image.manifest.v1+json";
        }

        /// <summary> Initializes a new instance of DockerManifestV1. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="cpuArchitecture"> CPU architecture. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="tag"> Image tag. </param>
        /// <param name="fsLayers"> List of layer information. </param>
        /// <param name="history"> Image history. </param>
        /// <param name="signatures"> Image signature. </param>
        internal DockerManifestV1(int schemaVersion, string mediaType, string cpuArchitecture, string name, string tag, IReadOnlyList<DockerManifestV1FsLayer> fsLayers, IReadOnlyList<DockerManifestV1History> history, IReadOnlyList<DockerManifestV1ImageSignature> signatures) : base(schemaVersion, mediaType)
        {
            CpuArchitecture = cpuArchitecture;
            Name = name;
            Tag = tag;
            FsLayers = fsLayers;
            History = history;
            Signatures = signatures;
            MediaType = mediaType ?? "application/vnd.oci.image.manifest.v1+json";
        }
    }
}
