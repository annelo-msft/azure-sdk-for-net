// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Template.Models
{
    /// <summary> Manifest attributes. </summary>
    public partial class AcrManifests
    {
        /// <summary> Initializes a new instance of AcrManifests. </summary>
        internal AcrManifests()
        {
            ManifestsAttributes = new ChangeTrackingList<ManifestAttributesBase>();
        }

        /// <summary> Initializes a new instance of AcrManifests. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="imageName"> Image name. </param>
        /// <param name="manifestsAttributes"> List of manifests. </param>
        internal AcrManifests(string registry, string imageName, IReadOnlyList<ManifestAttributesBase> manifestsAttributes)
        {
            Registry = registry;
            ImageName = imageName;
            ManifestsAttributes = manifestsAttributes;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image name. </summary>
        public string ImageName { get; }
        /// <summary> List of manifests. </summary>
        public IReadOnlyList<ManifestAttributesBase> ManifestsAttributes { get; }
    }
}
