// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ExtractedForm
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly AnalyzeOperation operation;

        internal ExtractedForm(AnalyzeOperation operation, AnalysisStatus status, DateTimeOffset lastUpdateTime, DateTimeOffset creationTime, int recognizedFormId, IReadOnlyList<ExtractedPage> pages)
        {
            this.operation = operation;
            Status = status;
            LastUpdateTime = lastUpdateTime;
            CreationTime = creationTime;
            KnownFormId = recognizedFormId;
            Pages = pages;
        }

        /// <summary>
        /// Status of the operation.
        /// </summary>
        internal AnalysisStatus Status { get; }

        /// <summary>
        /// Date and time when the status was last updated.
        /// </summary>
        internal DateTimeOffset LastUpdateTime { get; }

        // TODO: do we need these timestamps or status for any customer scenario?

        /// <summary>
        /// Date and time when the analysis operation was submitted.
        /// </summary>
        internal DateTimeOffset CreationTime { get; }

        /// <summary>
        /// </summary>
        public int KnownFormId { get; }

        /// <summary>
        /// Page-level information extracted from the input.
        /// </summary>
        public IReadOnlyList<ExtractedPage> Pages { get; }

        //public RawPageExtraction[] RawPages { get;  }
    }
}