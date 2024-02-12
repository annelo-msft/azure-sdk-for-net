// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Update integration runtime request. </summary>
    public partial class DataFactoryIntegrationRuntimePatch
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryIntegrationRuntimePatch"/>. </summary>
        public DataFactoryIntegrationRuntimePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryIntegrationRuntimePatch"/>. </summary>
        /// <param name="autoUpdate"> Enables or disables the auto-update feature of the self-hosted integration runtime. See https://go.microsoft.com/fwlink/?linkid=854189. </param>
        /// <param name="updateDelayOffset"> The time offset (in hours) in the day, e.g., PT03H is 3 hours. The integration runtime auto update will happen on that time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryIntegrationRuntimePatch(IntegrationRuntimeAutoUpdateState? autoUpdate, TimeSpan? updateDelayOffset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoUpdate = autoUpdate;
            UpdateDelayOffset = updateDelayOffset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enables or disables the auto-update feature of the self-hosted integration runtime. See https://go.microsoft.com/fwlink/?linkid=854189. </summary>
        public IntegrationRuntimeAutoUpdateState? AutoUpdate { get; set; }
        /// <summary> The time offset (in hours) in the day, e.g., PT03H is 3 hours. The integration runtime auto update will happen on that time. </summary>
        public TimeSpan? UpdateDelayOffset { get; set; }
    }
}
