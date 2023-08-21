// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the SQL container events and their properties. </summary>
    internal partial class RestorableSqlContainersListResult
    {
        /// <summary> Initializes a new instance of RestorableSqlContainersListResult. </summary>
        internal RestorableSqlContainersListResult()
        {
            Value = new Core.ChangeTrackingList<RestorableSqlContainer>();
        }

        /// <summary> Initializes a new instance of RestorableSqlContainersListResult. </summary>
        /// <param name="value"> List of SQL container events and their properties. </param>
        internal RestorableSqlContainersListResult(IReadOnlyList<RestorableSqlContainer> value)
        {
            Value = value;
        }

        /// <summary> List of SQL container events and their properties. </summary>
        public IReadOnlyList<RestorableSqlContainer> Value { get; }
    }
}
