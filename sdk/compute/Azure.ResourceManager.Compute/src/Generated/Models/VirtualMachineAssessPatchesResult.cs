// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of an AssessPatches result. </summary>
    public partial class VirtualMachineAssessPatchesResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineAssessPatchesResult"/>. </summary>
        internal VirtualMachineAssessPatchesResult()
        {
            AvailablePatches = new ChangeTrackingList<VirtualMachineSoftwarePatchProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineAssessPatchesResult"/>. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </param>
        /// <param name="assessmentActivityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="rebootPending"> The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred. </param>
        /// <param name="criticalAndSecurityPatchCount"> The number of critical or security patches that have been detected as available and not yet installed. </param>
        /// <param name="otherPatchCount"> The number of all available patches excluding critical and security. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="availablePatches"> The list of patches that have been detected as available for installation. </param>
        /// <param name="error"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineAssessPatchesResult(PatchOperationStatus? status, string assessmentActivityId, bool? rebootPending, int? criticalAndSecurityPatchCount, int? otherPatchCount, DateTimeOffset? startOn, IReadOnlyList<VirtualMachineSoftwarePatchProperties> availablePatches, ComputeApiError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            AssessmentActivityId = assessmentActivityId;
            RebootPending = rebootPending;
            CriticalAndSecurityPatchCount = criticalAndSecurityPatchCount;
            OtherPatchCount = otherPatchCount;
            StartOn = startOn;
            AvailablePatches = availablePatches;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </summary>
        public PatchOperationStatus? Status { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string AssessmentActivityId { get; }
        /// <summary> The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred. </summary>
        public bool? RebootPending { get; }
        /// <summary> The number of critical or security patches that have been detected as available and not yet installed. </summary>
        public int? CriticalAndSecurityPatchCount { get; }
        /// <summary> The number of all available patches excluding critical and security. </summary>
        public int? OtherPatchCount { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The list of patches that have been detected as available for installation. </summary>
        public IReadOnlyList<VirtualMachineSoftwarePatchProperties> AvailablePatches { get; }
        /// <summary> The errors that were encountered during execution of the operation. The details array contains the list of them. </summary>
        public ComputeApiError Error { get; }
    }
}
