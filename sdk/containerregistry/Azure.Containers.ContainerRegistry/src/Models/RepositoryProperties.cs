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
        public int ImageCount { get; }

        [CodeGenMember("CreatedTime")]
        public DateTimeOffset CreatedTime { get; }
        
        [CodeGenMember("LastUpdateTime")]
        public DateTimeOffset LastUpdateTime { get; }
        
        [CodeGenMember("TagCount")]
        public int TagCount { get; }
    }
}
