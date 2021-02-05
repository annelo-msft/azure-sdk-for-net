// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Containers.ContainerRegistry.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary>
    /// </summary>
    public partial class ContainerRegistryClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryClient"/>.
        /// </summary>
        public ContainerRegistryClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryClient(Uri endpoint, TokenCredential credential, ContainerRegistryClientOptions options)
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryClient for mocking. </summary>
        protected ContainerRegistryClient()
        {
        }
    }
}
