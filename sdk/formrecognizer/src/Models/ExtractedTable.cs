// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Information about the extracted table contained in a page.
    /// </summary>
    public class ExtractedTable
    {
        internal ExtractedTable() { }

        /// <summary>
        /// Number of rows.
        /// </summary>
        public int RowCount { get; internal set; }

        /// <summary>
        /// Number of columns.
        /// </summary>
        public int ColumnCount { get; internal set; }

        /// <summary>
        /// List of cells contained in the table.
        /// </summary>
        public ExtractedTableCell[] Cells { get; internal set; }

        internal static ExtractedTable Create() => new ExtractedTable();
    }
}