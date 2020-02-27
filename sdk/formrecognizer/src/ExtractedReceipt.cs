// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ExtractedReceipt
    {
        internal ExtractedReceipt(ReceiptType receiptType, string merchantName, string merchantAddress, string merchantPhoneNumber, DateTime transactionDate, DateTime transactionTime, ReceiptItem[] items, float subtotal, float tax, float tip, float total, RawReceiptExtraction rawFields)
        {
            ReceiptType = receiptType;
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
            RawFields = rawFields;
        }

        /// <summary>
        /// </summary>
        public ReceiptType ReceiptType { get;  }

        /// <summary>
        /// </summary>
        public string MerchantName { get;  }

        /// <summary>
        /// </summary>
        public string MerchantAddress { get;  }

        /// <summary>
        /// </summary>
        public string MerchantPhoneNumber { get;  }

        /// <summary>
        /// </summary>
        public DateTime TransactionDate { get;  }

        /// <summary>
        /// </summary>
        public DateTime TransactionTime { get;  }

        /// <summary>
        /// </summary>
        public ReceiptItem[] Items { get;  }

        /// <summary>
        /// </summary>
        public float Subtotal { get;  }

        /// <summary>
        /// </summary>
        public float Tax { get;  }

        /// <summary>
        /// </summary>
        public float Tip { get;  }

        /// <summary>
        /// </summary>
        public float Total { get;  }

        /// <summary>
        /// </summary>
        public RawReceiptExtraction RawFields { get;  }
    }
}
