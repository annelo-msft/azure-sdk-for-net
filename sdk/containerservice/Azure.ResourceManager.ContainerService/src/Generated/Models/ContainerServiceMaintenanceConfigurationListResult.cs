// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List maintenance configurations operation. </summary>
    internal partial class ContainerServiceMaintenanceConfigurationListResult
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceConfigurationListResult"/>. </summary>
        internal ContainerServiceMaintenanceConfigurationListResult()
        {
            Value = new ChangeTrackingList<ContainerServiceMaintenanceConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceConfigurationListResult"/>. </summary>
        /// <param name="value"> The list of maintenance configurations. </param>
        /// <param name="nextLink"> The URL to get the next set of maintenance configuration results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceMaintenanceConfigurationListResult(IReadOnlyList<ContainerServiceMaintenanceConfigurationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of maintenance configurations. </summary>
        public IReadOnlyList<ContainerServiceMaintenanceConfigurationData> Value { get; }
        /// <summary> The URL to get the next set of maintenance configuration results. </summary>
        public string NextLink { get; }
    }
}
