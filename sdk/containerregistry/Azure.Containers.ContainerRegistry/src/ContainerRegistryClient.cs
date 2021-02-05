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
    public class ContainerRegistryClient
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

        // TODO: what are the semantics of Create in our APIs?  Does it throw if the resource already exists?
        // TODO: is there a user scenario where they would want to Set and override?  CreateIfNotExists?
        // TODO: figure out what Track 2 semantics to copy; what is precedent here?  (What do I think?)
        public virtual Response CreateManifest(string name, string reference, Manifest payload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        // TODO: dig into this ManifestWrapper type - will be need to simplify or restructure?
        // TODO: Rename Manifest
        // TODO: Rename Descriptor
        // TODO: Rename Annotations
        public virtual Response<ManifestWrapper> GetManifest(string name, string reference, Manifest payload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
