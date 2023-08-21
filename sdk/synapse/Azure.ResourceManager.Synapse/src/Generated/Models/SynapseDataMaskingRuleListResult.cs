// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The response to a list data masking rules request. </summary>
    internal partial class SynapseDataMaskingRuleListResult
    {
        /// <summary> Initializes a new instance of SynapseDataMaskingRuleListResult. </summary>
        internal SynapseDataMaskingRuleListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseDataMaskingRuleData>();
        }

        /// <summary> Initializes a new instance of SynapseDataMaskingRuleListResult. </summary>
        /// <param name="value"> The list of Sql pool data masking rules. </param>
        internal SynapseDataMaskingRuleListResult(IReadOnlyList<SynapseDataMaskingRuleData> value)
        {
            Value = value;
        }

        /// <summary> The list of Sql pool data masking rules. </summary>
        public IReadOnlyList<SynapseDataMaskingRuleData> Value { get; }
    }
}
