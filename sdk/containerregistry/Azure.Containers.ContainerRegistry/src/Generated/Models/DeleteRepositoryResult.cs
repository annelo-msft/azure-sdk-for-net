// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Deleted repository. </summary>
    public partial class DeleteRepositoryResult
    {
        /// <summary> Initializes a new instance of DeleteRepositoryResult. </summary>
        internal DeleteRepositoryResult()
        {
            DeletedRepositoryItems = new ChangeTrackingList<string>();
            DeletedTags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DeleteRepositoryResult. </summary>
        /// <param name="deletedRepositoryItems"> SHA of the deleted image. </param>
        /// <param name="deletedTags"> Tag of the deleted image. </param>
        internal DeleteRepositoryResult(IReadOnlyList<string> deletedRepositoryItems, IReadOnlyList<string> deletedTags)
        {
            DeletedRepositoryItems = deletedRepositoryItems;
            DeletedTags = deletedTags;
        }
    }
}
