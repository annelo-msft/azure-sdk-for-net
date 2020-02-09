// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class ExtractedReceipt
    {
        internal ExtractedReceipt() { }

        /// <summary>
        /// </summary>
        public ReceiptType ReceiptType { get; internal set; }

        /// <summary>
        /// </summary>
        public string MerchantName { get; internal set; }

        /// <summary>
        /// </summary>
        public string MerchantAddress { get; internal set; }

        /// <summary>
        /// </summary>
        public string MerchantPhoneNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public DateTime TransactionDate { get; internal set; }

        /// <summary>
        /// </summary>
        public DateTime TransactionTime { get; internal set; }

        /// <summary>
        /// </summary>
        public ReceiptItem[] Items { get; internal set; }

        /// <summary>
        /// </summary>
        public float Subtotal { get; internal set; }

        /// <summary>
        /// </summary>
        public float Tax { get; internal set; }

        /// <summary>
        /// </summary>
        public float Tip { get; internal set; }

        /// <summary>
        /// </summary>
        public float Total { get; internal set; }

        /// <summary>
        /// </summary>
        public RawReceiptExtraction RawFields { get; internal set; }
    }
}
