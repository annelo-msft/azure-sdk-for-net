// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using System;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public readonly struct ModelTrainingInfo
    {
        internal ModelTrainingInfo(string modelId, TrainingStatus trainingStatus, TimeSpan? duration, DateTimeOffset? completionTime)
        {
            ModelId = modelId;
            TrainingStatus = trainingStatus;
            Duration = duration;
            CompletionTime = completionTime;
        }

        /// <summary>
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// </summary>
        public TrainingStatus TrainingStatus { get; }

        /// <summary>
        /// The amount of time it took to train the model.
        /// </summary>
        public TimeSpan? Duration { get; }

        /// <summary>
        /// Date and time when the model was created.
        /// </summary>
        public DateTimeOffset? CompletionTime { get; }
    }
}