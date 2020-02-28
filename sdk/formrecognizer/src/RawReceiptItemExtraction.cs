// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct RawReceiptItemExtraction
    {
        internal RawReceiptItemExtraction(ExtractedLabeledField quantity, ExtractedLabeledField name, ExtractedLabeledField totalPrice)
        {
            Quantity = quantity;
            Name = name;
            TotalPrice = totalPrice;
        }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Quantity { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Name { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TotalPrice { get; }
    }
}