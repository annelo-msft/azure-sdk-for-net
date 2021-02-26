// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Repository attributes. </summary>
    public partial class RepositoryProperties
    {
        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        internal RepositoryProperties()
        {
        }

        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="createdTime"> Image created time. </param>
        /// <param name="lastUpdateTime"> Image last update time. </param>
        /// <param name="repositoryItemCount"> Number of the manifests. </param>
        /// <param name="tagCount"> Number of the tags. </param>
        /// <param name="permissions"> Changeable attributes. </param>
        internal RepositoryProperties(string registry, string name, DateTimeOffset? createdTime, DateTimeOffset? lastUpdateTime, int? repositoryItemCount, int? tagCount, ContentPermissions permissions)
        {
            Registry = registry;
            Name = name;
            CreatedTime = createdTime;
            LastUpdateTime = lastUpdateTime;
            RepositoryItemCount = repositoryItemCount;
            TagCount = tagCount;
            Permissions = permissions;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image created time. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> Image last update time. </summary>
        public DateTimeOffset? LastUpdateTime { get; }
        /// <summary> Number of the tags. </summary>
        public int? TagCount { get; }
    }
}
