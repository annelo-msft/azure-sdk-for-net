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
    public class TrainingWithLabelsResult
    {
        internal TrainingWithLabelsResult() { }

        /// <summary>
        /// </summary>
        public PredefinedFieldModel Model { get; internal set; }

        /// <summary>
        /// </summary>
        public ModelTrainingInfo TrainingInfo { get; internal set; }

        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        public TrainingInputResult[] TrainingInputResults { get; internal set; }

        // TODO: Do field accuracies apply only to supervised models?  How is this different from FormClusters?

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public FormRecognizerError[] TrainingErrors { get; internal set; }

        internal static TrainingWithLabelsResult Create() => new TrainingWithLabelsResult();
    }
}