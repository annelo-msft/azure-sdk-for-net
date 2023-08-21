// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when creating a storage sync service. </summary>
    public partial class StorageSyncServiceCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of StorageSyncServiceCreateOrUpdateContent. </summary>
        /// <param name="location"> Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed. </param>
        public StorageSyncServiceCreateOrUpdateContent(AzureLocation location)
        {
            Location = location;
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed. </summary>
        public AzureLocation Location { get; }
        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Incoming Traffic Policy. </summary>
        public IncomingTrafficPolicy? IncomingTrafficPolicy { get; set; }
    }
}
