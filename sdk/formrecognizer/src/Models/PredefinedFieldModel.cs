// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct CustomLabeledModel
#pragma warning restore SA1649 // File name should match first type name
    {
        internal CustomLabeledModel(string modelId, float? averageFieldAccuracy, LabeledFieldAccuracy[] fieldAccuracies, ModelTrainingStatus trainingStatus, TrainingInfo trainingInfo)
        {
            ModelId = modelId;
            AverageFieldAccuracy = averageFieldAccuracy;
            FieldAccuracies = fieldAccuracies;
            TrainingStatus = trainingStatus;
            TrainingInfo = trainingInfo;
        }

        /// <summary>
        /// Model Id.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// Average accuracy.
        /// </summary>
        public float? AverageFieldAccuracy { get; }

        /// <summary>
        /// List of fields used to train the model and the train operation error reported by each.
        /// </summary>
        public LabeledFieldAccuracy[] FieldAccuracies { get; }

        /// <summary>
        /// </summary>
        public ModelTrainingStatus TrainingStatus { get; }

        /// <summary>
        /// </summary>
        public TrainingInfo TrainingInfo { get; }
    }
}