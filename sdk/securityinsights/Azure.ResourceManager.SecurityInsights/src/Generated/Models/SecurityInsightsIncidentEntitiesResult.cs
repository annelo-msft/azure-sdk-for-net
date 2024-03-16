// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The incident related entities response. </summary>
    public partial class SecurityInsightsIncidentEntitiesResult
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentEntitiesResult"/>. </summary>
        internal SecurityInsightsIncidentEntitiesResult()
        {
            Entities = new ChangeTrackingList<SecurityInsightsEntity>();
            MetaData = new ChangeTrackingList<SecurityInsightsIncidentEntitiesMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentEntitiesResult"/>. </summary>
        /// <param name="entities">
        /// Array of the incident related entities.
        /// Please note <see cref="SecurityInsightsEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsAccountEntity"/>, <see cref="SecurityInsightsAzureResourceEntity"/>, <see cref="SecurityInsightsHuntingBookmark"/>, <see cref="SecurityInsightsCloudApplicationEntity"/>, <see cref="SecurityInsightsDnsEntity"/>, <see cref="SecurityInsightsFileEntity"/>, <see cref="SecurityInsightsFileHashEntity"/>, <see cref="SecurityInsightsHostEntity"/>, <see cref="SecurityInsightsIotDeviceEntity"/>, <see cref="SecurityInsightsIPEntity"/>, <see cref="SecurityInsightsMailboxEntity"/>, <see cref="SecurityInsightsMailClusterEntity"/>, <see cref="SecurityInsightsMailMessageEntity"/>, <see cref="SecurityInsightsMalwareEntity"/>, <see cref="SecurityInsightsProcessEntity"/>, <see cref="SecurityInsightsRegistryKeyEntity"/>, <see cref="SecurityInsightsRegistryValueEntity"/>, <see cref="SecurityInsightsAlert"/>, <see cref="SecurityInsightsGroupEntity"/>, <see cref="SecurityInsightsSubmissionMailEntity"/> and <see cref="SecurityInsightsUriEntity"/>.
        /// </param>
        /// <param name="metaData"> The metadata from the incident related entities results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentEntitiesResult(IReadOnlyList<SecurityInsightsEntity> entities, IReadOnlyList<SecurityInsightsIncidentEntitiesMetadata> metaData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Entities = entities;
            MetaData = metaData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Array of the incident related entities.
        /// Please note <see cref="SecurityInsightsEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsAccountEntity"/>, <see cref="SecurityInsightsAzureResourceEntity"/>, <see cref="SecurityInsightsHuntingBookmark"/>, <see cref="SecurityInsightsCloudApplicationEntity"/>, <see cref="SecurityInsightsDnsEntity"/>, <see cref="SecurityInsightsFileEntity"/>, <see cref="SecurityInsightsFileHashEntity"/>, <see cref="SecurityInsightsHostEntity"/>, <see cref="SecurityInsightsIotDeviceEntity"/>, <see cref="SecurityInsightsIPEntity"/>, <see cref="SecurityInsightsMailboxEntity"/>, <see cref="SecurityInsightsMailClusterEntity"/>, <see cref="SecurityInsightsMailMessageEntity"/>, <see cref="SecurityInsightsMalwareEntity"/>, <see cref="SecurityInsightsProcessEntity"/>, <see cref="SecurityInsightsRegistryKeyEntity"/>, <see cref="SecurityInsightsRegistryValueEntity"/>, <see cref="SecurityInsightsAlert"/>, <see cref="SecurityInsightsGroupEntity"/>, <see cref="SecurityInsightsSubmissionMailEntity"/> and <see cref="SecurityInsightsUriEntity"/>.
        /// </summary>
        public IReadOnlyList<SecurityInsightsEntity> Entities { get; }
        /// <summary> The metadata from the incident related entities results. </summary>
        public IReadOnlyList<SecurityInsightsIncidentEntitiesMetadata> MetaData { get; }
    }
}
