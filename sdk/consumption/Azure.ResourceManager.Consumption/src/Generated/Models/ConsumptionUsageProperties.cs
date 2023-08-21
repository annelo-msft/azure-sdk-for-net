// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Details about historical usage data that has been used for computing the recommendation. </summary>
    public partial class ConsumptionUsageProperties
    {
        /// <summary> Initializes a new instance of ConsumptionUsageProperties. </summary>
        internal ConsumptionUsageProperties()
        {
            UsageData = new Core.ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of ConsumptionUsageProperties. </summary>
        /// <param name="firstConsumptionDate"> The first usage date used for looking back for computing the recommendation. </param>
        /// <param name="lastConsumptionDate"> The last usage date used for looking back for computing the recommendation. </param>
        /// <param name="lookBackUnitType"> What the usage data values represent ex: virtual machine instance. </param>
        /// <param name="usageData"> The breakdown of historical resource usage.  The values are in the order of usage between the firstConsumptionDate and the lastConsumptionDate. </param>
        /// <param name="usageGrain"> The grain of the values represented in the usage data ex: hourly. </param>
        internal ConsumptionUsageProperties(string firstConsumptionDate, string lastConsumptionDate, string lookBackUnitType, IReadOnlyList<float> usageData, string usageGrain)
        {
            FirstConsumptionDate = firstConsumptionDate;
            LastConsumptionDate = lastConsumptionDate;
            LookBackUnitType = lookBackUnitType;
            UsageData = usageData;
            UsageGrain = usageGrain;
        }

        /// <summary> The first usage date used for looking back for computing the recommendation. </summary>
        public string FirstConsumptionDate { get; }
        /// <summary> The last usage date used for looking back for computing the recommendation. </summary>
        public string LastConsumptionDate { get; }
        /// <summary> What the usage data values represent ex: virtual machine instance. </summary>
        public string LookBackUnitType { get; }
        /// <summary> The breakdown of historical resource usage.  The values are in the order of usage between the firstConsumptionDate and the lastConsumptionDate. </summary>
        public IReadOnlyList<float> UsageData { get; }
        /// <summary> The grain of the values represented in the usage data ex: hourly. </summary>
        public string UsageGrain { get; }
    }
}
