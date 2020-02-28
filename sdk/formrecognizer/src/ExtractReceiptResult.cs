// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    internal readonly struct ExtractReceiptResult
    {
        private readonly AnalyzeOperation operation;

        internal ExtractReceiptResult(AnalyzeOperation operation, AnalysisStatus status, DateTimeOffset lastUpdateTime, DateTimeOffset creationTime, ExtractedReceipt[] receipts)
        {
            Status = status;
            LastUpdateTime = lastUpdateTime;
            CreationTime = creationTime;
            Receipts = receipts;
            //RawPages = rawPages;

            this.operation = operation;
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
        public IReadOnlyList<ExtractedReceipt> Receipts { get; }

        //public RawPageExtraction[] RawPages { get; }
    }
}