// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class PredefinedFieldModel
    {
        internal PredefinedFieldModel() { }

        /// <summary>
        /// Model Id.
        /// </summary>
        public string ModelId { get; internal set; }

        /// <summary>
        /// Average accuracy.
        /// </summary>
        public float? AverageFieldAccuracy { get; internal set; }

        /// <summary>
        /// List of fields used to train the model and the train operation error reported by each.
        /// </summary>
        public LabeledFieldAccuracy[] FieldAccuracies { get; internal set; }
    }
}