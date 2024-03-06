// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> Project onboarding info. </summary>
    public partial class AzureDevOpsProjectMetadata
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

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsProjectMetadata"/>. </summary>
        public AzureDevOpsProjectMetadata()
        {
            Repos = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsProjectMetadata"/>. </summary>
        /// <param name="name"> Gets or sets name of the AzureDevOps Project. </param>
        /// <param name="autoDiscovery"></param>
        /// <param name="repos"> Gets or sets repositories. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsProjectMetadata(string name, AutoDiscovery? autoDiscovery, IList<string> repos, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AutoDiscovery = autoDiscovery;
            Repos = repos;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets name of the AzureDevOps Project. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the auto discovery. </summary>
        public AutoDiscovery? AutoDiscovery { get; set; }
        /// <summary> Gets or sets repositories. </summary>
        public IList<string> Repos { get; }
    }
}
