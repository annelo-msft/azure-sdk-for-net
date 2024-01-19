// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementCache data model.
    /// Cache details.
    /// </summary>
    public partial class ApiManagementCacheData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementCacheData"/>. </summary>
        public ApiManagementCacheData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementCacheData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Cache description. </param>
        /// <param name="connectionString"> Runtime connection string to cache. </param>
        /// <param name="useFromLocation"> Location identifier to use cache from (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="resourceUri"> Original uri of entity in external system cache points to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementCacheData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string connectionString, string useFromLocation, Uri resourceUri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ConnectionString = connectionString;
            UseFromLocation = useFromLocation;
            ResourceUri = resourceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cache description. </summary>
        public string Description { get; set; }
        /// <summary> Runtime connection string to cache. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Location identifier to use cache from (should be either 'default' or valid Azure region identifier). </summary>
        public string UseFromLocation { get; set; }
        /// <summary> Original uri of entity in external system cache points to. </summary>
        public Uri ResourceUri { get; set; }
    }
}
