// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Core
{
    /// <summary> A class representing the operations that can be performed over a specific resource. </summary>
    public abstract partial class ArmResource
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <returns> Returns a <see cref="PolicyAssignmentCollection" /> object. </returns>
        public virtual PolicyAssignmentCollection GetPolicyAssignments()
        {
            return new PolicyAssignmentCollection(this);
        }
        #endregion

        #region PolicyExemption
        /// <summary> Gets an object representing a PolicyExemptionCollection along with the instance operations that can be performed on it. </summary>
        /// <returns> Returns a <see cref="PolicyExemptionCollection" /> object. </returns>
        public virtual PolicyExemptionCollection GetPolicyExemptions()
        {
            return new PolicyExemptionCollection(this);
        }
        #endregion

        #region ManagementLockObject
        /// <summary> Gets an object representing a ManagementLockObjectCollection along with the instance operations that can be performed on it. </summary>
        /// <returns> Returns a <see cref="ManagementLockObjectCollection" /> object. </returns>
        public virtual ManagementLockObjectCollection GetManagementLockObjects()
        {
            return new ManagementLockObjectCollection(this);
        }
        #endregion
    }
}
