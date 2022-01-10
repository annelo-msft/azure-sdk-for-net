// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedInstanceLongTermRetentionPolicy data model. </summary>
    public partial class ManagedInstanceLongTermRetentionPolicyData : Resource
    {
        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionPolicyData. </summary>
        public ManagedInstanceLongTermRetentionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="weeklyRetention"> The weekly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="monthlyRetention"> The monthly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="yearlyRetention"> The yearly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="weekOfYear"> The week of year to take the yearly backup in an ISO 8601 format. </param>
        internal ManagedInstanceLongTermRetentionPolicyData(ResourceIdentifier id, string name, ResourceType type, string weeklyRetention, string monthlyRetention, string yearlyRetention, int? weekOfYear) : base(id, name, type)
        {
            WeeklyRetention = weeklyRetention;
            MonthlyRetention = monthlyRetention;
            YearlyRetention = yearlyRetention;
            WeekOfYear = weekOfYear;
        }

        /// <summary> The weekly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string WeeklyRetention { get; set; }
        /// <summary> The monthly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string MonthlyRetention { get; set; }
        /// <summary> The yearly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string YearlyRetention { get; set; }
        /// <summary> The week of year to take the yearly backup in an ISO 8601 format. </summary>
        public int? WeekOfYear { get; set; }
    }
}
