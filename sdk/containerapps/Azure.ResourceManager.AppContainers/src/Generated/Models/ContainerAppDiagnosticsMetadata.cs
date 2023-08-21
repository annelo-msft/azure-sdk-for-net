// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Metadata of the diagnostics response. </summary>
    public partial class ContainerAppDiagnosticsMetadata : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppDiagnosticsMetadata. </summary>
        public ContainerAppDiagnosticsMetadata()
        {
            SupportTopicList = new Core.ChangeTrackingList<ContainerAppDiagnosticSupportTopic>();
            AnalysisTypes = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerAppDiagnosticsMetadata. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Details of the diagnostics info. </param>
        /// <param name="author"> Authors' names of the detector. </param>
        /// <param name="category"> Category of the detector. </param>
        /// <param name="supportTopicList"> List of support topics. </param>
        /// <param name="analysisTypes"> List of analysis types. </param>
        /// <param name="score"> Authors' names of the detector. </param>
        internal ContainerAppDiagnosticsMetadata(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string author, string category, IList<ContainerAppDiagnosticSupportTopic> supportTopicList, IList<string> analysisTypes, float? score) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Author = author;
            Category = category;
            SupportTopicList = supportTopicList;
            AnalysisTypes = analysisTypes;
            Score = score;
        }

        /// <summary> Details of the diagnostics info. </summary>
        public string Description { get; }
        /// <summary> Authors' names of the detector. </summary>
        public string Author { get; }
        /// <summary> Category of the detector. </summary>
        public string Category { get; }
        /// <summary> List of support topics. </summary>
        public IList<ContainerAppDiagnosticSupportTopic> SupportTopicList { get; }
        /// <summary> List of analysis types. </summary>
        public IList<string> AnalysisTypes { get; }
        /// <summary> Authors' names of the detector. </summary>
        public float? Score { get; }
    }
}
