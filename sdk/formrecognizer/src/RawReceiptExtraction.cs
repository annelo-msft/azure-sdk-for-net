// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class RawReceiptExtraction
    {
        internal RawReceiptExtraction() { }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField MerchantName { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField MerchantAddress { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField MerchantPhoneNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TransactionDate { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TransactionTime { get; internal set; }

        /// <summary>
        /// </summary>
        public RawReceiptItemExtraction Items { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Subtotal { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Tax { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Tip { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Total { get; internal set; }
    }
}