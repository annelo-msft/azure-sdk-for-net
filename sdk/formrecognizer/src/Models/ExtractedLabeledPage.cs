// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class ExtractedLabeledPage
    {
        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField[] Fields { get; internal set; }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public ExtractedTable[] Tables { get; internal set; }
    }
}