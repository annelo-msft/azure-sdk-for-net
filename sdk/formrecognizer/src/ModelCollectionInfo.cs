// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct ModelCollectionInfo
    {
        internal ModelCollectionInfo(int modelCount, int subscriptionLimit, DateTimeOffset lastUpdateTime)
        {
            ModelCount = modelCount;
            SubscriptionLimit = subscriptionLimit;
            LastUpdateTime = lastUpdateTime;
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
        internal DateTimeOffset LastUpdateTime { get; }
    }
}