// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class GetItemsOptions
    {
        public GetItemsOptions(RegistryItemOrderBy orderBy)
        {
            OrderBy = orderBy;
        }
        
        public RegistryItemOrderBy OrderBy { get; }
    }
}
