// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The endpoint for Azure-SSIS integration runtime outbound network dependency. </summary>
    public partial class IntegrationRuntimeOutboundNetworkDependenciesEndpoint
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeOutboundNetworkDependenciesEndpoint. </summary>
        internal IntegrationRuntimeOutboundNetworkDependenciesEndpoint()
        {
            EndpointDetails = new Core.ChangeTrackingList<IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeOutboundNetworkDependenciesEndpoint. </summary>
        /// <param name="domainName"> The domain name of endpoint. </param>
        /// <param name="endpointDetails"> The details of endpoint. </param>
        internal IntegrationRuntimeOutboundNetworkDependenciesEndpoint(string domainName, IReadOnlyList<IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails> endpointDetails)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
        }

        /// <summary> The domain name of endpoint. </summary>
        public string DomainName { get; }
        /// <summary> The details of endpoint. </summary>
        public IReadOnlyList<IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails> EndpointDetails { get; }
    }
}
