// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Pipeline;

namespace Azure.AI.FormRecognizer.Core
{
    /// <summary>
    /// The form layout client extracts text and layout information from a given document.
    /// </summary>
    public class FormLayoutClient : AnalysisClient<AnalyzeLayoutOptions>
    {
        private const string LayoutPrefix = "/layout";

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient"/> class.
        /// </summary>
        internal FormLayoutClient(HttpPipeline pipeline, FormRecognizerClientOptions options)
            : base(pipeline, options, LayoutPrefix)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient"/> class.
        /// </summary>
        protected FormLayoutClient()
        { }
    }

    /// <summary>
    /// Options for analyzing layout.
    /// </summary>
    public struct AnalyzeLayoutOptions
    { }
}