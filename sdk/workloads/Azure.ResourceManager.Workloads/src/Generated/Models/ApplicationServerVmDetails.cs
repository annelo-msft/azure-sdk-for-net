// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The Application Server VM Details. </summary>
    public partial class ApplicationServerVmDetails
    {
        /// <summary> Initializes a new instance of ApplicationServerVmDetails. </summary>
        internal ApplicationServerVmDetails()
        {
            StorageDetails = new Core.ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of ApplicationServerVmDetails. </summary>
        /// <param name="virtualMachineType"> Defines the type of application server VM. </param>
        /// <param name="virtualMachineId"></param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        internal ApplicationServerVmDetails(ApplicationServerVirtualMachineType? virtualMachineType, ResourceIdentifier virtualMachineId, IReadOnlyList<SubResource> storageDetails)
        {
            VirtualMachineType = virtualMachineType;
            VirtualMachineId = virtualMachineId;
            StorageDetails = storageDetails;
        }

        /// <summary> Defines the type of application server VM. </summary>
        public ApplicationServerVirtualMachineType? VirtualMachineType { get; }
        /// <summary> Gets the virtual machine id. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage. </summary>
        public IReadOnlyList<SubResource> StorageDetails { get; }
    }
}
