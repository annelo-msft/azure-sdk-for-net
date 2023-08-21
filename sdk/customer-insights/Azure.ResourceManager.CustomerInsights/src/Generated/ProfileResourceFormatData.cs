// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the ProfileResourceFormat data model.
    /// The profile resource format.
    /// </summary>
    public partial class ProfileResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of ProfileResourceFormatData. </summary>
        public ProfileResourceFormatData()
        {
            Attributes = new Core.ChangeTrackingDictionary<string, IList<string>>();
            Description = new Core.ChangeTrackingDictionary<string, string>();
            DisplayName = new Core.ChangeTrackingDictionary<string, string>();
            LocalizedAttributes = new Core.ChangeTrackingDictionary<string, IDictionary<string, string>>();
            Fields = new Core.ChangeTrackingList<PropertyDefinition>();
            StrongIds = new Core.ChangeTrackingList<StrongId>();
        }

        /// <summary> Initializes a new instance of ProfileResourceFormatData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="attributes"> The attributes for the Type. </param>
        /// <param name="description"> Localized descriptions for the property. </param>
        /// <param name="displayName"> Localized display names for the property. </param>
        /// <param name="localizedAttributes"> Any custom localized attributes for the Type. </param>
        /// <param name="smallImage"> Small Image associated with the Property or EntityType. </param>
        /// <param name="mediumImage"> Medium Image associated with the Property or EntityType. </param>
        /// <param name="largeImage"> Large Image associated with the Property or EntityType. </param>
        /// <param name="apiEntitySetName"> The api entity set name. This becomes the odata entity set name for the entity Type being referred in this object. </param>
        /// <param name="entityType"> Type of entity. </param>
        /// <param name="fields"> The properties of the Profile. </param>
        /// <param name="instancesCount"> The instance count. </param>
        /// <param name="lastChangedUtc"> The last changed time for the type definition. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="schemaItemTypeLink"> The schema org link. This helps ACI identify and suggest semantic models. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="timestampFieldName"> The timestamp property name. Represents the time when the interaction or profile update happened. </param>
        /// <param name="typeName"> The name of the entity. </param>
        /// <param name="strongIds"> The strong IDs. </param>
        internal ProfileResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, IList<string>> attributes, IDictionary<string, string> description, IDictionary<string, string> displayName, IDictionary<string, IDictionary<string, string>> localizedAttributes, string smallImage, string mediumImage, string largeImage, string apiEntitySetName, EntityType? entityType, IList<PropertyDefinition> fields, int? instancesCount, DateTimeOffset? lastChangedUtc, ProvisioningState? provisioningState, string schemaItemTypeLink, Guid? tenantId, string timestampFieldName, string typeName, IList<StrongId> strongIds) : base(id, name, resourceType, systemData)
        {
            Attributes = attributes;
            Description = description;
            DisplayName = displayName;
            LocalizedAttributes = localizedAttributes;
            SmallImage = smallImage;
            MediumImage = mediumImage;
            LargeImage = largeImage;
            ApiEntitySetName = apiEntitySetName;
            EntityType = entityType;
            Fields = fields;
            InstancesCount = instancesCount;
            LastChangedUtc = lastChangedUtc;
            ProvisioningState = provisioningState;
            SchemaItemTypeLink = schemaItemTypeLink;
            TenantId = tenantId;
            TimestampFieldName = timestampFieldName;
            TypeName = typeName;
            StrongIds = strongIds;
        }

        /// <summary> The attributes for the Type. </summary>
        public IDictionary<string, IList<string>> Attributes { get; }
        /// <summary> Localized descriptions for the property. </summary>
        public IDictionary<string, string> Description { get; }
        /// <summary> Localized display names for the property. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Any custom localized attributes for the Type. </summary>
        public IDictionary<string, IDictionary<string, string>> LocalizedAttributes { get; }
        /// <summary> Small Image associated with the Property or EntityType. </summary>
        public string SmallImage { get; set; }
        /// <summary> Medium Image associated with the Property or EntityType. </summary>
        public string MediumImage { get; set; }
        /// <summary> Large Image associated with the Property or EntityType. </summary>
        public string LargeImage { get; set; }
        /// <summary> The api entity set name. This becomes the odata entity set name for the entity Type being referred in this object. </summary>
        public string ApiEntitySetName { get; set; }
        /// <summary> Type of entity. </summary>
        public EntityType? EntityType { get; set; }
        /// <summary> The properties of the Profile. </summary>
        public IList<PropertyDefinition> Fields { get; }
        /// <summary> The instance count. </summary>
        public int? InstancesCount { get; set; }
        /// <summary> The last changed time for the type definition. </summary>
        public DateTimeOffset? LastChangedUtc { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The schema org link. This helps ACI identify and suggest semantic models. </summary>
        public string SchemaItemTypeLink { get; set; }
        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The timestamp property name. Represents the time when the interaction or profile update happened. </summary>
        public string TimestampFieldName { get; set; }
        /// <summary> The name of the entity. </summary>
        public string TypeName { get; set; }
        /// <summary> The strong IDs. </summary>
        public IList<StrongId> StrongIds { get; }
    }
}
