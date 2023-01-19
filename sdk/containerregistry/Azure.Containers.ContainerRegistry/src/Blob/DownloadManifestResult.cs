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
        internal DownloadManifestResult(string digest, string mediaType, BinaryData content)
        {
            Digest = digest;
            MediaType = mediaType;
            Content = content;
        }

        /// <summary>
        /// The manifest's digest, calculated by the registry.
        /// </summary>
        public string Digest { get; }

        /// <summary>
        /// Gets the manifest's MediaType, returned in the Content-Type header.
        /// </summary>
        public string MediaType { get; }

        /// <summary>
        /// The serialized content that was downloaded.
        /// </summary>
        public BinaryData Content { get; }
    }
}
