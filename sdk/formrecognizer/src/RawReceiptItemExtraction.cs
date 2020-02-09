// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class RawReceiptItemExtraction
    {
        internal RawReceiptItemExtraction() { }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Quantity { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Name { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TotalPrice { get; internal set; }
    }
}