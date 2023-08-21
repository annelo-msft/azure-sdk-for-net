// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list usage request. </summary>
    internal partial class CosmosDBUsagesResult
    {
        /// <summary> Initializes a new instance of CosmosDBUsagesResult. </summary>
        internal CosmosDBUsagesResult()
        {
            Value = new Core.ChangeTrackingList<CosmosDBBaseUsage>();
        }

        /// <summary> Initializes a new instance of CosmosDBUsagesResult. </summary>
        /// <param name="value"> The list of usages for the database. A usage is a point in time metric. </param>
        internal CosmosDBUsagesResult(IReadOnlyList<CosmosDBBaseUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of usages for the database. A usage is a point in time metric. </summary>
        public IReadOnlyList<CosmosDBBaseUsage> Value { get; }
    }
}
