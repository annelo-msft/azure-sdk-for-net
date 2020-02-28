// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    ///// <summary>
    ///// </summary>
    //public readonly struct ExtractLayoutResult
    //{
    //    private static AnalyzeOperation _operation;

    //    internal ExtractLayoutResult(AnalyzeOperation operation, AnalysisStatus status, DateTimeOffset lastUpdateTime, DateTimeOffset creationTime, ExtractedLayoutPage[] pages)
    //    {
    //        _operation = operation;
    //        Status = status;
    //        LastUpdateTime = lastUpdateTime;
    //        CreationTime = creationTime;
    //        Pages = pages;
    //    }

    //    /// <summary>
    //    /// Status of the operation.
    //    /// </summary>
    //    internal AnalysisStatus Status { get; }

    //    /// <summary>
    //    /// Date and time when the status was last updated.
    //    /// </summary>
    //    internal DateTimeOffset LastUpdateTime { get; }

    //    // TODO: do we need these timestamps or status for any customer scenario?

    //    /// <summary>
    //    /// Date and time when the analysis operation was submitted.
    //    /// </summary>
    //    internal DateTimeOffset CreationTime { get; }

    //    /// <summary>
    //    /// Table output of the enhanced Optical Character Recognition engine.
    //    /// </summary>
    //    public IReadOnlyList<ExtractedLayoutPage> Pages { get;  }

    //    //public RawPageExtraction[] RawPages { get;  }
    //}
}