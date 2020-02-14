// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public class RawReceiptItemExtraction
    {
        internal RawReceiptItemExtraction() { }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Quantity { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Name { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TotalPrice { get; internal set; }
    }
}