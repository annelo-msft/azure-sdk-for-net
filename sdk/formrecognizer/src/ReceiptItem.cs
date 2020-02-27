// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ReceiptItem
    {
        internal ReceiptItem(int quantity, string name, float totalPrice)
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