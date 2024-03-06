// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ResourceSkuRestrictions
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

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictions"/>. </summary>
        internal ResourceSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictions"/>. </summary>
        /// <param name="restrictionsType"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="reasonCode"> The reason code for restriction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceSkuRestrictions(ResourceSkuRestrictionsType? restrictionsType, IReadOnlyList<string> values, ResourceSkuRestrictionsReasonCode? reasonCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestrictionsType = restrictionsType;
            Values = values;
            ReasonCode = reasonCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of restrictions. </summary>
        public ResourceSkuRestrictionsType? RestrictionsType { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The reason code for restriction. </summary>
        public ResourceSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}
