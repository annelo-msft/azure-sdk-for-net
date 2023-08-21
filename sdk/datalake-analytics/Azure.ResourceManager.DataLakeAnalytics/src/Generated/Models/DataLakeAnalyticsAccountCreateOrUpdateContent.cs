// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters to use for creating a Data Lake Analytics account.
    /// Serialized Name: CreateDataLakeAnalyticsAccountParameters
    /// </summary>
    public partial class DataLakeAnalyticsAccountCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountCreateOrUpdateContent. </summary>
        /// <param name="location">
        /// The resource location.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.location
        /// </param>
        /// <param name="defaultDataLakeStoreAccount">
        /// The default Data Lake Store account associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.defaultDataLakeStoreAccount
        /// </param>
        /// <param name="dataLakeStoreAccounts">
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.dataLakeStoreAccounts
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultDataLakeStoreAccount"/> or <paramref name="dataLakeStoreAccounts"/> is null. </exception>
        public DataLakeAnalyticsAccountCreateOrUpdateContent(AzureLocation location, string defaultDataLakeStoreAccount, IEnumerable<DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent> dataLakeStoreAccounts)
        {
            Argument.AssertNotNull(defaultDataLakeStoreAccount, nameof(defaultDataLakeStoreAccount));
            Argument.AssertNotNull(dataLakeStoreAccounts, nameof(dataLakeStoreAccounts));

            Location = location;
            Tags = new Core.ChangeTrackingDictionary<string, string>();
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            DataLakeStoreAccounts = dataLakeStoreAccounts.ToList();
            StorageAccounts = new Core.ChangeTrackingList<StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent>();
            ComputePolicies = new Core.ChangeTrackingList<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>();
            FirewallRules = new Core.ChangeTrackingList<FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent>();
        }

        /// <summary>
        /// The resource location.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.location
        /// </summary>
        public AzureLocation Location { get; }
        /// <summary>
        /// The resource tags.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The default Data Lake Store account associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.defaultDataLakeStoreAccount
        /// </summary>
        public string DefaultDataLakeStoreAccount { get; }
        /// <summary>
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.dataLakeStoreAccounts
        /// </summary>
        public IList<DataLakeStoreForDataLakeAnalyticsAccountCreateOrUpdateContent> DataLakeStoreAccounts { get; }
        /// <summary>
        /// The list of Azure Blob Storage accounts associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.storageAccounts
        /// </summary>
        public IList<StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent> StorageAccounts { get; }
        /// <summary>
        /// The list of compute policies associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.computePolicies
        /// </summary>
        public IList<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent> ComputePolicies { get; }
        /// <summary>
        /// The list of firewall rules associated with this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.firewallRules
        /// </summary>
        public IList<FirewallRuleForDataLakeAnalyticsAccountCreateOrUpdateContent> FirewallRules { get; }
        /// <summary>
        /// The current state of the IP address firewall for this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.firewallState
        /// </summary>
        public DataLakeAnalyticsFirewallState? FirewallState { get; set; }
        /// <summary>
        /// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.firewallAllowAzureIps
        /// </summary>
        public DataLakeAnalyticsFirewallAllowAzureIPsState? FirewallAllowAzureIPs { get; set; }
        /// <summary>
        /// The commitment tier for the next month.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.newTier
        /// </summary>
        public DataLakeAnalyticsCommitmentTierType? NewTier { get; set; }
        /// <summary>
        /// The maximum supported jobs running under the account at the same time.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.maxJobCount
        /// </summary>
        public int? MaxJobCount { get; set; }
        /// <summary>
        /// The maximum supported degree of parallelism for this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelism
        /// </summary>
        public int? MaxDegreeOfParallelism { get; set; }
        /// <summary>
        /// The maximum supported degree of parallelism per job for this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.maxDegreeOfParallelismPerJob
        /// </summary>
        public int? MaxDegreeOfParallelismPerJob { get; set; }
        /// <summary>
        /// The minimum supported priority per job for this account.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.minPriorityPerJob
        /// </summary>
        public int? MinPriorityPerJob { get; set; }
        /// <summary>
        /// The number of days that job metadata is retained.
        /// Serialized Name: CreateDataLakeAnalyticsAccountParameters.properties.queryStoreRetention
        /// </summary>
        public int? QueryStoreRetention { get; set; }
    }
}
