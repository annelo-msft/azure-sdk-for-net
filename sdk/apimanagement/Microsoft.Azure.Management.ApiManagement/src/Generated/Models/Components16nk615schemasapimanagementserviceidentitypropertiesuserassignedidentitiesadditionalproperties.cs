// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Components16nk615schemasapimanagementserviceidentitypropertiesuserassignedidentitiesadditionalproperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Components16nk615schemasapimanagementserviceidentitypropertiesuserassignedidentitiesadditionalproperties
        /// class.
        /// </summary>
        public Components16nk615schemasapimanagementserviceidentitypropertiesuserassignedidentitiesadditionalproperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Components16nk615schemasapimanagementserviceidentitypropertiesuserassignedidentitiesadditionalproperties
        /// class.
        /// </summary>
        /// <param name="principalId">The principal id of user assigned
        /// identity.</param>
        /// <param name="clientId">The client id of user assigned
        /// identity.</param>
        public Components16nk615schemasapimanagementserviceidentitypropertiesuserassignedidentitiesadditionalproperties(string principalId = default(string), string clientId = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

    }
}
