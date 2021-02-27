// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage
{
    [CodeGenModel("Manifest")]
    public partial class RepositoryItemManifest
    {
        internal RepositoryItemManifest() { }

        internal string Digest { get; set; }

        public ManifestMediaType MediaType { get; set; }

        /// <summary> Schema version. </summary>
        public int SchemaVersion { get; set; }

        public DockerManifestV1 AsDockerManifestV1()
        {
            throw new NotImplementedException();
        }

        public DockerManifestV2 AsDockerManifestV2()
        {
            throw new NotImplementedException();
        }

        public DockerManifestList AsDockerManifestList()
        {
            throw new NotImplementedException();
        }

        public OciIndex AsOciIndex()
        {
            throw new NotImplementedException();
        }

        public OciManifest AsOciManifest()
        {
            throw new NotImplementedException();
        }
    }
}
