// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraClusterPublicStatusDataCentersItem. </summary>
    public partial class CassandraClusterPublicStatusDataCentersItem
    {
        /// <summary> Initializes a new instance of CassandraClusterPublicStatusDataCentersItem. </summary>
        internal CassandraClusterPublicStatusDataCentersItem()
        {
            SeedNodes = new Core.ChangeTrackingList<string>();
            Nodes = new Core.ChangeTrackingList<CassandraClusterDataCenterNodeItem>();
        }

        /// <summary> Initializes a new instance of CassandraClusterPublicStatusDataCentersItem. </summary>
        /// <param name="name"> The name of this Datacenter. </param>
        /// <param name="seedNodes"> A list of all seed nodes in the cluster, managed and unmanaged. </param>
        /// <param name="nodes"></param>
        internal CassandraClusterPublicStatusDataCentersItem(string name, IReadOnlyList<string> seedNodes, IReadOnlyList<CassandraClusterDataCenterNodeItem> nodes)
        {
            Name = name;
            SeedNodes = seedNodes;
            Nodes = nodes;
        }

        /// <summary> The name of this Datacenter. </summary>
        public string Name { get; }
        /// <summary> A list of all seed nodes in the cluster, managed and unmanaged. </summary>
        public IReadOnlyList<string> SeedNodes { get; }
        /// <summary> Gets the nodes. </summary>
        public IReadOnlyList<CassandraClusterDataCenterNodeItem> Nodes { get; }
    }
}
