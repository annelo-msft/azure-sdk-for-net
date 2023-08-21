// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List restore point collection operation response. </summary>
    internal partial class RestorePointGroupListResult
    {
        /// <summary> Initializes a new instance of RestorePointGroupListResult. </summary>
        internal RestorePointGroupListResult()
        {
            Value = new Core.ChangeTrackingList<RestorePointGroupData>();
        }

        /// <summary> Initializes a new instance of RestorePointGroupListResult. </summary>
        /// <param name="value"> Gets the list of restore point collections. </param>
        /// <param name="nextLink"> The uri to fetch the next page of RestorePointCollections. Call ListNext() with this to fetch the next page of RestorePointCollections. </param>
        internal RestorePointGroupListResult(IReadOnlyList<RestorePointGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of restore point collections. </summary>
        public IReadOnlyList<RestorePointGroupData> Value { get; }
        /// <summary> The uri to fetch the next page of RestorePointCollections. Call ListNext() with this to fetch the next page of RestorePointCollections. </summary>
        public string NextLink { get; }
    }
}
