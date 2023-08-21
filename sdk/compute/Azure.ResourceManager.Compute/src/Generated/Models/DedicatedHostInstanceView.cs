// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a dedicated host. </summary>
    public partial class DedicatedHostInstanceView
    {
        /// <summary> Initializes a new instance of DedicatedHostInstanceView. </summary>
        internal DedicatedHostInstanceView()
        {
            Statuses = new Core.ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of DedicatedHostInstanceView. </summary>
        /// <param name="assetId"> Specifies the unique id of the dedicated physical machine on which the dedicated host resides. </param>
        /// <param name="availableCapacity"> Unutilized capacity of the dedicated host. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal DedicatedHostInstanceView(string assetId, DedicatedHostAvailableCapacity availableCapacity, IReadOnlyList<InstanceViewStatus> statuses)
        {
            AssetId = assetId;
            AvailableCapacity = availableCapacity;
            Statuses = statuses;
        }

        /// <summary> Specifies the unique id of the dedicated physical machine on which the dedicated host resides. </summary>
        public string AssetId { get; }
        /// <summary> Unutilized capacity of the dedicated host. </summary>
        internal DedicatedHostAvailableCapacity AvailableCapacity { get; }
        /// <summary> The unutilized capacity of the dedicated host represented in terms of each VM size that is allowed to be deployed to the dedicated host. </summary>
        public IReadOnlyList<DedicatedHostAllocatableVm> AvailableCapacityAllocatableVms
        {
            get => AvailableCapacity?.AllocatableVms;
        }

        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
