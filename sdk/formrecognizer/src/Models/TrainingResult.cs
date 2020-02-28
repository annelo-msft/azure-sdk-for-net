// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Custom Form Recognizer model.
    /// </summary>
    internal readonly struct TrainingResult
    {
        internal TrainingResult(CustomModel model, ModelTrainingStatus trainingInfo, TrainingDocumentInfo[] trainingInputResults, FormRecognizerError[] trainingErrors)
        {
            Model = model;
            TrainingStatus = trainingInfo;
            TrainingInputResults = trainingInputResults;
            TrainingErrors = trainingErrors;
        }

        /// <summary>
        /// </summary>
        public CustomModel Model { get; }

        /// <summary>
        /// </summary>
        public ModelTrainingStatus TrainingStatus { get; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public IReadOnlyList<TrainingDocumentInfo> TrainingInputResults { get; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public IReadOnlyList<FormRecognizerError> TrainingErrors { get; }

        internal static TrainingResult Create() => new TrainingResult();
    }
}