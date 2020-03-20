// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> A skill that analyzes image files. It extracts a rich set of visual features based on the image content. </summary>
    public partial class ImageAnalysisSkill : Skill
    {
        /// <summary> Initializes a new instance of ImageAnalysisSkill. </summary>
        public ImageAnalysisSkill()
        {
            ODataType = "#Microsoft.Skills.Vision.ImageAnalysisSkill";
        }

        /// <summary> Initializes a new instance of ImageAnalysisSkill. </summary>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is en. </param>
        /// <param name="visualFeatures"> A list of visual features. </param>
        /// <param name="details"> A string indicating which domain-specific details to return. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character &apos;#&apos;. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        internal ImageAnalysisSkill(ImageAnalysisSkillLanguage? defaultLanguageCode, IList<VisualFeature> visualFeatures, IList<ImageDetail> details, string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            VisualFeatures = visualFeatures;
            Details = details;
            ODataType = "#Microsoft.Skills.Vision.ImageAnalysisSkill";
        }

        /// <summary> A value indicating which language code to use. Default is en. </summary>
        public ImageAnalysisSkillLanguage? DefaultLanguageCode { get; set; }
        /// <summary> A list of visual features. </summary>
        public IList<VisualFeature> VisualFeatures { get; set; }
        /// <summary> A string indicating which domain-specific details to return. </summary>
        public IList<ImageDetail> Details { get; set; }
    }
}
