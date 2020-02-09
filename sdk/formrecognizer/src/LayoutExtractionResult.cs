// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class LayoutExtractionResult
    {
        private AnalyzeOperation operation;

        internal LayoutExtractionResult(AnalyzeOperation operation)
        {
            this.operation = operation;
        }

        /// <summary>
        /// Status of the operation.
        /// </summary>
        internal AnalysisStatus Status { get; set; }

        /// <summary>
        /// Date and time when the status was last updated.
        /// </summary>
        internal DateTimeOffset LastUpdateTime { get; set; }

        // TODO: do we need these timestamps or status for any customer scenario?

        /// <summary>
        /// Date and time when the analysis operation was submitted.
        /// </summary>
        internal DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Output of the Optical Character Recognition engine, including text
        /// elements with bounding boxes, as well as page geometry, and page and line languages.
        /// </summary>
        public RawPageExtraction[] TextDetails { get; internal set; }

        /// <summary>
        /// Table output of the enhanced Optical Character Recognition engine.
        /// </summary>
        public ExtractedTable[] ExtractedTables { get; internal set; }
    }
}