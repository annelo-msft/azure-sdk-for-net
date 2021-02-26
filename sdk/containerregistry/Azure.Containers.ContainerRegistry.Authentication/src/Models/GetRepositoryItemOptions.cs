﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class GetRepositoryItemOptions
    {
        public GetRepositoryItemOptions(RepositoryItemOrderBy orderBy)
        {
            OrderBy = orderBy;
        }
        
        public RepositoryItemOrderBy OrderBy { get; }
    }
}
