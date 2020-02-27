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
    public readonly struct TrainingWithLabelsResult
    {
        internal TrainingWithLabelsResult(PredefinedFieldModel model, ModelTrainingInfo trainingInfo, TrainingInputResult[] trainingInputResults, FormRecognizerError[] trainingErrors)
        {
            Model = model;
            TrainingInfo = trainingInfo;
            TrainingInputResults = trainingInputResults;
            TrainingErrors = trainingErrors;
        }

        /// <summary>
        /// </summary>
        public PredefinedFieldModel Model { get; }

        /// <summary>
        /// </summary>
        public ModelTrainingInfo TrainingInfo { get; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public IReadOnlyList<TrainingInputResult> TrainingInputResults { get; }

        // TODO: Do field accuracies apply only to supervised models?  How is this different from FormClusters?

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public IReadOnlyList<FormRecognizerError> TrainingErrors { get; }

        internal static TrainingWithLabelsResult Create() => new TrainingWithLabelsResult();
    }
}