// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Serialization.Converters;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// Custom Form Recognizer model.
    /// </summary>
    internal class UnsupervisedTrainingResult_internal
    {
        internal UnsupervisedTrainingResult_internal() { }

        /// <summary>
        /// Model Id.
        /// </summary>
        public string ModelId { get; internal set; }

        // TODO: Note this is internal because only used internally -- operation status can
        // be gotten from the operation. Is there a better way to represent this?
        /// <summary>
        /// Model status.
        /// </summary>
        internal TrainingStatus Status { get; set; }

        /// <summary>
        /// Date and time when the status was last updated.
        /// </summary>
        internal DateTimeOffset LastUpdateTime { get; set; }

        /// <summary>
        /// Date and time when the model was created.
        /// </summary>
        public DateTimeOffset CreationTime { get; internal set; }

        /// <summary>
        /// Keys extracted by the custom model.
        /// </summary>
        // TODO: Question - will this be populated for supervised models?
        // If not, we should probably break FRCustomModel into supervised and unsupervised custom models.s
        public ICollection<CustomModelKnownForm> FormClusters { get; internal set; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public TrainingDocumentInfo[] DocumentTrainingResults { get; internal set; }

        // TODO: Do field accuracies apply only to supervised models?  How is this different from FormClusters?

        /// <summary>
        /// List of fields used to train the model and the train operation error reported by each.
        /// </summary>
        public LabeledFieldAccuracy[] FieldAccuracies { get; internal set; }

        /// <summary>
        /// Average accuracy.
        /// </summary>
        public float? AverageModelAccuracy { get; internal set; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public FormRecognizerError[] Errors { get; internal set; }

        internal static UnsupervisedTrainingResult_internal Create() => new UnsupervisedTrainingResult_internal();
    }
}