// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The scopes checked by the available scope api. </summary>
    internal partial class SubscriptionScopeProperties
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

        /// <summary> Initializes a new instance of <see cref="SubscriptionScopeProperties"/>. </summary>
        internal SubscriptionScopeProperties()
        {
            Scopes = new ChangeTrackingList<ScopeProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionScopeProperties"/>. </summary>
        /// <param name="scopes"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionScopeProperties(IReadOnlyList<ScopeProperties> scopes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scopes = scopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the scopes. </summary>
        public IReadOnlyList<ScopeProperties> Scopes { get; }
    }
}
