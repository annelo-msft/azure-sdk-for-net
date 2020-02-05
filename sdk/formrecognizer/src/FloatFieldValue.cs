// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class FloatFieldValue
    {
        internal FloatFieldValue() { }

        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; internal set; }

        /// <summary>
        /// The 1-based page number in the input document.
        /// </summary>
        public int PageNumber { get; internal set; }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public dynamic Value { get; internal set; }

        /// <summary>
        /// </summary>
        public double[] BoundingBox { get; internal set; }
    }
}