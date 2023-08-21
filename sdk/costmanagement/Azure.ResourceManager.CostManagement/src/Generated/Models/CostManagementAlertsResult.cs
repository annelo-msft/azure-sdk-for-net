// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of alerts. </summary>
    internal partial class CostManagementAlertsResult
    {
        /// <summary> Initializes a new instance of CostManagementAlertsResult. </summary>
        internal CostManagementAlertsResult()
        {
            Value = new Core.ChangeTrackingList<CostManagementAlertData>();
        }

        /// <summary> Initializes a new instance of CostManagementAlertsResult. </summary>
        /// <param name="value"> List of alerts. </param>
        /// <param name="nextLink"> URL to get the next set of alerts results if there are any. </param>
        internal CostManagementAlertsResult(IReadOnlyList<CostManagementAlertData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of alerts. </summary>
        public IReadOnlyList<CostManagementAlertData> Value { get; }
        /// <summary> URL to get the next set of alerts results if there are any. </summary>
        public string NextLink { get; }
    }
}
