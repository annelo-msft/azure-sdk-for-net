// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class ReceiptItem
    {
        internal ReceiptItem() { }

        /// <summary>
        /// </summary>
        public int Quantity { get; internal set; }

        /// <summary>
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// </summary>
        public float TotalPrice { get; internal set; }
    }
}