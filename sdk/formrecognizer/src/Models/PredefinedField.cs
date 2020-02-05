// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class PredefinedField
    {
        internal PredefinedField() { }

        /// <summary>
        /// The name of the predefined field.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// The value of the predefined field.
        /// </summary>
        public PredefinedFieldValue Value { get; internal set; }
    }
}
