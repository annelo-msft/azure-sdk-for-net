// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct TrainedFormCluster
    {
        internal TrainedFormCluster(int formClusterId, IReadOnlyCollection<string> fieldNames)
        {
            FormClusterId = formClusterId;
            FieldNames = fieldNames;
        }

        /// <summary>
        /// Cluster Id
        /// </summary>
        public int FormClusterId { get; }

        /// <summary>
        /// Names of the fields extracted from forms in this cluster.
        /// </summary>
        public IReadOnlyCollection<string> FieldNames { get; }
    }
}
