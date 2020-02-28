// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
//    /// <summary>
//    /// </summary>
//#pragma warning disable SA1649 // File name should match first type name
//    public readonly struct ExtractLabeledResult
//#pragma warning restore SA1649 // File name should match first type name
//    {
//        private readonly AnalyzeOperation operation;

//        internal ExtractLabeledResult(AnalyzeOperation operation, AnalysisStatus status, DateTimeOffset lastUpdateTime, DateTimeOffset creationTime, ExtractedLabeledForm[] forms)
//        {
//            this.operation = operation;
//            Status = status;
//            LastUpdateTime = lastUpdateTime;
//            CreationTime = creationTime;
//            Forms = forms;
//        }


//        /// <summary>
//        /// Status of the operation.
//        /// </summary>
//        internal AnalysisStatus Status { get; }

//        /// <summary>
//        /// Date and time when the status was last updated.
//        /// </summary>
//        internal DateTimeOffset LastUpdateTime { get; }

//        // TODO: do we need these timestamps or status for any customer scenario?

//        /// <summary>
//        /// Date and time when the analysis operation was submitted.
//        /// </summary>
//        internal DateTimeOffset CreationTime { get; }

//        /// <summary>
//        /// Information extracted from each form in the input file.
//        /// </summary>
//        public IReadOnlyList<ExtractedLabeledForm> Forms { get;  }

//        // TODO: would it be better to put this in Forms?  It should go there logically, but I like having all
//        // AnalysisResults having OCR output at the top level.

//        //public RawPageExtraction[] RawPages { get;  }
//    }
}