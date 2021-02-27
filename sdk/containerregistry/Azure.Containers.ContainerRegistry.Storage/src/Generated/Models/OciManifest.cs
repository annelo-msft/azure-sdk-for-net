// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary> Returns the requested OCI Manifest file. </summary>
    public partial class OciManifest : RepositoryItemManifest
    {
        /// <summary> Initializes a new instance of OciManifest. </summary>
        public OciManifest()
        {
            Layers = new ChangeTrackingList<ContentDescriptor>();
        }

        /// <summary> Initializes a new instance of OciManifest. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="configDescriptor"> V2 image config descriptor. </param>
        /// <param name="layers"> List of V2 image layer information. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal OciManifest(int schemaVersion, ContentDescriptor configDescriptor, IList<ContentDescriptor> layers, OciManifestAnnotations annotations) : base(schemaVersion)
        {
            ConfigDescriptor = configDescriptor;
            Layers = layers;
            Annotations = annotations;
        }
        /// <summary> List of V2 image layer information. </summary>
        public IList<ContentDescriptor> Layers { get; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public OciManifestAnnotations Annotations { get; set; }
    }
}
