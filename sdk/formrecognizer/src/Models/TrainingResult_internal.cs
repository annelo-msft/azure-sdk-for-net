// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Custom model training result.
    /// </summary>
    internal class TrainingResult_internal
    {
        // TODO: Does training documents apply to both supervised and unsupervised learning?

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public TrainingInputResult[] TrainingDocumentResults { get; internal set; }

        // TODO: Does Fields apply only to supervised models?  How is this different from FormClusters?

        /// <summary>
        /// List of fields used to train the model and the train operation error reported by each.
        /// </summary>
        public PredefinedFieldAccuracy[] FieldAccuracies { get; internal set; }

        /// <summary>
        /// Average accuracy.
        /// </summary>
        public float? AverageModelAccuracy { get; internal set; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public FormRecognizerError[] Errors { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingResult_internal"/> class.
        /// </summary>
        protected TrainingResult_internal() { }

        internal static TrainingResult_internal Create() => new TrainingResult_internal();
    }
}