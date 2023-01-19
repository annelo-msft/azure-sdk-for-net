// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary>
    /// The result from downloading an artifact manifest.
    /// </summary>
    public class DownloadManifestResult
    {
        internal DownloadManifestResult(string digest, OciManifest manifest, Stream manifestStream)
        {
            Digest = digest;
            Manifest = manifest;
            Content = content;
        }

        /// <summary>
        /// The manifest's digest, calculated by the registry.
        /// </summary>
        public string Digest { get; }

        /// <summary>
        /// The downloaded manifest, or null if the manifest has an unsupported Content-Type.
        /// </summary>
        public ArtifactManifest Manifest { get; }

        /// <summary>
        /// The serialized content that was downloaded.
        /// </summary>
        public BinaryData Content { get; }
    }
}
