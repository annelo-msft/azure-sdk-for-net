// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary> Returns the requested Docker multi-arch-manifest file. </summary>
    public partial class DockerManifestList : RepositoryItemManifest
    {
        /// <summary> Initializes a new instance of DockerManifestList. </summary>
        public DockerManifestList()
        {
            Manifests = new ChangeTrackingList<ManifestListAttributes>();
        }

        /// <summary> Initializes a new instance of DockerManifestList. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="manifests"> List of V2 image layer information. </param>
        internal DockerManifestList(int schemaVersion, string mediaType, IList<ManifestListAttributes> manifests) : base(schemaVersion)
        {
            MediaType = mediaType;
            Manifests = manifests;
        }
        /// <summary> List of V2 image layer information. </summary>
        public IList<ManifestListAttributes> Manifests { get; }
    }
}
