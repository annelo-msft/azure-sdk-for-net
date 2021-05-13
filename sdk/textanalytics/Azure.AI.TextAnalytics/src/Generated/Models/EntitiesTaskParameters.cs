// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntitiesTaskParameters. </summary>
    internal partial class EntitiesTaskParameters
    {
        /// <summary> Initializes a new instance of EntitiesTaskParameters. </summary>
        public EntitiesTaskParameters()
        {
        }

        public string ModelVersion { get; set; }
        public bool? LoggingOptOut { get; set; }
        public StringIndexType? StringIndexType { get; set; }
    }
}
