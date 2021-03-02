// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage
{
    [CodeGenModel("Manifest")]
    public partial class RegistryItemManifest
    {
        internal RegistryItemManifest() { }

        internal string Digest { get; set; }

        public ManifestMediaType MediaType { get; set; }

        /// <summary> Schema version. </summary>
        public int SchemaVersion { get; set; }
    }
}
