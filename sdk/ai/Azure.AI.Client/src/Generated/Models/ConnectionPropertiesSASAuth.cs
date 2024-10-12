// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Client.Models
{
    /// <summary> Connection properties for connections with SAS authentication. </summary>
    internal partial class ConnectionPropertiesSASAuth : ConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionPropertiesSASAuth"/>. </summary>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="credentials"> Credentials will only be present for authType=ApiKey. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> or <paramref name="target"/> is null. </exception>
        internal ConnectionPropertiesSASAuth(EndpointType category, CredentialsSASAuth credentials, string target)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));
            Argument.AssertNotNull(target, nameof(target));

            AuthType = AuthenticationType.SAS;
            Category = category;
            Credentials = credentials;
            Target = target;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionPropertiesSASAuth"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="credentials"> Credentials will only be present for authType=ApiKey. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        internal ConnectionPropertiesSASAuth(AuthenticationType authType, IDictionary<string, BinaryData> serializedAdditionalRawData, EndpointType category, CredentialsSASAuth credentials, string target) : base(authType, serializedAdditionalRawData)
        {
            Category = category;
            Credentials = credentials;
            Target = target;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionPropertiesSASAuth"/> for deserialization. </summary>
        internal ConnectionPropertiesSASAuth()
        {
        }

        /// <summary> Category of the connection. </summary>
        public EndpointType Category { get; }
        /// <summary> Credentials will only be present for authType=ApiKey. </summary>
        public CredentialsSASAuth Credentials { get; }
        /// <summary> The connection URL to be used for this service. </summary>
        public string Target { get; }
    }
}
