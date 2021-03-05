// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class GetTagOptions
    {
        public GetTagOptions(TagOrderBy orderBy)
        {
            OrderBy = orderBy;
        }

        // TODO: What OrderBy syntax is supported by the service?  Does it support sending multiple fields?
        // Is it basically OData? ... looks like it's not OData.
        // Reference: https://github.com/Azure/acr-cli/pull/72
        // https://docs.microsoft.com/en-us/rest/api/azure/devops/serviceendpoint/types/list?view=azure-devops-rest-6.0
        public TagOrderBy OrderBy { get; }
    }
}
