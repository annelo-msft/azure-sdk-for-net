// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct RawReceiptItemExtraction
    {
        internal RawReceiptItemExtraction(ExtractedPredefinedField quantity, ExtractedPredefinedField name, ExtractedPredefinedField totalPrice)
        {
            Quantity = quantity;
            Name = name;
            TotalPrice = totalPrice;
        }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Quantity { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Name { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TotalPrice { get; }
    }
}