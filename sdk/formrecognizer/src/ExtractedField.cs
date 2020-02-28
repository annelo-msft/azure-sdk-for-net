// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ExtractedField
    {
        internal ExtractedField(string label, string name, float[] nameBoundingBox, string value, float[] valueBoundingBox, float confidence, RawExtractedLine rawLineExtraction)
        {
            Label = label;
            Name = name;
            NameBoundingBox = nameBoundingBox;
            Value = value;
            ValueBoundingBox = valueBoundingBox;
            Confidence = confidence;
            RawFieldExtraction = rawLineExtraction;
        }

        // TODO: What is the value of label if this is only in unsupervised learning?
        // Or is this used for supervised learning as well?


        // TODO: Label doesn't make sense on a field from an unsupervised model. Hint?
        /// <summary>
        /// A user defined label for the key/value pair entry.
        /// </summary>
        internal string Label
        { get; }

        /// <summary>
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// </summary>
        public float[] NameBoundingBox { get; }

        /// <summary>
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// </summary>
        public float[] ValueBoundingBox { get; }

        // TODO: Should Confidence go on BoundedText?  Should it be ExtractedText?
        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; }

        /// <summary>
        /// </summary>
        public RawExtractedLine RawFieldExtraction { get; }
    }
}