﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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
            FormClusterId = formClusterId;
            Fields = fields;
            Tables = tables;
        }


        /// <summary>
        /// Page number.
        /// </summary>
        public int PageNumber { get;  }

        /// <summary>
        /// Cluster identifier.
        /// </summary>
        public int FormClusterId { get;  }

        /// <summary>
        /// List of key-value pairs extracted from the page.
        /// </summary>
        public ExtractedField[] Fields { get;  }

        /// <summary>
        /// Output of the enhanced Optical Character Recognition engine, which identifies
        /// tables.
        /// </summary>
        public ExtractedTable[] Tables { get;  }
    }
}