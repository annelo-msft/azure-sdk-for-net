// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Information about the extracted table contained in a page.
    /// </summary>
    public readonly struct ExtractedTable
    {
        internal ExtractedTable(int rowCount, int columnCount, ExtractedTableCell[] cells)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Cells = cells;
        }

        /// <summary>
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
#pragma warning disable CA1822 // Does not access instance data
        public ExtractedTableCell this[int i, int j]
#pragma warning restore CA1822 // Does not access instance data
        {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
            get { throw new NotImplementedException(); }
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Number of rows.
        /// </summary>
        public int RowCount { get; }

        /// <summary>
        /// Number of columns.
        /// </summary>
        public int ColumnCount { get; }

        /// <summary>
        /// List of cells contained in the table.
        /// </summary>
        public ExtractedTableCell[] Cells { get; }

        internal static ExtractedTable Create() => new ExtractedTable();
    }
}