// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a Virtual Machine software patch. </summary>
    public partial class VirtualMachineSoftwarePatchProperties
    {
        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        internal VirtualMachineSoftwarePatchProperties()
        {
            Classifications = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        /// <param name="patchId"> A unique identifier for the patch. </param>
        /// <param name="name"> The friendly name of the patch. </param>
        /// <param name="version"> The version number of the patch. This property applies only to Linux patches. </param>
        /// <param name="kbId"> The KBID of the patch. Only applies to Windows patches. </param>
        /// <param name="classifications"> The classification(s) of the patch as provided by the patch publisher. </param>
        /// <param name="rebootBehavior"> Describes the reboot requirements of the patch. </param>
        /// <param name="activityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="publishedOn"> The UTC timestamp when the repository published this patch. </param>
        /// <param name="lastModifiedOn"> The UTC timestamp of the last update to this patch record. </param>
        /// <param name="assessmentState"> Describes the availability of a given patch. </param>
        internal VirtualMachineSoftwarePatchProperties(string patchId, string name, string version, string kbId, IReadOnlyList<string> classifications, VmGuestPatchRebootBehavior? rebootBehavior, string activityId, DateTimeOffset? publishedOn, DateTimeOffset? lastModifiedOn, PatchAssessmentState? assessmentState)
        {
            PatchId = patchId;
            Name = name;
            Version = version;
            KbId = kbId;
            Classifications = classifications;
            RebootBehavior = rebootBehavior;
            ActivityId = activityId;
            PublishedOn = publishedOn;
            LastModifiedOn = lastModifiedOn;
            AssessmentState = assessmentState;
        }

        /// <summary> A unique identifier for the patch. </summary>
        public string PatchId { get; }
        /// <summary> The friendly name of the patch. </summary>
        public string Name { get; }
        /// <summary> The version number of the patch. This property applies only to Linux patches. </summary>
        public string Version { get; }
        /// <summary> The KBID of the patch. Only applies to Windows patches. </summary>
        public string KbId { get; }
        /// <summary> The classification(s) of the patch as provided by the patch publisher. </summary>
        public IReadOnlyList<string> Classifications { get; }
        /// <summary> Describes the reboot requirements of the patch. </summary>
        public VmGuestPatchRebootBehavior? RebootBehavior { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string ActivityId { get; }
        /// <summary> The UTC timestamp when the repository published this patch. </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary> The UTC timestamp of the last update to this patch record. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Describes the availability of a given patch. </summary>
        public PatchAssessmentState? AssessmentState { get; }
    }
}
