// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Service linked service. </summary>
    public partial class AzureMLServiceLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureMLServiceLinkedService"/>. </summary>
        /// <param name="subscriptionId"> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </param>
        /// <param name="mlWorkspaceName"> Azure ML Service workspace name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="mlWorkspaceName"/> is null. </exception>
        public AzureMLServiceLinkedService(DataFactoryElement<string> subscriptionId, DataFactoryElement<string> resourceGroupName, DataFactoryElement<string> mlWorkspaceName)
        {
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(mlWorkspaceName, nameof(mlWorkspaceName));

            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            MLWorkspaceName = mlWorkspaceName;
            LinkedServiceType = "AzureMLService";
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLServiceLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="subscriptionId"> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </param>
        /// <param name="mlWorkspaceName"> Azure ML Service workspace name. Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Type of authentication (Required to specify MSI) used to connect to AzureML. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AzureMLServiceLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> subscriptionId, DataFactoryElement<string> resourceGroupName, DataFactoryElement<string> mlWorkspaceName, DataFactoryElement<string> authentication, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> tenant, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            MLWorkspaceName = mlWorkspaceName;
            Authentication = authentication;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "AzureMLService";
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLServiceLinkedService"/> for deserialization. </summary>
        internal AzureMLServiceLinkedService()
        {
        }

        /// <summary> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SubscriptionId { get; set; }
        /// <summary> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ResourceGroupName { get; set; }
        /// <summary> Azure ML Service workspace name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MLWorkspaceName { get; set; }
        /// <summary> Type of authentication (Required to specify MSI) used to connect to AzureML. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Authentication { get; set; }
        /// <summary> The ID of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
