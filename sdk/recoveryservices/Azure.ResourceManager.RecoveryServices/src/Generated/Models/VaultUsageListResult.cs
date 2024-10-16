// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Usage for vault. </summary>
    internal partial class VaultUsageListResult
    {
        /// <summary> Initializes a new instance of VaultUsageListResult. </summary>
        internal VaultUsageListResult()
        {
            Value = new ChangeTrackingList<VaultUsage>();
        }

        /// <summary> Initializes a new instance of VaultUsageListResult. </summary>
        /// <param name="value"> The list of usages for the given vault. </param>
        internal VaultUsageListResult(IReadOnlyList<VaultUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of usages for the given vault. </summary>
        public IReadOnlyList<VaultUsage> Value { get; }
    }
}
