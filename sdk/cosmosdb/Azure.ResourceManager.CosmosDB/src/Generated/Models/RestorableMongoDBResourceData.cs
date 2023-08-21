// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specific Databases to restore. </summary>
    public partial class RestorableMongoDBResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of RestorableMongoDBResourceData. </summary>
        internal RestorableMongoDBResourceData()
        {
            CollectionNames = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RestorableMongoDBResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseName"> The name of the database available for restore. </param>
        /// <param name="collectionNames"> The names of the collections available for restore. </param>
        internal RestorableMongoDBResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string databaseName, IReadOnlyList<string> collectionNames) : base(id, name, resourceType, systemData)
        {
            DatabaseName = databaseName;
            CollectionNames = collectionNames;
        }

        /// <summary> The name of the database available for restore. </summary>
        public string DatabaseName { get; }
        /// <summary> The names of the collections available for restore. </summary>
        public IReadOnlyList<string> CollectionNames { get; }
    }
}
