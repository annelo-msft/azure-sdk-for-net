// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Subscription Accept Ownership Response. </summary>
    public partial class AcceptOwnershipStatus
    {
        /// <summary> Initializes a new instance of AcceptOwnershipStatus. </summary>
        internal AcceptOwnershipStatus()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AcceptOwnershipStatus. </summary>
        /// <param name="subscriptionId"> Newly created subscription Id. </param>
        /// <param name="acceptOwnershipState"> The accept ownership state of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="billingOwner"> UPN of the billing owner. </param>
        /// <param name="subscriptionTenantId"> Tenant Id of the subscription. </param>
        /// <param name="displayName"> The display name of the subscription. </param>
        /// <param name="tags"> Tags for the subscription. </param>
        internal AcceptOwnershipStatus(string subscriptionId, AcceptOwnershipState? acceptOwnershipState, AcceptOwnershipProvisioningState? provisioningState, string billingOwner, Guid? subscriptionTenantId, string displayName, IReadOnlyDictionary<string, string> tags)
        {
            SubscriptionId = subscriptionId;
            AcceptOwnershipState = acceptOwnershipState;
            ProvisioningState = provisioningState;
            BillingOwner = billingOwner;
            SubscriptionTenantId = subscriptionTenantId;
            DisplayName = displayName;
            Tags = tags;
        }

        /// <summary> Newly created subscription Id. </summary>
        public string SubscriptionId { get; }
        /// <summary> The accept ownership state of the resource. </summary>
        public AcceptOwnershipState? AcceptOwnershipState { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public AcceptOwnershipProvisioningState? ProvisioningState { get; }
        /// <summary> UPN of the billing owner. </summary>
        public string BillingOwner { get; }
        /// <summary> Tenant Id of the subscription. </summary>
        public Guid? SubscriptionTenantId { get; }
        /// <summary> The display name of the subscription. </summary>
        public string DisplayName { get; }
        /// <summary> Tags for the subscription. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
