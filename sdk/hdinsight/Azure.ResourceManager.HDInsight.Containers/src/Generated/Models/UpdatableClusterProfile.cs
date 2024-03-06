// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster resource patch properties. </summary>
    public partial class UpdatableClusterProfile
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

        /// <summary> Initializes a new instance of <see cref="UpdatableClusterProfile"/>. </summary>
        public UpdatableClusterProfile()
        {
            ServiceConfigsProfiles = new ChangeTrackingList<ClusterServiceConfigsProfile>();
            ScriptActionProfiles = new ChangeTrackingList<ScriptActionProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdatableClusterProfile"/>. </summary>
        /// <param name="serviceConfigsProfiles"> The service configs profiles. </param>
        /// <param name="sshProfile"> Ssh profile for the cluster. </param>
        /// <param name="autoscaleProfile"> This is the Autoscale profile for the cluster. This will allow customer to create cluster enabled with Autoscale. </param>
        /// <param name="authorizationProfile"> Authorization profile with details of AAD user Ids and group Ids authorized for data plane access. </param>
        /// <param name="logAnalyticsProfile"> Cluster log analytics profile to enable or disable OMS agent for cluster. </param>
        /// <param name="prometheusProfile"> Cluster Prometheus profile. </param>
        /// <param name="scriptActionProfiles"> The script action profile list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdatableClusterProfile(IList<ClusterServiceConfigsProfile> serviceConfigsProfiles, ClusterSshProfile sshProfile, ClusterAutoscaleProfile autoscaleProfile, AuthorizationProfile authorizationProfile, ClusterLogAnalyticsProfile logAnalyticsProfile, ClusterPrometheusProfile prometheusProfile, IList<ScriptActionProfile> scriptActionProfiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceConfigsProfiles = serviceConfigsProfiles;
            SshProfile = sshProfile;
            AutoscaleProfile = autoscaleProfile;
            AuthorizationProfile = authorizationProfile;
            LogAnalyticsProfile = logAnalyticsProfile;
            PrometheusProfile = prometheusProfile;
            ScriptActionProfiles = scriptActionProfiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The service configs profiles. </summary>
        public IList<ClusterServiceConfigsProfile> ServiceConfigsProfiles { get; }
        /// <summary> Ssh profile for the cluster. </summary>
        public ClusterSshProfile SshProfile { get; set; }
        /// <summary> This is the Autoscale profile for the cluster. This will allow customer to create cluster enabled with Autoscale. </summary>
        public ClusterAutoscaleProfile AutoscaleProfile { get; set; }
        /// <summary> Authorization profile with details of AAD user Ids and group Ids authorized for data plane access. </summary>
        public AuthorizationProfile AuthorizationProfile { get; set; }
        /// <summary> Cluster log analytics profile to enable or disable OMS agent for cluster. </summary>
        public ClusterLogAnalyticsProfile LogAnalyticsProfile { get; set; }
        /// <summary> Cluster Prometheus profile. </summary>
        internal ClusterPrometheusProfile PrometheusProfile { get; set; }
        /// <summary> Enable Prometheus for cluster or not. </summary>
        public bool? IsEnabled
        {
            get => PrometheusProfile is null ? default(bool?) : PrometheusProfile.IsEnabled;
            set
            {
                PrometheusProfile = value.HasValue ? new ClusterPrometheusProfile(value.Value) : null;
            }
        }

        /// <summary> The script action profile list. </summary>
        public IList<ScriptActionProfile> ScriptActionProfiles { get; }
    }
}
