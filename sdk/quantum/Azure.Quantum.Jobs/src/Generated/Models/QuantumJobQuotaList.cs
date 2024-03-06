// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Quantum.Jobs;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> List of quotas. </summary>
    public partial class QuantumJobQuotaList
    {
        /// <summary> Initializes a new instance of <see cref="QuantumJobQuotaList"/>. </summary>
        internal QuantumJobQuotaList()
        {
            Value = new ChangeTrackingList<QuantumJobQuota>();
        }

        /// <summary> Initializes a new instance of <see cref="QuantumJobQuotaList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal QuantumJobQuotaList(IReadOnlyList<QuantumJobQuota> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<QuantumJobQuota> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
