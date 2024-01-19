// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the deleted automation account type. </summary>
    public partial class DeletedAutomationAccount : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DeletedAutomationAccount"/>. </summary>
        internal DeletedAutomationAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedAutomationAccount"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Gets or sets the location of the resource. </param>
        /// <param name="automationAccountResourceId"> Gets or sets the Automation Account Resource Id. </param>
        /// <param name="automationAccountId"> Gets or sets the Automation Account Id. </param>
        /// <param name="locationPropertiesLocation"> Gets or sets the location of the resource. </param>
        /// <param name="deletedOn"> Gets the deletion time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedAutomationAccount(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceIdentifier automationAccountResourceId, string automationAccountId, string locationPropertiesLocation, DateTimeOffset? deletedOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            AutomationAccountResourceId = automationAccountResourceId;
            AutomationAccountId = automationAccountId;
            LocationPropertiesLocation = locationPropertiesLocation;
            DeletedOn = deletedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Gets or sets the Automation Account Resource Id. </summary>
        public ResourceIdentifier AutomationAccountResourceId { get; }
        /// <summary> Gets or sets the Automation Account Id. </summary>
        public string AutomationAccountId { get; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public string LocationPropertiesLocation { get; }
        /// <summary> Gets the deletion time. </summary>
        public DateTimeOffset? DeletedOn { get; }
    }
}
