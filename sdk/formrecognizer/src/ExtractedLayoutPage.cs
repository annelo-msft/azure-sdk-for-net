// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    // TODO: would it make sense to tighten the connection from this to ExtractedPage?
    // The only difference is that ExtractedPage has Fields, too.
    /// <summary>
    /// </summary>
    public readonly struct ExtractedLayoutPage
    {
        internal ExtractedLayoutPage(int pageNumber, ExtractedTable[] tables)
        {
            PageNumber = pageNumber;
            Tables = tables;
        }

        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public ExtractedTable[] Tables { get;  }
    }
}