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
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ExtractedLabeledField
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ExtractedLabeledField(string label, string value, float[] valueBoundingBox, LabeledFieldValueType type, float confidence, RawExtractedLine rawExtractedField)
        {
            Label = label;
            Value = value;
            ValueBoundingBox = valueBoundingBox;
            Type = type;
            Confidence = confidence;
            RawFieldExtraction = rawExtractedField;
        }

        /// <summary>
        /// The name of the predefined field.
        /// </summary>
        public string Label { get; }

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
        public LabeledFieldValueType Type { get; }

        // TODO: Should this go on Value?
        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; }

        /// <summary>
        /// </summary>
        public RawExtractedLine RawFieldExtraction { get; }
    }
}
