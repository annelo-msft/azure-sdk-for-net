// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ExtractResult
    {
        private readonly AnalyzeOperation operation;

        internal ExtractResult(AnalyzeOperation operation, AnalysisStatus status, DateTimeOffset lastUpdateTime, DateTimeOffset creationTime, ExtractedPage[] pages)
        {
            this.operation = operation;
            Status = status;
            LastUpdateTime = lastUpdateTime;
            CreationTime = creationTime;
            Pages = pages;
            //RawPages = rawPages;
        }


        //internal ExtractResult(AnalyzeOperation operation)
        //{
        //    this.operation = operation;
        //}

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
        /// Page-level information extracted from the input.
        /// </summary>
        public ExtractedPage[] Pages { get; }

        //public RawPageExtraction[] RawPages { get;  }
    }
}