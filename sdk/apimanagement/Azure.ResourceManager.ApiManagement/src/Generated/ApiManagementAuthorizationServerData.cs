// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementAuthorizationServer data model.
    /// External OAuth authorization server settings.
    /// </summary>
    public partial class ApiManagementAuthorizationServerData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementAuthorizationServerData"/>. </summary>
        public ApiManagementAuthorizationServerData()
        {
            AuthorizationMethods = new ChangeTrackingList<AuthorizationMethod>();
            ClientAuthenticationMethods = new ChangeTrackingList<ClientAuthenticationMethod>();
            TokenBodyParameters = new ChangeTrackingList<TokenBodyParameterContract>();
            BearerTokenSendingMethods = new ChangeTrackingList<BearerTokenSendingMethod>();
            GrantTypes = new ChangeTrackingList<GrantType>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementAuthorizationServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the authorization server. Can contain HTML formatting tags. </param>
        /// <param name="authorizationMethods"> HTTP verbs supported by the authorization endpoint. GET must be always present. POST is optional. </param>
        /// <param name="clientAuthenticationMethods"> Method of authentication supported by the token endpoint of this authorization server. Possible values are Basic and/or Body. When Body is specified, client credentials and other parameters are passed within the request body in the application/x-www-form-urlencoded format. </param>
        /// <param name="tokenBodyParameters"> Additional parameters required by the token endpoint of this authorization server represented as an array of JSON objects with name and value string properties, i.e. {"name" : "name value", "value": "a value"}. </param>
        /// <param name="tokenEndpoint"> OAuth token endpoint. Contains absolute URI to entity being referenced. </param>
        /// <param name="doesSupportState"> If true, authorization server will include state parameter from the authorization request to its response. Client may use state parameter to raise protocol security. </param>
        /// <param name="defaultScope"> Access token scope that is going to be requested by default. Can be overridden at the API level. Should be provided in the form of a string containing space-delimited values. </param>
        /// <param name="bearerTokenSendingMethods"> Specifies the mechanism by which access token is passed to the API. </param>
        /// <param name="resourceOwnerUsername"> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username. </param>
        /// <param name="resourceOwnerPassword"> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password. </param>
        /// <param name="displayName"> User-friendly authorization server name. </param>
        /// <param name="clientRegistrationEndpoint"> Optional reference to a page where client or app registration for this authorization server is performed. Contains absolute URL to entity being referenced. </param>
        /// <param name="authorizationEndpoint"> OAuth authorization endpoint. See http://tools.ietf.org/html/rfc6749#section-3.2. </param>
        /// <param name="grantTypes"> Form of an authorization grant, which the client uses to request the access token. </param>
        /// <param name="clientId"> Client or app id registered with this authorization server. </param>
        /// <param name="clientSecret"> Client or app secret registered with this authorization server. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementAuthorizationServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IList<AuthorizationMethod> authorizationMethods, IList<ClientAuthenticationMethod> clientAuthenticationMethods, IList<TokenBodyParameterContract> tokenBodyParameters, string tokenEndpoint, bool? doesSupportState, string defaultScope, IList<BearerTokenSendingMethod> bearerTokenSendingMethods, string resourceOwnerUsername, string resourceOwnerPassword, string displayName, string clientRegistrationEndpoint, string authorizationEndpoint, IList<GrantType> grantTypes, string clientId, string clientSecret, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AuthorizationMethods = authorizationMethods;
            ClientAuthenticationMethods = clientAuthenticationMethods;
            TokenBodyParameters = tokenBodyParameters;
            TokenEndpoint = tokenEndpoint;
            DoesSupportState = doesSupportState;
            DefaultScope = defaultScope;
            BearerTokenSendingMethods = bearerTokenSendingMethods;
            ResourceOwnerUsername = resourceOwnerUsername;
            ResourceOwnerPassword = resourceOwnerPassword;
            DisplayName = displayName;
            ClientRegistrationEndpoint = clientRegistrationEndpoint;
            AuthorizationEndpoint = authorizationEndpoint;
            GrantTypes = grantTypes;
            ClientId = clientId;
            ClientSecret = clientSecret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description of the authorization server. Can contain HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> HTTP verbs supported by the authorization endpoint. GET must be always present. POST is optional. </summary>
        public IList<AuthorizationMethod> AuthorizationMethods { get; }
        /// <summary> Method of authentication supported by the token endpoint of this authorization server. Possible values are Basic and/or Body. When Body is specified, client credentials and other parameters are passed within the request body in the application/x-www-form-urlencoded format. </summary>
        public IList<ClientAuthenticationMethod> ClientAuthenticationMethods { get; }
        /// <summary> Additional parameters required by the token endpoint of this authorization server represented as an array of JSON objects with name and value string properties, i.e. {"name" : "name value", "value": "a value"}. </summary>
        public IList<TokenBodyParameterContract> TokenBodyParameters { get; }
        /// <summary> OAuth token endpoint. Contains absolute URI to entity being referenced. </summary>
        public string TokenEndpoint { get; set; }
        /// <summary> If true, authorization server will include state parameter from the authorization request to its response. Client may use state parameter to raise protocol security. </summary>
        public bool? DoesSupportState { get; set; }
        /// <summary> Access token scope that is going to be requested by default. Can be overridden at the API level. Should be provided in the form of a string containing space-delimited values. </summary>
        public string DefaultScope { get; set; }
        /// <summary> Specifies the mechanism by which access token is passed to the API. </summary>
        public IList<BearerTokenSendingMethod> BearerTokenSendingMethods { get; }
        /// <summary> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username. </summary>
        public string ResourceOwnerUsername { get; set; }
        /// <summary> Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password. </summary>
        public string ResourceOwnerPassword { get; set; }
        /// <summary> User-friendly authorization server name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Optional reference to a page where client or app registration for this authorization server is performed. Contains absolute URL to entity being referenced. </summary>
        public string ClientRegistrationEndpoint { get; set; }
        /// <summary> OAuth authorization endpoint. See http://tools.ietf.org/html/rfc6749#section-3.2. </summary>
        public string AuthorizationEndpoint { get; set; }
        /// <summary> Form of an authorization grant, which the client uses to request the access token. </summary>
        public IList<GrantType> GrantTypes { get; }
        /// <summary> Client or app id registered with this authorization server. </summary>
        public string ClientId { get; set; }
        /// <summary> Client or app secret registered with this authorization server. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string ClientSecret { get; set; }
    }
}
