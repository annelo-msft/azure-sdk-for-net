// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Response of pre job creation validations. </summary>
    public partial class DataBoxValidationResult
    {
        /// <summary> Initializes a new instance of DataBoxValidationResult. </summary>
        internal DataBoxValidationResult()
        {
            IndividualResponseDetails = new Core.ChangeTrackingList<DataBoxValidationInputResult>();
        }

        /// <summary> Initializes a new instance of DataBoxValidationResult. </summary>
        /// <param name="status"> Overall validation status. </param>
        /// <param name="individualResponseDetails">
        /// List of response details contain validationType and its response as key and value respectively.
        /// Please note <see cref="DataBoxValidationInputResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationResult"/>, <see cref="DataTransferDetailsValidationResult"/>, <see cref="PreferencesValidationResult"/>, <see cref="SkuAvailabilityValidationResult"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationResult"/> and <see cref="AddressValidationResult"/>.
        /// </param>
        internal DataBoxValidationResult(OverallValidationStatus? status, IReadOnlyList<DataBoxValidationInputResult> individualResponseDetails)
        {
            Status = status;
            IndividualResponseDetails = individualResponseDetails;
        }

        /// <summary> Overall validation status. </summary>
        public OverallValidationStatus? Status { get; }
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// Please note <see cref="DataBoxValidationInputResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationResult"/>, <see cref="DataTransferDetailsValidationResult"/>, <see cref="PreferencesValidationResult"/>, <see cref="SkuAvailabilityValidationResult"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationResult"/> and <see cref="AddressValidationResult"/>.
        /// </summary>
        public IReadOnlyList<DataBoxValidationInputResult> IndividualResponseDetails { get; }
    }
}
