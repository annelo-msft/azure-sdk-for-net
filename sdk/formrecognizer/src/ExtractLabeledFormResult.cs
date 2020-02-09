// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;
using System;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class ExtractLabeledFormResult
    {
        private AnalyzeOperation operation;

        /// <summary>
        /// </summary>
        /// <param name="operation"></param>
        internal ExtractLabeledFormResult(AnalyzeOperation operation)
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
        /// Information extracted from each form in the input file.
        /// </summary>
        public ExtractedForm[] Forms { get; internal set; }

        // TODO: would it be better to put this in Forms?  It should go there logically, but I like having all
        // AnalysisResults having OCR output at the top level.

        /// <summary>
        /// Output of the Optical Character Recognition engine, including text
        /// elements with bounding boxes, as well as page geometry, and page and line languages.
        /// </summary>
        public RawPageExtraction[] RawPages { get; internal set; }
    }
}