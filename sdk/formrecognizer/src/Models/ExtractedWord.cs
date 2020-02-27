// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Represents an extracted word.
    /// </summary>
    public class ExtractedWord
    {
        internal ExtractedWord() { }

        /// <summary>
        /// Confidence value in the prediction of the word.
        /// </summary>
        public float Confidence { get; internal set; }

        /// <summary>
        /// The text content of the line.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Bounding box of the extracted line.
        /// </summary>
        public float[] BoundingBox { get; }

        /// <summary>
        /// </summary>
        /// <param name="word"></param>
        public static implicit operator string(ExtractedWord word) => word.Text;

        internal static ExtractedWord Create() => new ExtractedWord();
    }
}