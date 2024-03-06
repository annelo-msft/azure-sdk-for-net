// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </summary>
    internal partial class StreamingJobDiagnostics
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

        /// <summary> Initializes a new instance of <see cref="StreamingJobDiagnostics"/>. </summary>
        internal StreamingJobDiagnostics()
        {
            Conditions = new ChangeTrackingList<StreamingJobDiagnosticCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobDiagnostics"/>. </summary>
        /// <param name="conditions"> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingJobDiagnostics(IReadOnlyList<StreamingJobDiagnosticCondition> conditions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conditions = conditions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </summary>
        public IReadOnlyList<StreamingJobDiagnosticCondition> Conditions { get; }
    }
}
