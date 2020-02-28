// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Page information extracted by an unsupervised model.
    /// </summary>
    public readonly struct ExtractedPage
    {
        internal ExtractedPage(int pageNumber, int formClusterId, ExtractedField[] fields, ExtractedTable[] tables)
        {
            PageNumber = pageNumber;
            RecognizedFormId = formClusterId;
            Fields = fields;
            Tables = tables;
        }


        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// </summary>
        public int RecognizedFormId { get;  }

        /// <summary>
        /// List of key-value pairs extracted from the page.
        /// </summary>
        public IReadOnlyList<ExtractedField> Fields { get;  }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public IReadOnlyList<ExtractedTable> Tables { get;  }
    }
}