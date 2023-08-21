// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details of the filtering the transfer of data. </summary>
    public partial class TransferFilterDetails
    {
        /// <summary> Initializes a new instance of TransferFilterDetails. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        public TransferFilterDetails(DataAccountType dataAccountType)
        {
            DataAccountType = dataAccountType;
            FilterFileDetails = new Core.ChangeTrackingList<FilterFileDetails>();
        }

        /// <summary> Initializes a new instance of TransferFilterDetails. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        /// <param name="blobFilterDetails"> Filter details to transfer blobs. </param>
        /// <param name="azureFileFilterDetails"> Filter details to transfer Azure files. </param>
        /// <param name="filterFileDetails"> Details of the filter files to be used for data transfer. </param>
        internal TransferFilterDetails(DataAccountType dataAccountType, BlobFilterDetails blobFilterDetails, AzureFileFilterDetails azureFileFilterDetails, IList<FilterFileDetails> filterFileDetails)
        {
            DataAccountType = dataAccountType;
            BlobFilterDetails = blobFilterDetails;
            AzureFileFilterDetails = azureFileFilterDetails;
            FilterFileDetails = filterFileDetails;
        }

        /// <summary> Type of the account of data. </summary>
        public DataAccountType DataAccountType { get; set; }
        /// <summary> Filter details to transfer blobs. </summary>
        public BlobFilterDetails BlobFilterDetails { get; set; }
        /// <summary> Filter details to transfer Azure files. </summary>
        public AzureFileFilterDetails AzureFileFilterDetails { get; set; }
        /// <summary> Details of the filter files to be used for data transfer. </summary>
        public IList<FilterFileDetails> FilterFileDetails { get; }
    }
}
