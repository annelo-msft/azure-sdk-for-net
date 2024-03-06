// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> A table object consisting table cells arranged in a rectangular layout. </summary>
    public partial class DocumentTable
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DocumentTable"/>. </summary>
        /// <param name="rowCount"> Number of rows in the table. </param>
        /// <param name="columnCount"> Number of columns in the table. </param>
        /// <param name="cells"> Cells contained within the table. </param>
        /// <param name="spans"> Location of the table in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cells"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentTable(int rowCount, int columnCount, IEnumerable<DocumentTableCell> cells, IEnumerable<DocumentSpan> spans)
        {
            if (cells == null)
            {
                throw new ArgumentNullException(nameof(cells));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            RowCount = rowCount;
            ColumnCount = columnCount;
            Cells = cells.ToList();
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Footnotes = new ChangeTrackingList<DocumentFootnote>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTable"/>. </summary>
        /// <param name="rowCount"> Number of rows in the table. </param>
        /// <param name="columnCount"> Number of columns in the table. </param>
        /// <param name="cells"> Cells contained within the table. </param>
        /// <param name="boundingRegions"> Bounding regions covering the table. </param>
        /// <param name="spans"> Location of the table in the reading order concatenated content. </param>
        /// <param name="caption"> Caption associated with the table. </param>
        /// <param name="footnotes"> List of footnotes associated with the table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentTable(int rowCount, int columnCount, IReadOnlyList<DocumentTableCell> cells, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, DocumentCaption caption, IReadOnlyList<DocumentFootnote> footnotes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Cells = cells;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Caption = caption;
            Footnotes = footnotes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTable"/> for deserialization. </summary>
        internal DocumentTable()
        {
        }

        /// <summary> Number of rows in the table. </summary>
        public int RowCount { get; }
        /// <summary> Number of columns in the table. </summary>
        public int ColumnCount { get; }
        /// <summary> Cells contained within the table. </summary>
        public IReadOnlyList<DocumentTableCell> Cells { get; }
        /// <summary> Bounding regions covering the table. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the table in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Caption associated with the table. </summary>
        public DocumentCaption Caption { get; }
        /// <summary> List of footnotes associated with the table. </summary>
        public IReadOnlyList<DocumentFootnote> Footnotes { get; }
    }
}
