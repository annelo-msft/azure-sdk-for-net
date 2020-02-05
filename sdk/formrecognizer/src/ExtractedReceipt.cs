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

        // TODO: It would be better to have these properties be strongly typed
        // rather than being a predefined field value.  But they need the confidence
        // values attached!  Think more about this.

        /// <summary>
        /// </summary>
        public StringFieldValue MerchantName { get; internal set; }

        /// <summary>
        /// </summary>
        public StringFieldValue MerchantAddress { get; internal set; }

        /// <summary>
        /// </summary>
        public StringFieldValue MerchantPhoneNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public DateTimeFieldValue TransactionDate { get; internal set; }

        /// <summary>
        /// </summary>
        public DateTimeFieldValue TransactionTime { get; internal set; }

        /// <summary>
        /// </summary>
        public ReceiptItem[] Items { get; internal set; }

        /// <summary>
        /// </summary>
        public FloatFieldValue Subtotal { get; internal set; }

        /// <summary>
        /// </summary>
        public FloatFieldValue Tax { get; internal set; }

        /// <summary>
        /// </summary>
        public FloatFieldValue Tip { get; internal set; }

        /// <summary>
        /// </summary>
        public FloatFieldValue Total { get; internal set; }
    }
}
