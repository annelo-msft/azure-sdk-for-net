// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class ModelCollectionInfo
    {
        internal ModelCollectionInfo() { }

        /// <summary>
        /// The number of custom models trained in this FormRecognizer resource.
        /// </summary>
        public int ModelCount { get; internal set; }

        /// <summary>
        /// Limit.
        /// </summary>
        public int SubscriptionLimit { get; internal set; }

        /// <summary>
        /// Last updated date.
        /// </summary>
        internal DateTimeOffset LastUpdatedOn { get; set; }
    }
}