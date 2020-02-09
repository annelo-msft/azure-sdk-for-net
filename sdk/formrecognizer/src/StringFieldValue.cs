// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class StringFieldValue : ExtractedText
    {
        internal StringFieldValue() { }

        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; internal set; }

        /// <summary>
        /// The 1-based page number in the input document.
        /// </summary>
        public int PageNumber { get; internal set; }
    }
}