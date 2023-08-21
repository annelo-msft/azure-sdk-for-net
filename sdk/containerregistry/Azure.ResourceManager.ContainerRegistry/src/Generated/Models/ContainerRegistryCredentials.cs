// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters that describes a set of credentials that will be used when a run is invoked. </summary>
    public partial class ContainerRegistryCredentials
    {
        /// <summary> Initializes a new instance of ContainerRegistryCredentials. </summary>
        public ContainerRegistryCredentials()
        {
            CustomRegistries = new Core.ChangeTrackingDictionary<string, CustomRegistryCredentials>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryCredentials. </summary>
        /// <param name="sourceRegistry"> Describes the credential parameters for accessing the source registry. </param>
        /// <param name="customRegistries">
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </param>
        internal ContainerRegistryCredentials(SourceRegistryCredentials sourceRegistry, IDictionary<string, CustomRegistryCredentials> customRegistries)
        {
            SourceRegistry = sourceRegistry;
            CustomRegistries = customRegistries;
        }

        /// <summary> Describes the credential parameters for accessing the source registry. </summary>
        internal SourceRegistryCredentials SourceRegistry { get; set; }
        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        public SourceRegistryLoginMode? SourceRegistryLoginMode
        {
            get => SourceRegistry is null ? default : SourceRegistry.LoginMode;
            set
            {
                if (SourceRegistry is null)
                    SourceRegistry = new SourceRegistryCredentials();
                SourceRegistry.LoginMode = value;
            }
        }

        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        public IDictionary<string, CustomRegistryCredentials> CustomRegistries { get; }
    }
}
