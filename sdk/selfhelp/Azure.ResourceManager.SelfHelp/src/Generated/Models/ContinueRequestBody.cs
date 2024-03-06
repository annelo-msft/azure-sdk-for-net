// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Troubleshooter ContinueRequest body. </summary>
    public partial class ContinueRequestBody
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

        /// <summary> Initializes a new instance of <see cref="ContinueRequestBody"/>. </summary>
        public ContinueRequestBody()
        {
            Responses = new ChangeTrackingList<TroubleshooterResult>();
        }

        /// <summary> Initializes a new instance of <see cref="ContinueRequestBody"/>. </summary>
        /// <param name="stepId"> Unique id of the result. </param>
        /// <param name="responses"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContinueRequestBody(string stepId, IList<TroubleshooterResult> responses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StepId = stepId;
            Responses = responses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique id of the result. </summary>
        public string StepId { get; set; }
        /// <summary> Gets the responses. </summary>
        public IList<TroubleshooterResult> Responses { get; }
    }
}
