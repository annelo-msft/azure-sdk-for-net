// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The list credential result response. </summary>
    public partial class ManagedClusterCredentials
    {
        /// <summary> Initializes a new instance of ManagedClusterCredentials. </summary>
        internal ManagedClusterCredentials()
        {
            Kubeconfigs = new Core.ChangeTrackingList<ManagedClusterCredential>();
        }

        /// <summary> Initializes a new instance of ManagedClusterCredentials. </summary>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        internal ManagedClusterCredentials(IReadOnlyList<ManagedClusterCredential> kubeconfigs)
        {
            Kubeconfigs = kubeconfigs;
        }

        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<ManagedClusterCredential> Kubeconfigs { get; }
    }
}
