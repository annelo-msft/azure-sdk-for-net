﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Output of the Optical Character Recognition engine, including text
    /// elements with bounding boxes, as well as page geometry, and page and line languages.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public class RawExtractedPageInfo
#pragma warning restore SA1649 // File name should match first type name
    {
        internal RawExtractedPageInfo() { }

        /// <summary>
        /// The 1-based page number in the input document.
        /// </summary>
        public int PageNumber { get; internal set; }

        /// <summary>
        /// The general orientation of the text in clockwise direction, measured in degrees between (-180, 180].
        /// </summary>
        public float TextAngle { get; internal set; }

        /// <summary>
        /// The width of the image/PDF in pixels/inches, respectively.
        /// </summary>
        public float PageWidth { get; internal set; }

        /// <summary>
        /// The height of the image/PDF in pixels/inches, respectively.
        /// </summary>
        public float PageHeight { get; internal set; }

        /// <summary>
        /// The unit of length used by the width, height and boundingBox properties.
        ///
        /// For images, the unit is "pixel". For PDF, the unit is "inch".
        /// </summary>
        public FormDimensionUnit Unit { get; internal set; }

        /// <summary>
        /// The detected language on the page overall.
        /// </summary>
        public string Language { get; internal set; }

        /// <summary>
        /// When includeTextDetails is set to true, a list of recognized text lines. The maximum number of lines returned is 300 per page.
        ///
        /// The lines are sorted top to bottom, left to right, although in certain cases proximity is treated with higher priority.
        /// As the sorting order depends on the detected text, it may change across images and OCR version updates. Thus, business logic
        /// should be built upon the actual line location instead of order.
        /// </summary>
        //public IReadOnlyList<ExtractedLine> Lines { get; internal set; }


        internal static RawExtractedPageInfo Create() => new RawExtractedPageInfo();
    }
}