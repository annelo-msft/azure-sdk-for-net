// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Report for a custom model training document.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct TrainingDocumentInfo
#pragma warning restore SA1649 // File name should match first type name
    {
        internal TrainingDocumentInfo(string documentName, int totalTrainedPages, FormRecognizerError[] trainingInputErrors, TrainingInputSuccessStatus successStatus)
        {
            DocumentName = documentName;
            TotalTrainedPages = totalTrainedPages;
            TrainingInputErrors = trainingInputErrors;
            SuccessStatus = successStatus;
        }

        /// <summary>
        /// Name of training input document.
        /// </summary>
        public string DocumentName { get; }

        /// <summary>
        /// Total number of pages trained.
        /// </summary>
        public int TotalTrainedPages { get; }

        // TODO: Are these errors about the document, or the training operation, or ... ?
        // What are the possible values of these?  Would it be better to group these with
        // training errors?  How will customers use these errors?

        // TODO: Where would it make sense to throw an exception on an error?

        /// <summary>
        /// List of errors.
        /// </summary>
        public IReadOnlyList<FormRecognizerError> TrainingInputErrors { get; }

        // TODO: What does it mean for a training document to have failed or succeeded?
        // Is this in the context of either supervised or unsupervised models, or does it apply to both?
        // What does it mean to have partially succeeded?  What will customers do with this information?

        /// <summary>
        /// Status of the training operation.
        /// </summary>
        public TrainingInputSuccessStatus SuccessStatus { get; }

        internal static TrainingDocumentInfo Create() => new TrainingDocumentInfo();
    }
}