// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The configuration of dataset in the query. </summary>
    internal partial class QueryDatasetConfiguration
    {
        /// <summary> Initializes a new instance of QueryDatasetConfiguration. </summary>
        public QueryDatasetConfiguration()
        {
            Columns = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Array of column names to be included in the query. Any valid query column name is allowed. If not provided, then query includes all columns. </summary>
        public IList<string> Columns { get; }
    }
}
