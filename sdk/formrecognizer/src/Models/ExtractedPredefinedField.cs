// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ExtractedPredefinedField
    {
        internal ExtractedPredefinedField(string name, string value, float[] valueBoundingBox, PredefinedFieldValueType type, float confidence)
        {
            Name = name;
            Value = value;
            ValueBoundingBox = valueBoundingBox;
            Type = type;
            Confidence = confidence;
        }

        /// <summary>
        /// The name of the predefined field.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The value of the predefined field.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// </summary>
        public float[] ValueBoundingBox { get; }

        /// <summary>
        /// Type of field value.
        /// </summary>
        public PredefinedFieldValueType Type { get; }

        // TODO: Should this go on Value?
        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; }
    }
}
