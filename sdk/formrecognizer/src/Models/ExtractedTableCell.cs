// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer
{
    // TODO: Solve referencing problem, wherein the table cell or other element
    // points back to the raw OCR TextElement.

    /// <summary>
    /// Information about the extracted cell in a table.
    /// </summary>
    public class ExtractedTableCell : ExtractedText
    {
        internal ExtractedTableCell() { }

        /// <summary>
        /// Row index of the cell.
        /// </summary>
        public int RowIndex { get; internal set; }

        /// <summary>
        /// Column index of the cell.
        /// </summary>
        public int ColumnIndex { get; internal set; }

        /// <summary>
        /// Number of rows spanned by this cell.
        /// </summary>
        public int RowSpan { get; internal set; }

        /// <summary>
        /// Number of columns spanned by this cell.
        /// </summary>
        public int ColumnSpan { get; internal set; }

        /// <summary>
        /// Is the current cell a header cell?
        /// </summary>
        public bool IsHeader { get; internal set; }

        /// <summary>
        /// Is the current cell a footer cell?
        /// </summary>
        public bool IsFooter { get; internal set; }

        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; internal set; }

        // TODO: What is this data table for?  A cell could contain a table?
        // What is the use case for this, and is it the best representation?

        /// <summary>
        /// </summary>
        internal ExtractedTable Table { get; set; }

        internal static ExtractedTableCell Create() => new ExtractedTableCell();
    }
}