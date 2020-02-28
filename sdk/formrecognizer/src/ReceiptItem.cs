// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ExtractedReceiptItem
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ExtractedReceiptItem(int quantity, string name, float totalPrice)
        {
            Quantity = quantity;
            Name = name;
            TotalPrice = totalPrice;
        }

        /// <summary>
        /// </summary>
        public int Quantity { get; }

        /// <summary>
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// </summary>
        public float TotalPrice { get; }
    }
}