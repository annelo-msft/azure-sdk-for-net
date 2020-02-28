// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ModelsSummary
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ModelsSummary(int modelCount, int subscriptionLimit, DateTimeOffset lastUpdateTime)
        {
            ModelCount = modelCount;
            SubscriptionLimit = subscriptionLimit;
            LastUpdatedOn = lastUpdateTime;
        }

        /// <summary>
        /// The number of custom models trained in this FormRecognizer resource.
        /// </summary>
        public int ModelCount { get; }

        /// <summary>
        /// Limit.
        /// </summary>
        public int SubscriptionLimit { get; }

        /// <summary>
        /// Last updated date.
        /// </summary>
        public DateTimeOffset LastUpdatedOn { get; }
    }
}