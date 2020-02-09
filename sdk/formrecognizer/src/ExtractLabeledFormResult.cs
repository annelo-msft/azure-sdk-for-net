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

        /// <summary>
        /// Output of the Optical Character Recognition engine, including text
        /// elements with bounding boxes, as well as page geometry, and page and line languages.
        /// </summary>
        public ExtractedPage[] TextDetails { get; internal set; }

        // TODO: values is by form, would it make sense to have tables by form as well?
        // Would it make sense to have tables inside of FormValues, or otherwise grouped
        // together by form?  Will a table that's on two pages be split into two?

        /// <summary>
        /// List of data tables extracted from the form.
        /// </summary>
        public ExtractedTable[] ExtractedTables { get; internal set; }
    }
}