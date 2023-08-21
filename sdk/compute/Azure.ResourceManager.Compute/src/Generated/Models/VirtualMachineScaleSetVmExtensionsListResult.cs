// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VMSS VM Extension operation response. </summary>
    internal partial class VirtualMachineScaleSetVmExtensionsListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmExtensionsListResult. </summary>
        internal VirtualMachineScaleSetVmExtensionsListResult()
        {
            Value = new Core.ChangeTrackingList<VirtualMachineScaleSetVmExtensionData>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmExtensionsListResult. </summary>
        /// <param name="value"> The list of VMSS VM extensions. </param>
        internal VirtualMachineScaleSetVmExtensionsListResult(IReadOnlyList<VirtualMachineScaleSetVmExtensionData> value)
        {
            Value = value;
        }

        /// <summary> The list of VMSS VM extensions. </summary>
        public IReadOnlyList<VirtualMachineScaleSetVmExtensionData> Value { get; }
    }
}
