﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Custom Form Recognizer model.
    /// </summary>
    public class TrainingResult
    {
        internal TrainingResult() { }

        /// <summary>
        /// </summary>
        public TrainedModel Model { get; internal set; }

        /// <summary>
        /// </summary>
        public ModelTrainingInfo TrainingInfo { get; internal set; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public TrainingInputResult[] TrainingInputResults { get; internal set; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public FormRecognizerError[] TrainingErrors { get; internal set; }

        internal static TrainingResult Create() => new TrainingResult();
    }
}