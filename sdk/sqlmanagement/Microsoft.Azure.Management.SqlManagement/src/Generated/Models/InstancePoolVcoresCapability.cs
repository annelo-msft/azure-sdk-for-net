// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The managed instance virtual cores capability.
    /// </summary>
    public partial class InstancePoolVcoresCapability
    {
        /// <summary>
        /// Initializes a new instance of the InstancePoolVcoresCapability
        /// class.
        /// </summary>
        public InstancePoolVcoresCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstancePoolVcoresCapability
        /// class.
        /// </summary>
        /// <param name="name">The virtual cores identifier.</param>
        /// <param name="value">The virtual cores value.</param>
        /// <param name="storageLimit">Storage limit.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public InstancePoolVcoresCapability(string name = default(string), int? value = default(int?), MaxSizeCapability storageLimit = default(MaxSizeCapability), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Name = name;
            Value = value;
            StorageLimit = storageLimit;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual cores identifier.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the virtual cores value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; private set; }

        /// <summary>
        /// Gets storage limit.
        /// </summary>
        [JsonProperty(PropertyName = "storageLimit")]
        public MaxSizeCapability StorageLimit { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
