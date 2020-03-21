﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// </summary>
    public class SubscriptionProperties
    {
        internal SubscriptionProperties(ModelsSummary_internal summary)
        {
            CustomModelCount = summary.Count;
            CustomModelLimit = summary.Limit;
            LastUpdatedOn = summary.LastUpdatedDateTime;
        }

        /// <summary> Current count of trained custom models. </summary>
        public int CustomModelCount { get; set; }

        /// <summary> Max number of models that can be trained for this subscription. </summary>
        public int CustomModelLimit { get; set; }

        /// <summary> Date and time (UTC) when the summary was last updated. </summary>
        public DateTimeOffset LastUpdatedOn { get; set; }
    }
}
