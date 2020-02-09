// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Prebuilt
{
    // TODO: would it make sense to tighten the connection from this to ExtractedPage?
    // The only difference is that ExtractedPage has Fields, too.
    /// <summary>
    /// </summary>
    public class ExtractedLayoutPage
    {
        internal ExtractedLayoutPage() { }

        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get; internal set; }

        /// <summary>
        /// Cluster identifier.
        /// </summary>
        public int FormClusterId { get; internal set; }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public ExtractedTable[] Tables { get; internal set; }
    }
}