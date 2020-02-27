// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct RawReceiptExtraction
    {
        internal RawReceiptExtraction(ExtractedPredefinedField merchantName, ExtractedPredefinedField merchantAddress, ExtractedPredefinedField merchantPhoneNumber, ExtractedPredefinedField transactionDate, ExtractedPredefinedField transactionTime, RawReceiptItemExtraction items, ExtractedPredefinedField subtotal, ExtractedPredefinedField tax, ExtractedPredefinedField tip, ExtractedPredefinedField total)
        {
            MerchantName = merchantName;
            MerchantAddress = merchantAddress;
            MerchantPhoneNumber = merchantPhoneNumber;
            TransactionDate = transactionDate;
            TransactionTime = transactionTime;
            Items = items;
            Subtotal = subtotal;
            Tax = tax;
            Tip = tip;
            Total = total;
        }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantName { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantAddress { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField MerchantPhoneNumber { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TransactionDate { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField TransactionTime { get; }

        /// <summary>
        /// </summary>
        public RawReceiptItemExtraction Items { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Subtotal { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Tax { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Tip { get; }

        /// <summary>
        /// </summary>
        public ExtractedPredefinedField Total { get; }
    }
}