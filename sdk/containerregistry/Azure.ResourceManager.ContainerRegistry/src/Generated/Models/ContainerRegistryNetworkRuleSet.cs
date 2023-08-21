// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The network rule set for a container registry. </summary>
    public partial class ContainerRegistryNetworkRuleSet
    {
        /// <summary> Initializes a new instance of ContainerRegistryNetworkRuleSet. </summary>
        /// <param name="defaultAction"> The default action of allow or deny when no other rules match. </param>
        public ContainerRegistryNetworkRuleSet(ContainerRegistryNetworkRuleDefaultAction defaultAction)
        {
            DefaultAction = defaultAction;
            IPRules = new Core.ChangeTrackingList<ContainerRegistryIPRule>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryNetworkRuleSet. </summary>
        /// <param name="defaultAction"> The default action of allow or deny when no other rules match. </param>
        /// <param name="ipRules"> The IP ACL rules. </param>
        internal ContainerRegistryNetworkRuleSet(ContainerRegistryNetworkRuleDefaultAction defaultAction, IList<ContainerRegistryIPRule> ipRules)
        {
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> The default action of allow or deny when no other rules match. </summary>
        public ContainerRegistryNetworkRuleDefaultAction DefaultAction { get; set; }
        /// <summary> The IP ACL rules. </summary>
        public IList<ContainerRegistryIPRule> IPRules { get; }
    }
}
