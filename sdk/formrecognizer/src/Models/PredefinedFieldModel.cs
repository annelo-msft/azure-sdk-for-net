// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct LabeledModel
#pragma warning restore SA1649 // File name should match first type name
    {
        internal LabeledModel(string modelId, float? averageFieldAccuracy, LabeledFieldAccuracy[] fieldAccuracies)
        {
            ModelId = modelId;
            AverageFieldAccuracy = averageFieldAccuracy;
            FieldAccuracies = fieldAccuracies;
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
    }
}