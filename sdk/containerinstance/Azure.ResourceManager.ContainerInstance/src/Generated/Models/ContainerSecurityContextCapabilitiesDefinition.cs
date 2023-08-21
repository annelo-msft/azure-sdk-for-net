// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The capabilities to add or drop from a container. </summary>
    public partial class ContainerSecurityContextCapabilitiesDefinition
    {
        /// <summary> Initializes a new instance of ContainerSecurityContextCapabilitiesDefinition. </summary>
        public ContainerSecurityContextCapabilitiesDefinition()
        {
            Add = new Core.ChangeTrackingList<string>();
            Drop = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerSecurityContextCapabilitiesDefinition. </summary>
        /// <param name="add"> The capabilities to add to the container. </param>
        /// <param name="drop"> The capabilities to drop from the container. </param>
        internal ContainerSecurityContextCapabilitiesDefinition(IList<string> @add, IList<string> drop)
        {
            Add = @add;
            Drop = drop;
        }

        /// <summary> The capabilities to add to the container. </summary>
        public IList<string> Add { get; }
        /// <summary> The capabilities to drop from the container. </summary>
        public IList<string> Drop { get; }
    }
}
