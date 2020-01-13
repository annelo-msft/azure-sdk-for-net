// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json.Serialization;
using Azure.AI.FormRecognizer.Serialization;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Status and result of an analysis operation.
    /// </summary>
    [JsonConverter(typeof(AnalysisJsonConverter))]
    public class Analysis
    {
        /// <summary>
        /// Status of the operation.
        /// </summary>
        public AnalysisStatus Status { get; internal set; }

        /// <summary>
        /// Date and time when the analysis operation was submitted.
        /// </summary>
        public DateTimeOffset CreatedDateTime { get; internal set; }

        /// <summary>
        /// Date and time when the status was last updated.
        /// </summary>
        public DateTimeOffset LastUpdatedDateTime { get; internal set; }

        /// <summary>
        /// Results of the analyze operation.
        /// </summary>
        public AnalysisResult AnalyzeResult { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Analysis"/> class.
        /// </summary>
        protected Analysis()
        { }

        internal static Analysis Create() => new Analysis();
    }
}