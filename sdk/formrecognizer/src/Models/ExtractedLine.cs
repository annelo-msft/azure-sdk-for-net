﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// Represents a line of extracted text.
    /// </summary>
    public class ExtractedLine
    {
        internal ExtractedLine() { }

        /// <summary>
        /// The detected language of the line, if different from the overall page language.
        /// </summary>
        /// <value></value>
        public FormTextLanguage Language { get; internal set; }

        /// <summary>
        /// List of words extracted from the line.
        /// </summary>
        public IList<ExtractedWord> Words { get; internal set; }

        /// <summary>
        /// The text content of the line.
        /// </summary>
        public string Text { get; internal set; }

        // TODO: Normalize BoundingBox across Cognitive

        /// <summary>
        /// Bounding box of the extracted line.
        /// </summary>
        public float[] BoundingBox { get; internal set; }


        internal static ExtractedLine Create() => new ExtractedLine();
    }
}