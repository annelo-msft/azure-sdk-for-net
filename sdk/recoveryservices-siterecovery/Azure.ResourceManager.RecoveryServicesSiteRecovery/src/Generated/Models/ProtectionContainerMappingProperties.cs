// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Protection container mapping properties. </summary>
    public partial class ProtectionContainerMappingProperties
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

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerMappingProperties"/>. </summary>
        internal ProtectionContainerMappingProperties()
        {
            HealthErrorDetails = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerMappingProperties"/>. </summary>
        /// <param name="targetProtectionContainerId"> Paired protection container ARM ID. </param>
        /// <param name="targetProtectionContainerFriendlyName"> Friendly name of paired container. </param>
        /// <param name="providerSpecificDetails">
        /// Provider specific provider details.
        /// Please note <see cref="ProtectionContainerMappingProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AProtectionContainerMappingDetails"/>, <see cref="InMageRcmProtectionContainerMappingDetails"/> and <see cref="VMwareCbtProtectionContainerMappingDetails"/>.
        /// </param>
        /// <param name="health"> Health of pairing. </param>
        /// <param name="healthErrorDetails"> Health error. </param>
        /// <param name="policyId"> Policy ARM Id. </param>
        /// <param name="state"> Association Status. </param>
        /// <param name="sourceProtectionContainerFriendlyName"> Friendly name of source protection container. </param>
        /// <param name="sourceFabricFriendlyName"> Friendly name of source fabric. </param>
        /// <param name="targetFabricFriendlyName"> Friendly name of target fabric. </param>
        /// <param name="policyFriendlyName"> Friendly name of replication policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProtectionContainerMappingProperties(ResourceIdentifier targetProtectionContainerId, string targetProtectionContainerFriendlyName, ProtectionContainerMappingProviderSpecificDetails providerSpecificDetails, string health, IReadOnlyList<SiteRecoveryHealthError> healthErrorDetails, ResourceIdentifier policyId, string state, string sourceProtectionContainerFriendlyName, string sourceFabricFriendlyName, string targetFabricFriendlyName, string policyFriendlyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetProtectionContainerId = targetProtectionContainerId;
            TargetProtectionContainerFriendlyName = targetProtectionContainerFriendlyName;
            ProviderSpecificDetails = providerSpecificDetails;
            Health = health;
            HealthErrorDetails = healthErrorDetails;
            PolicyId = policyId;
            State = state;
            SourceProtectionContainerFriendlyName = sourceProtectionContainerFriendlyName;
            SourceFabricFriendlyName = sourceFabricFriendlyName;
            TargetFabricFriendlyName = targetFabricFriendlyName;
            PolicyFriendlyName = policyFriendlyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Paired protection container ARM ID. </summary>
        public ResourceIdentifier TargetProtectionContainerId { get; }
        /// <summary> Friendly name of paired container. </summary>
        public string TargetProtectionContainerFriendlyName { get; }
        /// <summary>
        /// Provider specific provider details.
        /// Please note <see cref="ProtectionContainerMappingProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AProtectionContainerMappingDetails"/>, <see cref="InMageRcmProtectionContainerMappingDetails"/> and <see cref="VMwareCbtProtectionContainerMappingDetails"/>.
        /// </summary>
        public ProtectionContainerMappingProviderSpecificDetails ProviderSpecificDetails { get; }
        /// <summary> Health of pairing. </summary>
        public string Health { get; }
        /// <summary> Health error. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrorDetails { get; }
        /// <summary> Policy ARM Id. </summary>
        public ResourceIdentifier PolicyId { get; }
        /// <summary> Association Status. </summary>
        public string State { get; }
        /// <summary> Friendly name of source protection container. </summary>
        public string SourceProtectionContainerFriendlyName { get; }
        /// <summary> Friendly name of source fabric. </summary>
        public string SourceFabricFriendlyName { get; }
        /// <summary> Friendly name of target fabric. </summary>
        public string TargetFabricFriendlyName { get; }
        /// <summary> Friendly name of replication policy. </summary>
        public string PolicyFriendlyName { get; }
    }
}
