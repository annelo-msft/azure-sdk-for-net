// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> List of Dimension. </summary>
    public partial class CostManagementDimension : ResourceData
    {
        /// <summary> Initializes a new instance of CostManagementDimension. </summary>
        internal CostManagementDimension()
        {
            Data = new Core.ChangeTrackingList<string>();
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CostManagementDimension. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Dimension description. </param>
        /// <param name="isFilterEnabled"> Filter enabled. </param>
        /// <param name="isGroupingEnabled"> Grouping enabled. </param>
        /// <param name="data"> Dimension data. </param>
        /// <param name="total"> Total number of data for the dimension. </param>
        /// <param name="category"> Dimension category. </param>
        /// <param name="usageStart"> Usage start. </param>
        /// <param name="usageEnd"> Usage end. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="sku"> SKU of the resource. </param>
        /// <param name="eTag"> ETag of the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        internal CostManagementDimension(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, bool? isFilterEnabled, bool? isGroupingEnabled, IReadOnlyList<string> data, int? total, string category, DateTimeOffset? usageStart, DateTimeOffset? usageEnd, string nextLink, AzureLocation? location, string sku, ETag? eTag, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Description = description;
            IsFilterEnabled = isFilterEnabled;
            IsGroupingEnabled = isGroupingEnabled;
            Data = data;
            Total = total;
            Category = category;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            NextLink = nextLink;
            Location = location;
            Sku = sku;
            ETag = eTag;
            Tags = tags;
        }

        /// <summary> Dimension description. </summary>
        public string Description { get; }
        /// <summary> Filter enabled. </summary>
        public bool? IsFilterEnabled { get; }
        /// <summary> Grouping enabled. </summary>
        public bool? IsGroupingEnabled { get; }
        /// <summary> Dimension data. </summary>
        public IReadOnlyList<string> Data { get; }
        /// <summary> Total number of data for the dimension. </summary>
        public int? Total { get; }
        /// <summary> Dimension category. </summary>
        public string Category { get; }
        /// <summary> Usage start. </summary>
        public DateTimeOffset? UsageStart { get; }
        /// <summary> Usage end. </summary>
        public DateTimeOffset? UsageEnd { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> Location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> SKU of the resource. </summary>
        public string Sku { get; }
        /// <summary> ETag of the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
