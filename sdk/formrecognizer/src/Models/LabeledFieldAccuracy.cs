// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Report for a custom model training field.
    /// </summary>
    public readonly struct LabeledFieldAccuracy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledFieldAccuracy"/> class.
        /// </summary>
        internal LabeledFieldAccuracy(string fieldName, float accuracy)
        {
            FieldName = fieldName;
            Accuracy = accuracy;
        }

        /// <summary>
        /// Training field name.
        /// </summary>
        public string FieldName { get; }

        // TODO: How is Accuracy different from Confidence?

        /// <summary>
        /// Estimated extraction accuracy for this field.
        /// </summary>
        public float Accuracy { get; }

    }
}