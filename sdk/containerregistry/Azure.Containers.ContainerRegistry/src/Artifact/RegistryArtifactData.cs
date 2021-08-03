// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary>
    /// </summary>
    public class RegistryArtifactData
    {
        /// <summary>
        /// </summary>
        public ArtifactManifestProperties ManifestData { get; }

        /// <summary>
        /// </summary>
        public ArtifactTagProperties TagData { get; }
    }
}
