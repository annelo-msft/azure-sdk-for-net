// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ExtractedLabeledPage
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ExtractedLabeledPage(int pageNumber, ExtractedLabeledField[] fields, ExtractedTable[] tables, RawExtractedPageInfo pageInfo)
        {
            PageNumber = pageNumber;
            Fields = fields;
            Tables = tables;
            RawPageInfo = pageInfo;
        }

        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// </summary>
        public IReadOnlyList<ExtractedLabeledField> Fields { get;  }

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