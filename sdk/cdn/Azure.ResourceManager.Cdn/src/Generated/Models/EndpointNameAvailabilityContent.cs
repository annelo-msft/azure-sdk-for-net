// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of CheckNameAvailability API. </summary>
    public partial class EndpointNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="EndpointNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to validate. </param>
        /// <param name="resourceType"> The type of the resource whose name is to be validated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public EndpointNameAvailabilityContent(string name, CdnResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="EndpointNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to validate. </param>
        /// <param name="resourceType"> The type of the resource whose name is to be validated. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> Indicates the endpoint name reuse scope. The default value is TenantReuse. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointNameAvailabilityContent(string name, CdnResourceType resourceType, DomainNameLabelScope? autoGeneratedDomainNameLabelScope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EndpointNameAvailabilityContent"/> for deserialization. </summary>
        internal EndpointNameAvailabilityContent()
        {
        }

        /// <summary> The resource name to validate. </summary>
        public string Name { get; }
        /// <summary> The type of the resource whose name is to be validated. </summary>
        public CdnResourceType ResourceType { get; }
        /// <summary> Indicates the endpoint name reuse scope. The default value is TenantReuse. </summary>
        public DomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get; set; }
    }
}
