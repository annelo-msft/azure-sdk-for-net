// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// Represents an extracted word.
    /// </summary>
    public class ExtractedWord : ExtractedText
    {
        /// <summary>
        /// Confidence value in the prediction of the word.
        /// </summary>
        public float Confidence { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedWord"/> class.
        /// </summary>
        internal ExtractedWord()
        { }

        internal static ExtractedWord Create() => new ExtractedWord();
    }
}