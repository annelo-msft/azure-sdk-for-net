// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ModelTrainingStatus
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ModelTrainingStatus(string modelId, TrainingStatus trainingStatus, DateTimeOffset? duration, DateTimeOffset? completionTime)
        {
            ModelId = modelId;
            Status = trainingStatus;
            CreatedOn = duration;
            LastUpdatedOn = completionTime;
        }

        /// <summary>
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// </summary>
        public TrainingStatus Status { get; }

        /// <summary>
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }

        /// <summary>
        /// </summary>
        public DateTimeOffset? LastUpdatedOn { get; }

        ///// <summary>
        ///// The amount of time it took to train the model.
        ///// </summary>
        //public TimeSpan? Duration { get; }

        ///// <summary>
        ///// Date and time when the model was created.
        ///// </summary>
        //public DateTimeOffset? CompletionTime { get; }
    }
}