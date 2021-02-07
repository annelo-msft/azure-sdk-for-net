// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    public partial class RepositoryAttributes
    {
        public DateTime CreatedTime { get; }

        public DateTime LastUpdateTime { get; }
        
        // TODO: have RepositoryPermissions and TagPermissions separately?
        [CodeGenMember("ChangeableAttributes")]
        public ContentPermissions Permissions { get; }
    }
}
