// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using System;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class ModelTrainingInfo
    {
        internal ModelTrainingInfo() { }

        /// <summary>
        /// </summary>
        public string ModelId { get; internal set; }

        /// <summary>
        /// </summary>
        public TrainingStatus TrainingStatus { get; internal set; }

        /// <summary>
        /// The amount of time it took to train the model.
        /// </summary>
        public TimeSpan? Duration { get; internal set; }

        /// <summary>
        /// Date and time when the model was created.
        /// </summary>
        public DateTimeOffset? CompletionTime { get; internal set; }
    }
}