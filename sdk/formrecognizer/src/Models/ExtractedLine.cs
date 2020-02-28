// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Represents a line of extracted text.
    /// </summary>
    public readonly struct ExtractedLine
    {
        internal ExtractedLine(string language, string text, float[] boundingBox, IReadOnlyList<ExtractedWord> words)
        {
            Language = language;
            Text = text;
            BoundingBox = boundingBox;
            Words = words;
        }

        /// <summary>
        /// The detected language of the line, if different from the overall page language.
        /// </summary>
        /// <value></value>
        public string Language { get;  }

        /// <summary>
        /// The text content of the line.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Bounding box of the extracted line.
        /// </summary>
        public float[] BoundingBox { get; }

        /// <summary>
        /// List of words extracted from the line.
        /// </summary>
        public IReadOnlyList<ExtractedWord> Words { get; }

        internal static ExtractedLine Create() => new ExtractedLine();
    }
}