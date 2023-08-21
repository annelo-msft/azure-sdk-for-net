// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the ContinuousWebJob data model.
    /// Continuous Web Job Information.
    /// </summary>
    public partial class ContinuousWebJobData : ResourceData
    {
        /// <summary> Initializes a new instance of ContinuousWebJobData. </summary>
        public ContinuousWebJobData()
        {
            Settings = new Core.ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ContinuousWebJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="detailedStatus"> Detailed status. </param>
        /// <param name="logUri"> Log URL. </param>
        /// <param name="runCommand"> Run command. </param>
        /// <param name="uri"> Job URL. </param>
        /// <param name="extraInfoUri"> Extra Info URL. </param>
        /// <param name="webJobType"> Job type. </param>
        /// <param name="error"> Error information. </param>
        /// <param name="isUsingSdk"> Using SDK?. </param>
        /// <param name="settings"> Job settings. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal ContinuousWebJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContinuousWebJobStatus? status, string detailedStatus, Uri logUri, string runCommand, Uri uri, Uri extraInfoUri, WebJobType? webJobType, string error, bool? isUsingSdk, IDictionary<string, BinaryData> settings, string kind) : base(id, name, resourceType, systemData)
        {
            Status = status;
            DetailedStatus = detailedStatus;
            LogUri = logUri;
            RunCommand = runCommand;
            Uri = uri;
            ExtraInfoUri = extraInfoUri;
            WebJobType = webJobType;
            Error = error;
            IsUsingSdk = isUsingSdk;
            Settings = settings;
            Kind = kind;
        }

        /// <summary> Job status. </summary>
        public ContinuousWebJobStatus? Status { get; set; }
        /// <summary> Detailed status. </summary>
        public string DetailedStatus { get; set; }
        /// <summary> Log URL. </summary>
        public Uri LogUri { get; set; }
        /// <summary> Run command. </summary>
        public string RunCommand { get; set; }
        /// <summary> Job URL. </summary>
        public Uri Uri { get; set; }
        /// <summary> Extra Info URL. </summary>
        public Uri ExtraInfoUri { get; set; }
        /// <summary> Job type. </summary>
        public WebJobType? WebJobType { get; set; }
        /// <summary> Error information. </summary>
        public string Error { get; set; }
        /// <summary> Using SDK?. </summary>
        public bool? IsUsingSdk { get; set; }
        /// <summary>
        /// Job settings.
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
        public IDictionary<string, BinaryData> Settings { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
