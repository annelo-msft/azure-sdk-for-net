// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing the ResourcePool data model.
    /// Define the resourcePool.
    /// </summary>
    public partial class ResourcePoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ResourcePoolData. </summary>
        /// <param name="location"> The location. </param>
        public ResourcePoolData(AzureLocation location) : base(location)
        {
            Statuses = new Core.ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of ResourcePoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this resource pool resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the resource pool. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource pool. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the resource pool. </param>
        /// <param name="cpuSharesLevel">
        /// Gets or sets CPUSharesLevel which specifies the CPU allocation level for this pool.
        /// This property is used in relative allocation between resource consumers.
        /// </param>
        /// <param name="cpuReservationMHz">
        /// Gets or sets CPUReservationMHz which specifies the CPU size in MHz that is guaranteed
        /// to be available.
        /// </param>
        /// <param name="cpuLimitMHz">
        /// Gets or sets CPULimitMHz which specifies a CPU usage limit in MHz.
        /// Utilization will not exceed this limit even if there are available resources.
        /// </param>
        /// <param name="memSharesLevel">
        /// Gets or sets CPUSharesLevel which specifies the memory allocation level for this pool.
        /// This property is used in relative allocation between resource consumers.
        /// </param>
        /// <param name="memReservationMB">
        /// Gets or sets MemReservationMB which specifies the guaranteed available memory in
        /// megabytes.
        /// </param>
        /// <param name="memLimitMB">
        /// Gets or sets MemLimitMB specifies a memory usage limit in megabytes.
        /// Utilization will not exceed the specified limit even if there are available resources.
        /// </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal ResourcePoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, string cpuSharesLevel, long? cpuReservationMHz, long? cpuLimitMHz, string memSharesLevel, long? memReservationMB, long? memLimitMB, string customResourceName, IReadOnlyList<ResourceStatus> statuses, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            CpuSharesLevel = cpuSharesLevel;
            CpuReservationMHz = cpuReservationMHz;
            CpuLimitMHz = cpuLimitMHz;
            MemSharesLevel = memSharesLevel;
            MemReservationMB = memReservationMB;
            MemLimitMB = memLimitMB;
            CustomResourceName = customResourceName;
            Statuses = statuses;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this resource pool resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the resource pool. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the resource pool. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the resource pool. </summary>
        public string MoName { get; }
        /// <summary>
        /// Gets or sets CPUSharesLevel which specifies the CPU allocation level for this pool.
        /// This property is used in relative allocation between resource consumers.
        /// </summary>
        public string CpuSharesLevel { get; }
        /// <summary>
        /// Gets or sets CPUReservationMHz which specifies the CPU size in MHz that is guaranteed
        /// to be available.
        /// </summary>
        public long? CpuReservationMHz { get; }
        /// <summary>
        /// Gets or sets CPULimitMHz which specifies a CPU usage limit in MHz.
        /// Utilization will not exceed this limit even if there are available resources.
        /// </summary>
        public long? CpuLimitMHz { get; }
        /// <summary>
        /// Gets or sets CPUSharesLevel which specifies the memory allocation level for this pool.
        /// This property is used in relative allocation between resource consumers.
        /// </summary>
        public string MemSharesLevel { get; }
        /// <summary>
        /// Gets or sets MemReservationMB which specifies the guaranteed available memory in
        /// megabytes.
        /// </summary>
        public long? MemReservationMB { get; }
        /// <summary>
        /// Gets or sets MemLimitMB specifies a memory usage limit in megabytes.
        /// Utilization will not exceed the specified limit even if there are available resources.
        /// </summary>
        public long? MemLimitMB { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
