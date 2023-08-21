// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of server auditing settings. </summary>
    internal partial class SynapseServerBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of SynapseServerBlobAuditingPolicyListResult. </summary>
        internal SynapseServerBlobAuditingPolicyListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseServerBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of SynapseServerBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseServerBlobAuditingPolicyListResult(IReadOnlyList<SynapseServerBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseServerBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
