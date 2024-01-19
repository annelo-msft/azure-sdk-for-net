// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Define match conditions. </summary>
    public partial class CustomRuleMatchCondition
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

        /// <summary> Initializes a new instance of <see cref="CustomRuleMatchCondition"/>. </summary>
        /// <param name="matchVariable"> Match variable to compare against. </param>
        /// <param name="matchOperator"> Describes operator to be matched. </param>
        /// <param name="matchValue"> List of possible match values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchValue"/> is null. </exception>
        public CustomRuleMatchCondition(WafMatchVariable matchVariable, MatchOperator matchOperator, IEnumerable<string> matchValue)
        {
            Argument.AssertNotNull(matchValue, nameof(matchValue));

            MatchVariable = matchVariable;
            MatchOperator = matchOperator;
            MatchValue = matchValue.ToList();
            Transforms = new ChangeTrackingList<TransformType>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomRuleMatchCondition"/>. </summary>
        /// <param name="matchVariable"> Match variable to compare against. </param>
        /// <param name="selector"> Selector can used to match a specific key for QueryString, Cookies, RequestHeader or PostArgs. </param>
        /// <param name="matchOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if the result of this condition should be negated. </param>
        /// <param name="matchValue"> List of possible match values. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRuleMatchCondition(WafMatchVariable matchVariable, string selector, MatchOperator matchOperator, bool? negateCondition, IList<string> matchValue, IList<TransformType> transforms, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MatchVariable = matchVariable;
            Selector = selector;
            MatchOperator = matchOperator;
            NegateCondition = negateCondition;
            MatchValue = matchValue;
            Transforms = transforms;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRuleMatchCondition"/> for deserialization. </summary>
        internal CustomRuleMatchCondition()
        {
        }

        /// <summary> Match variable to compare against. </summary>
        public WafMatchVariable MatchVariable { get; set; }
        /// <summary> Selector can used to match a specific key for QueryString, Cookies, RequestHeader or PostArgs. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public MatchOperator MatchOperator { get; set; }
        /// <summary> Describes if the result of this condition should be negated. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> List of possible match values. </summary>
        public IList<string> MatchValue { get; }
        /// <summary> List of transforms. </summary>
        public IList<TransformType> Transforms { get; }
    }
}
