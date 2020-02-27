// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    // TODO: Solve referencing problem, wherein the table cell or other element
    // points back to the raw OCR TextElement.

    /// <summary>
    /// Information about the extracted cell in a table.
    /// </summary>
    public readonly struct ExtractedTableCell
    {
        internal ExtractedTableCell(string text, float[] boundingBox, int rowIndex, int columnIndex, int rowSpan, int columnSpan, bool isHeader, bool isFooter, float confidence, ExtractedTable table)
        {
            Text = text;
            BoundingBox = boundingBox;
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
            IsHeader = isHeader;
            IsFooter = isFooter;
            Confidence = confidence;
            Table = table;
        }

        /// <summary>
        /// The text content of the cell.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Bounding box of the extracted line.
        /// </summary>
        public float[] BoundingBox { get; }

        /// <summary>
        /// Row index of the cell.
        /// </summary>
        public int RowIndex { get;  }

        /// <summary>
        /// Column index of the cell.
        /// </summary>
        public int ColumnIndex { get;  }

        /// <summary>
        /// Number of rows spanned by this cell.
        /// </summary>
        public int RowSpan { get;  }

        /// <summary>
        /// Number of columns spanned by this cell.
        /// </summary>
        public int ColumnSpan { get;  }

        /// <summary>
        /// Is the current cell a header cell?
        /// </summary>
        public bool IsHeader { get;  }

        /// <summary>
        /// Is the current cell a footer cell?
        /// </summary>
        public bool IsFooter { get;  }

        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get;  }

        // TODO: What is this data table for?  A cell could contain a table?
        // What is the use case for this, and is it the best representation?

        /// <summary>
        /// </summary>
        internal ExtractedTable Table { get; }

        internal static ExtractedTableCell Create() => new ExtractedTableCell();
    }
}