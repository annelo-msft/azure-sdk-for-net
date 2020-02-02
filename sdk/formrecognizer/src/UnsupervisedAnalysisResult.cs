﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Prediction
{
    /// <summary>
    /// </summary>
    public class UnsupervisedAnalysisResult
    {
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
        /// Page-level information extracted from the input.
        /// </summary>
        public UnsupervisedExtractedPageFields[] PageValues { get; internal set; }

        /// <summary>
        /// Raw output of the Optical Character Recognition engine, including text
        /// elements with bounding boxes, as well as page geometry, and page and line languages.
        /// </summary>
        public ExtractedPageText[] RawPageText { get; internal set; }
    }
}