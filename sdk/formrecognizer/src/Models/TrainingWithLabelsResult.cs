// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Serialization.Converters;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Custom Form Recognizer model.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct LabeledTrainingResult
#pragma warning restore SA1649 // File name should match first type name
    {
        internal LabeledTrainingResult(LabeledModel model, ModelTrainingStatus trainingInfo, TrainingInputResult[] trainingInputResults, FormRecognizerError[] trainingErrors)
        {
            Model = model;
            TrainingInfo = trainingInfo;
            TrainingInputResults = trainingInputResults;
            TrainingErrors = trainingErrors;
        }

        /// <summary>
        /// </summary>
        public LabeledModel Model { get; }

        /// <summary>
        /// </summary>
        public ModelTrainingStatus TrainingInfo { get; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public IReadOnlyList<TrainingInputResult> TrainingInputResults { get; }

        // TODO: Do field accuracies apply only to supervised models?  How is this different from FormClusters?

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public IReadOnlyList<FormRecognizerError> TrainingErrors { get; }

        internal static LabeledTrainingResult Create() => new LabeledTrainingResult();
    }
}