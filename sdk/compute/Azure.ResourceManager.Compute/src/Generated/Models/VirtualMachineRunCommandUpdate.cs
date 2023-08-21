// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine run command. </summary>
    public partial class VirtualMachineRunCommandUpdate : ComputeResourcePatch
    {
        /// <summary> Initializes a new instance of VirtualMachineRunCommandUpdate. </summary>
        public VirtualMachineRunCommandUpdate()
        {
            Parameters = new Core.ChangeTrackingList<RunCommandInputParameter>();
            ProtectedParameters = new Core.ChangeTrackingList<RunCommandInputParameter>();
        }

        /// <summary> The source of the run command script. </summary>
        public VirtualMachineRunCommandScriptSource Source { get; set; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> Parameters { get; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> ProtectedParameters { get; }
        /// <summary> Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete. </summary>
        public bool? AsyncExecution { get; set; }
        /// <summary> Specifies the user account on the VM when executing the run command. </summary>
        public string RunAsUser { get; set; }
        /// <summary> Specifies the user account password on the VM when executing the run command. </summary>
        public string RunAsPassword { get; set; }
        /// <summary> The timeout in seconds to execute the run command. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> Specifies the Azure storage blob where script output stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer outputBlobManagedIdentity parameter. </summary>
        public Uri OutputBlobUri { get; set; }
        /// <summary> Specifies the Azure storage blob where script error stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer errorBlobManagedIdentity parameter. </summary>
        public Uri ErrorBlobUri { get; set; }
        /// <summary> User-assigned managed identity that has access to outputBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
        public RunCommandManagedIdentity OutputBlobManagedIdentity { get; set; }
        /// <summary> User-assigned managed identity that has access to errorBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
        public RunCommandManagedIdentity ErrorBlobManagedIdentity { get; set; }
        /// <summary> The provisioning state, which only appears in the response. If treatFailureAsDeploymentFailure set to true, any failure in the script will fail the deployment and ProvisioningState will be marked as Failed. If treatFailureAsDeploymentFailure set to false, ProvisioningState would only reflect whether the run command was run or not by the extensions platform, it would not indicate whether script failed in case of script failures. See instance view of run command in case of script failures to see executionMessage, output, error: https://aka.ms/runcommandmanaged#get-execution-status-and-results. </summary>
        public string ProvisioningState { get; }
        /// <summary> The virtual machine run command instance view. </summary>
        public VirtualMachineRunCommandInstanceView InstanceView { get; }
        /// <summary> Optional. If set to true, any failure in the script will fail the deployment and ProvisioningState will be marked as Failed. If set to false, ProvisioningState would only reflect whether the run command was run or not by the extensions platform, it would not indicate whether script failed in case of script failures. See instance view of run command in case of script failures to see executionMessage, output, error: https://aka.ms/runcommandmanaged#get-execution-status-and-results. </summary>
        public bool? TreatFailureAsDeploymentFailure { get; set; }
    }
}
