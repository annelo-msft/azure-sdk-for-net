// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    [CodeGenModel("RepositoryAttributes")]
    public partial class RepositoryProperties
    {
        [CodeGenMember("ImageName")]
        public string Name { get; }

        [CodeGenMember("ChangeableAttributes")]
        public ContentPermissions Permissions { get; }

        [CodeGenMember("ManifestCount")]
        public int? ArtifactCount { get; }
    }
}
