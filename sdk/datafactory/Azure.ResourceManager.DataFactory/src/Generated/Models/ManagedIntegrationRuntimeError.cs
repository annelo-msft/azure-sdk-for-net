// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Error definition for managed integration runtime. </summary>
    public partial class ManagedIntegrationRuntimeError
    {
        /// <summary> Initializes a new instance of ManagedIntegrationRuntimeError. </summary>
        internal ManagedIntegrationRuntimeError()
        {
            Parameters = new Core.ChangeTrackingList<string>();
            AdditionalProperties = new Core.ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ManagedIntegrationRuntimeError. </summary>
        /// <param name="time"> The time when the error occurred. </param>
        /// <param name="code"> Error code. </param>
        /// <param name="parameters"> Managed integration runtime error parameters. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ManagedIntegrationRuntimeError(DateTimeOffset? time, string code, IReadOnlyList<string> parameters, string message, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            Time = time;
            Code = code;
            Parameters = parameters;
            Message = message;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The time when the error occurred. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Managed integration runtime error parameters. </summary>
        public IReadOnlyList<string> Parameters { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
