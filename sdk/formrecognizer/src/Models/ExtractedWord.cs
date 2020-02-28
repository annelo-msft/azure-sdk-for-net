// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Represents an extracted word.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct RawExtractedWord
#pragma warning restore SA1649 // File name should match first type name
    {
        internal RawExtractedWord(float confidence, string text, float[] boundingBox)
        {
            Confidence = confidence;
            Text = text;
            BoundingBox = boundingBox;
        }

        /// <summary>
        /// Confidence value in the prediction of the word.
        /// </summary>
        public float Confidence { get; }

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
        public static implicit operator string(RawExtractedWord word) => word.Text;

        internal static RawExtractedWord Create() => new RawExtractedWord();
    }
}