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
        public ContentProperties ModifiableProperties { get; }

        [CodeGenMember("ManifestCount")]
        public int RegistryArtifactCount { get; }

        [CodeGenMember("CreatedTime")]
        public DateTimeOffset CreatedOn { get; }
        
        [CodeGenMember("LastUpdateTime")]
        public DateTimeOffset LastUpdatedOn { get; }
        
        [CodeGenMember("TagCount")]
        public int TagCount { get; }
    }
}
