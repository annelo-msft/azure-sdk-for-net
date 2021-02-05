// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    /// <summary> Manifest attributes. </summary>
    public class ManifestMetadata
    {
        /// <summary> Initializes a new instance of AcrManifests. </summary>
        internal ManifestMetadata()
        {
        }

        // TODO: do we need registry and imagename, since callers should already have this if they're making this call?
        ///// <summary> Registry name. </summary>
        //public string Registry { get; }

        ///// <summary> Image name. </summary>
        //public string ImageName { get; }

        /// <summary> Manifest. </summary>
        public string Digest { get; }

        // TODO: does this apply to OCI and helm charts as well?  Call it image instead of artifact?
        /// <summary> Image size. </summary>
        public long? ArtifactSize { get; }

        /// <summary> Created time. </summary>
        public string CreatedTime { get; }

        /// <summary> Last update time. </summary>
        public string LastUpdateTime { get; }

        /// <summary> CPU architecture. </summary>
        public string CpuArchitecture { get; }

        /// <summary> Operating system. </summary>
        public string OperatingSystem { get; }

        // TODO: extensible enum of poptions here?
        /// <summary> Media type. </summary>
        public string MediaType { get; }

        // TODO: extensible enum of options here?
        /// <summary> Config blob media type. </summary>
        public string ConfigMediaType { get; }

        // TODO: Will we have a strong type for tag or will it be string?
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }

        /// <summary> Changeable attributes. </summary>
        public ArtifactPermissions Permissions { get; }
    }
}
