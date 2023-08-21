// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List FleetMembers operation. </summary>
    internal partial class FleetMembersListResult
    {
        /// <summary> Initializes a new instance of FleetMembersListResult. </summary>
        internal FleetMembersListResult()
        {
            Value = new Core.ChangeTrackingList<ContainerServiceFleetMemberData>();
        }

        /// <summary> Initializes a new instance of FleetMembersListResult. </summary>
        /// <param name="value"> The list of members in a given Fleet. </param>
        /// <param name="nextLink"> The URL to get the next page of Fleet members. </param>
        internal FleetMembersListResult(IReadOnlyList<ContainerServiceFleetMemberData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of members in a given Fleet. </summary>
        public IReadOnlyList<ContainerServiceFleetMemberData> Value { get; }
        /// <summary> The URL to get the next page of Fleet members. </summary>
        public string NextLink { get; }
    }
}
