// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto cluster principal assignments operation response. </summary>
    internal partial class SynapseClusterPrincipalAssignmentListResult
    {
        /// <summary> Initializes a new instance of SynapseClusterPrincipalAssignmentListResult. </summary>
        internal SynapseClusterPrincipalAssignmentListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseClusterPrincipalAssignmentData>();
        }

        /// <summary> Initializes a new instance of SynapseClusterPrincipalAssignmentListResult. </summary>
        /// <param name="value"> The list of Kusto cluster principal assignments. </param>
        internal SynapseClusterPrincipalAssignmentListResult(IReadOnlyList<SynapseClusterPrincipalAssignmentData> value)
        {
            Value = value;
        }

        /// <summary> The list of Kusto cluster principal assignments. </summary>
        public IReadOnlyList<SynapseClusterPrincipalAssignmentData> Value { get; }
    }
}
