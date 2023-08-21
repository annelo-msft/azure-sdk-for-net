// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of SQL pool security alert policies. </summary>
    internal partial class SynapseSqlPoolSecurityAlertPolicyListResult
    {
        /// <summary> Initializes a new instance of SynapseSqlPoolSecurityAlertPolicyListResult. </summary>
        internal SynapseSqlPoolSecurityAlertPolicyListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseSqlPoolSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of SynapseSqlPoolSecurityAlertPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseSqlPoolSecurityAlertPolicyListResult(IReadOnlyList<SynapseSqlPoolSecurityAlertPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSqlPoolSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
