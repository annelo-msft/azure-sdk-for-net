// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </summary>
    internal partial class CosmosDBUniqueKeyPolicy
    {
        /// <summary> Initializes a new instance of CosmosDBUniqueKeyPolicy. </summary>
        public CosmosDBUniqueKeyPolicy()
        {
            UniqueKeys = new Core.ChangeTrackingList<CosmosDBUniqueKey>();
        }

        /// <summary> Initializes a new instance of CosmosDBUniqueKeyPolicy. </summary>
        /// <param name="uniqueKeys"> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </param>
        internal CosmosDBUniqueKeyPolicy(IList<CosmosDBUniqueKey> uniqueKeys)
        {
            UniqueKeys = uniqueKeys;
        }

        /// <summary> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </summary>
        public IList<CosmosDBUniqueKey> UniqueKeys { get; }
    }
}
