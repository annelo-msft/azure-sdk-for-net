// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create TagDescription operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TagDescriptionCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TagDescriptionCreateParameters
        /// class.
        /// </summary>
        public TagDescriptionCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagDescriptionCreateParameters
        /// class.
        /// </summary>
        /// <param name="description">Description of the Tag.</param>
        /// <param name="externalDocsUrl">Absolute URL of external resources
        /// describing the tag.</param>
        /// <param name="externalDocsDescription">Description of the external
        /// resources describing the tag.</param>
        public TagDescriptionCreateParameters(string description = default(string), string externalDocsUrl = default(string), string externalDocsDescription = default(string))
        {
            Description = description;
            ExternalDocsUrl = externalDocsUrl;
            ExternalDocsDescription = externalDocsDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the Tag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets absolute URL of external resources describing the tag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalDocsUrl")]
        public string ExternalDocsUrl { get; set; }

        /// <summary>
        /// Gets or sets description of the external resources describing the
        /// tag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalDocsDescription")]
        public string ExternalDocsDescription { get; set; }

    }
}
