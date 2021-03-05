// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class GetRegistryArtifactOptions
    {
        public GetRegistryArtifactOptions(RegistryArtifactOrderBy orderBy)
        {
            OrderBy = orderBy;
        }
        
        public RegistryArtifactOrderBy OrderBy { get; }
    }
}
