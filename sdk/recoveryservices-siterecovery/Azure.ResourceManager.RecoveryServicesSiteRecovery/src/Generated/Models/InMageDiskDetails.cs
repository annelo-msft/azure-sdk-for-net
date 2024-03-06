// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware/Physical specific Disk Details. </summary>
    public partial class InMageDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="InMageDiskDetails"/>. </summary>
        internal InMageDiskDetails()
        {
            VolumeList = new ChangeTrackingList<SiteRecoveryDiskVolumeDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="diskSizeInMB"> The disk size in MB. </param>
        /// <param name="diskType"> Whether disk is system disk or data disk. </param>
        /// <param name="diskConfiguration"> Whether disk is dynamic disk or basic disk. </param>
        /// <param name="volumeList"> Volumes of the disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageDiskDetails(string diskId, string diskName, string diskSizeInMB, string diskType, string diskConfiguration, IReadOnlyList<SiteRecoveryDiskVolumeDetails> volumeList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            DiskSizeInMB = diskSizeInMB;
            DiskType = diskType;
            DiskConfiguration = diskConfiguration;
            VolumeList = volumeList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The disk size in MB. </summary>
        public string DiskSizeInMB { get; }
        /// <summary> Whether disk is system disk or data disk. </summary>
        public string DiskType { get; }
        /// <summary> Whether disk is dynamic disk or basic disk. </summary>
        public string DiskConfiguration { get; }
        /// <summary> Volumes of the disk. </summary>
        public IReadOnlyList<SiteRecoveryDiskVolumeDetails> VolumeList { get; }
    }
}
