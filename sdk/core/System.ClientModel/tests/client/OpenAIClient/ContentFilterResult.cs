// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace OpenAI;

/// <summary> Information about filtered content severity level and if it has been filtered or not. </summary>
public partial class ContentFilterResult
    {
        /// <summary> Initializes a new instance of ContentFilterResult. </summary>
        /// <param name="severity"> Ratings for the intensity and risk level of filtered content. </param>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        internal ContentFilterResult(ContentFilterSeverity severity, bool filtered)
        {
            Severity = severity;
            Filtered = filtered;
        }

        /// <summary> Ratings for the intensity and risk level of filtered content. </summary>
        public ContentFilterSeverity Severity { get; }
        /// <summary> A value indicating whether or not the content has been filtered. </summary>
        public bool Filtered { get; }
    }

