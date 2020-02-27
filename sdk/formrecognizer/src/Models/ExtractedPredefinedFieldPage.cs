// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ExtractedPredefinedFieldPage
    {
        internal ExtractedPredefinedFieldPage(int pageNumber, ExtractedPredefinedField[] fields, ExtractedTable[] tables)
        {
            PageNumber = pageNumber;
            Fields = fields;
            Tables = tables;
        }

        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// </summary>
        public IReadOnlyList<ExtractedPredefinedField> Fields { get;  }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public IReadOnlyList<ExtractedTable> Tables { get;  }
    }
}