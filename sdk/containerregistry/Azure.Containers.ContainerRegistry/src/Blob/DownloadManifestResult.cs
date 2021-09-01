// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary>
    /// </summary>
    public class DownloadManifestResult
    {
        internal DownloadManifestResult(string digest, ArtifactManifest manifest, ManifestMediaType mediaType)
        {
            Digest = digest;
            Manifest = manifest;
            MediaType = mediaType;
        }

        /// <summary>
        /// </summary>
        public string Digest { get; }

        /// <summary>
        /// </summary>
        public ArtifactManifest Manifest { get; }

        /// <summary>
        /// </summary>
        public ManifestMediaType MediaType { get; }
    }
}
