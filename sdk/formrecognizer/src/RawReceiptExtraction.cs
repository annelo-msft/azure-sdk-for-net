// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class RawReceiptExtraction
    {
        internal RawReceiptExtraction() { }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantName { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantAddress { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantPhoneNumber { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TransactionDate { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TransactionTime { get; internal set; }

        /// <summary>
        /// </summary>
        public RawReceiptItemExtraction Items { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Subtotal { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Tax { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Tip { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Total { get; internal set; }
    }
}