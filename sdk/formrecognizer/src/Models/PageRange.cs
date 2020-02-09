// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class PageRange
    {
        internal PageRange() { }

        /// <summary>
        /// </summary>
        public int StartPageNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public int EndPageNumber { get; internal set; }
    }
}