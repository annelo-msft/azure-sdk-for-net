// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseSparkConfiguration data model.
    /// SparkConfiguration response details
    /// </summary>
    public partial class SynapseSparkConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseSparkConfigurationData. </summary>
        /// <param name="configs"> SparkConfiguration configs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configs"/> is null. </exception>
        public SynapseSparkConfigurationData(IDictionary<string, string> configs)
        {
            Argument.AssertNotNull(configs, nameof(configs));

            Configs = configs;
            Annotations = new Core.ChangeTrackingList<string>();
            ConfigMergeRule = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SynapseSparkConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description about the SparkConfiguration. </param>
        /// <param name="configs"> SparkConfiguration configs. </param>
        /// <param name="annotations"> Annotations for SparkConfiguration. </param>
        /// <param name="notes"> additional Notes. </param>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdOn"> The timestamp of resource creation. </param>
        /// <param name="configMergeRule"> SparkConfiguration merge configs. </param>
        /// <param name="etag"> Resource Etag. </param>
        internal SynapseSparkConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IDictionary<string, string> configs, IList<string> annotations, string notes, string createdBy, DateTimeOffset? createdOn, IDictionary<string, string> configMergeRule, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Configs = configs;
            Annotations = annotations;
            Notes = notes;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            ConfigMergeRule = configMergeRule;
            ETag = etag;
        }

        /// <summary> Description about the SparkConfiguration. </summary>
        public string Description { get; set; }
        /// <summary> SparkConfiguration configs. </summary>
        public IDictionary<string, string> Configs { get; }
        /// <summary> Annotations for SparkConfiguration. </summary>
        public IList<string> Annotations { get; }
        /// <summary> additional Notes. </summary>
        public string Notes { get; set; }
        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The timestamp of resource creation. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> SparkConfiguration merge configs. </summary>
        public IDictionary<string, string> ConfigMergeRule { get; }
        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
    }
}
