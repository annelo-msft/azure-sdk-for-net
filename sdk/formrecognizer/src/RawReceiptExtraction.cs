// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct RawReceiptExtraction
    {
        internal RawReceiptExtraction(ExtractedLabeledField merchantName, ExtractedLabeledField merchantAddress, ExtractedLabeledField merchantPhoneNumber, ExtractedLabeledField transactionDate, ExtractedLabeledField transactionTime, RawReceiptItemExtraction items, ExtractedLabeledField subtotal, ExtractedLabeledField tax, ExtractedLabeledField tip, ExtractedLabeledField total)
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
        public ExtractedLabeledField MerchantName { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField MerchantAddress { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField MerchantPhoneNumber { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TransactionDate { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField TransactionTime { get; }

        /// <summary>
        /// </summary>
        public RawReceiptItemExtraction Items { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Subtotal { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Tax { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Tip { get; }

        /// <summary>
        /// </summary>
        public ExtractedLabeledField Total { get; }
    }
}