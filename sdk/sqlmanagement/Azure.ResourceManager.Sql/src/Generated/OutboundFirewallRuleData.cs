// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the OutboundFirewallRule data model. </summary>
    public partial class OutboundFirewallRuleData : Resource
    {
        /// <summary> Initializes a new instance of OutboundFirewallRuleData. </summary>
        public OutboundFirewallRuleData()
        {
        }

        /// <summary> Initializes a new instance of OutboundFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="provisioningState"> The state of the outbound rule. </param>
        internal OutboundFirewallRuleData(ResourceIdentifier id, string name, ResourceType type, string provisioningState) : base(id, name, type)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> The state of the outbound rule. </summary>
        public string ProvisioningState { get; }
    }
}
