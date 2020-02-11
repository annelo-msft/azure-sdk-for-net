// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public readonly struct PageRange
    {
        internal PageRange(int startPageNumber, int endPageNumber)
        {
            StartPageNumber = startPageNumber;
            EndPageNumber = endPageNumber;
        }

        /// <summary>
        /// </summary>
        public int StartPageNumber { get; }

        /// <summary>
        /// </summary>
        public int EndPageNumber { get; }
    }
}