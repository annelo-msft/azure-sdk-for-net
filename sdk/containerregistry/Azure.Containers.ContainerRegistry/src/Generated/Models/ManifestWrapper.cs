// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Containers.ContainerRegistry.Specialized;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested manifest file. </summary>
    internal partial class ManifestWrapper : Manifest
    {
        /// <summary> Initializes a new instance of ManifestWrapper. </summary>
        public ManifestWrapper()
        {
            Manifests = new ChangeTrackingList<ManifestListAttributes>();
            Layers = new ChangeTrackingList<ArtifactBlobDescriptor>();
            FsLayers = new ChangeTrackingList<FsLayer>();
            History = new ChangeTrackingList<History>();
            Signatures = new ChangeTrackingList<ImageSignature>();
        }

        /// <summary> Initializes a new instance of ManifestWrapper. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="manifests"> (ManifestList, OCIIndex) List of V2 image layer information. </param>
        /// <param name="config"> (V2, OCI) Image config descriptor. </param>
        /// <param name="layers"> (V2, OCI) List of V2 image layer information. </param>
        /// <param name="annotations"> (OCI, OCIIndex) Additional metadata. </param>
        /// <param name="architecture"> (V1) CPU architecture. </param>
        /// <param name="name"> (V1) Image name. </param>
        /// <param name="tag"> (V1) Image tag. </param>
        /// <param name="fsLayers"> (V1) List of layer information. </param>
        /// <param name="history"> (V1) Image history. </param>
        /// <param name="signatures"> (V1) Image signature. </param>
        internal ManifestWrapper(int? schemaVersion, string mediaType, IList<ManifestListAttributes> manifests, ArtifactBlobDescriptor config, IList<ArtifactBlobDescriptor> layers, Annotations annotations, string architecture, string name, string tag, IList<FsLayer> fsLayers, IList<History> history, IList<ImageSignature> signatures) : base(schemaVersion)
        {
            MediaType = mediaType;
            Manifests = manifests;
            Config = config;
            Layers = layers;
            Annotations = annotations;
            Architecture = architecture;
            Name = name;
            Tag = tag;
            FsLayers = fsLayers;
            History = history;
            Signatures = signatures;
        }

        /// <summary> Media type for this Manifest. </summary>
        public string MediaType { get; set; }
        /// <summary> (ManifestList, OCIIndex) List of V2 image layer information. </summary>
        public IList<ManifestListAttributes> Manifests { get; }
        /// <summary> (V2, OCI) Image config descriptor. </summary>
        public ArtifactBlobDescriptor Config { get; set; }
        /// <summary> (V2, OCI) List of V2 image layer information. </summary>
        public IList<ArtifactBlobDescriptor> Layers { get; }
        /// <summary> (OCI, OCIIndex) Additional metadata. </summary>
        public Annotations Annotations { get; set; }
        /// <summary> (V1) CPU architecture. </summary>
        public string Architecture { get; set; }
        /// <summary> (V1) Image name. </summary>
        public string Name { get; set; }
        /// <summary> (V1) Image tag. </summary>
        public string Tag { get; set; }
        /// <summary> (V1) List of layer information. </summary>
        public IList<FsLayer> FsLayers { get; }
        /// <summary> (V1) Image history. </summary>
        public IList<History> History { get; }
        /// <summary> (V1) Image signature. </summary>
        public IList<ImageSignature> Signatures { get; }
    }
}
