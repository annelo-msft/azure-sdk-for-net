// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Information about the extracted table contained in a page.
    /// </summary>
    public class ExtractedTable
    {
        internal ExtractedTable() { }

        /// <summary>
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public ExtractedTableCell this[int i, int j]
        {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
            get { throw new NotImplementedException(); }
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
            set { throw new NotImplementedException(); }
        }

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