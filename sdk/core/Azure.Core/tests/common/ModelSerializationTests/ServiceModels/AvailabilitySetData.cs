// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core.Serialization;
using Azure.Core.Tests.ResourceManager.Compute.Models;
using Azure.Core.Tests.ResourceManager.Models;
using Azure.Core.Tests.ResourceManager.Resources.Models;

namespace Azure.Core.Tests.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the AvailabilitySet data model.
    /// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to an availability set at creation time. An existing VM cannot be added to an availability set.
    /// </summary>
    public partial class AvailabilitySetData : TrackedResourceData
    {
        internal AvailabilitySetData() { }

        //public static implicit operator RequestContent(AvailabilitySetData availabilitySetData)
        //{
        //    if (availabilitySetData is null)
        //    {
        //        return null;
        //    }

        //    return RequestContent.Create(availabilitySetData, ModelSerializerOptions.DefaultWireOptions);
        //}

        public static explicit operator AvailabilitySetData(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            using JsonDocument jsonDocument = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailabilitySetData(jsonDocument.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="location"> The location. </param>
        public AvailabilitySetData(AzureLocation location) : base(location)
        {
            VirtualMachines = new ChangeTrackingList<WritableSubResource>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use 'Aligned' for virtual machines with managed disks and 'Classic' for virtual machines with unmanaged disks. Default value is 'Classic'. </param>
        /// <param name="platformUpdateDomainCount"> Update Domain count. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the availability set. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the availability set should be assigned to. Minimum api-version: 2018-04-01. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal AvailabilitySetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ComputeSku sku, int? platformUpdateDomainCount, int? platformFaultDomainCount, IList<WritableSubResource> virtualMachines, WritableSubResource proximityPlacementGroup, IReadOnlyList<InstanceViewStatus> statuses) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            ProximityPlacementGroup = proximityPlacementGroup;
            Statuses = statuses;
        }

        /// <summary> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use 'Aligned' for virtual machines with managed disks and 'Classic' for virtual machines with unmanaged disks. Default value is 'Classic'. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> Update Domain count. </summary>
        public int? PlatformUpdateDomainCount { get; set; }
        /// <summary> Fault Domain count. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> A list of references to all virtual machines in the availability set. </summary>
        public IList<WritableSubResource> VirtualMachines { get; }
        /// <summary> Specifies information about the proximity placement group that the availability set should be assigned to. Minimum api-version: 2018-04-01. </summary>
        internal WritableSubResource ProximityPlacementGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProximityPlacementGroupId
        {
            get => ProximityPlacementGroup is null ? default : ProximityPlacementGroup.Id;
            set
            {
                if (ProximityPlacementGroup is null)
                    ProximityPlacementGroup = new WritableSubResource();
                ProximityPlacementGroup.Id = value;
            }
        }

        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
