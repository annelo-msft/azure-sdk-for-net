// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    // TODO: would it make sense to tighten the connection from this to ExtractedPage?
    // The only difference is that ExtractedPage has Fields, too.
    /// <summary>
    /// </summary>
    public readonly struct ExtractedLayoutPage
    {
        internal ExtractedLayoutPage(int pageNumber, IReadOnlyList<ExtractedTable> tables, RawExtractedPageInfo rawPageInfo)
        {
            PageNumber = pageNumber;
            Tables = tables;
            RawPageInfo = rawPageInfo;
        }

        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public IReadOnlyList<ExtractedTable> Tables { get;  }

        /// <summary>
        /// </summary>
        public RawExtractedPageInfo RawPageInfo { get; }
    }
}