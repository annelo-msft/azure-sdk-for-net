// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the login flow of the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectLogin
    {
        /// <summary> Initializes a new instance of ContainerAppOpenIdConnectLogin. </summary>
        public ContainerAppOpenIdConnectLogin()
        {
            Scopes = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerAppOpenIdConnectLogin. </summary>
        /// <param name="nameClaimType"> The name of the claim that contains the users name. </param>
        /// <param name="scopes"> A list of the scopes that should be requested while authenticating. </param>
        internal ContainerAppOpenIdConnectLogin(string nameClaimType, IList<string> scopes)
        {
            NameClaimType = nameClaimType;
            Scopes = scopes;
        }

        /// <summary> The name of the claim that contains the users name. </summary>
        public string NameClaimType { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> Scopes { get; }
    }
}
