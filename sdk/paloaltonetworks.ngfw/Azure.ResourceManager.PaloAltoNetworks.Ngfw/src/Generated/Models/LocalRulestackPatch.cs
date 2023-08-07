// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The type used for update operations of the LocalRulestackResource. </summary>
    public partial class LocalRulestackPatch
    {
        /// <summary> Initializes a new instance of LocalRulestackPatch. </summary>
        public LocalRulestackPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The updatable properties of the LocalRulestackResource. </summary>
        public LocalRulestackUpdateProperties Properties { get; set; }
    }
}
