// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    [CodeGenModel("DeletedRepository")]
    public partial class DeleteRepositoryResult
    {
        /// <summary> SHA of the deleted image. </summary>
        [CodeGenMember("ManifestsDeleted")]
        public IReadOnlyList<string> DeletedImageDigests { get; }

        /// <summary> Tag of the deleted image. </summary>
        [CodeGenMember("TagsDeleted")]
        public IReadOnlyList<string> DeletedTags { get; }
    }
}
