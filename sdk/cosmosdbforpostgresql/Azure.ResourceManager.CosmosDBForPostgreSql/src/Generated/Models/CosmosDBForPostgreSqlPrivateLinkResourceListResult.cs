// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class CosmosDBForPostgreSqlPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlPrivateLinkResourceListResult. </summary>
        internal CosmosDBForPostgreSqlPrivateLinkResourceListResult()
        {
            Value = new Core.ChangeTrackingList<CosmosDBForPostgreSqlPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal CosmosDBForPostgreSqlPrivateLinkResourceListResult(IReadOnlyList<CosmosDBForPostgreSqlPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<CosmosDBForPostgreSqlPrivateLinkResourceData> Value { get; }
    }
}
