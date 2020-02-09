// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// </summary>
    public class ExtractedPredefinedField
    {
        internal ExtractedPredefinedField() { }

        /// <summary>
        /// The name of the predefined field.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// The value of the predefined field.
        /// </summary>
        public ExtractedText Value { get; internal set; }

        /// <summary>
        /// Type of field value.
        /// </summary>
        public PredefinedFieldValueType Type { get; internal set; }

        // TODO: Should this go on Value?
        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; internal set; }
    }
}
