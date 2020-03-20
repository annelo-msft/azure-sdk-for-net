// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Compute role against which events will be raised.
    /// </summary>
    public partial class RoleSinkInfo
    {
        /// <summary>
        /// Initializes a new instance of the RoleSinkInfo class.
        /// </summary>
        public RoleSinkInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleSinkInfo class.
        /// </summary>
        /// <param name="roleId">Compute role ID.</param>
        public RoleSinkInfo(string roleId)
        {
            RoleId = roleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets compute role ID.
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleId");
            }
        }
    }
}
