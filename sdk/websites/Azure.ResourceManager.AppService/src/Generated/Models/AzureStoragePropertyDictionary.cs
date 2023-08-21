// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> AzureStorageInfo dictionary resource. </summary>
    public partial class AzureStoragePropertyDictionary : ResourceData
    {
        /// <summary> Initializes a new instance of AzureStoragePropertyDictionary. </summary>
        public AzureStoragePropertyDictionary()
        {
            Properties = new Core.ChangeTrackingDictionary<string, AppServiceStorageAccessInfo>();
        }

        /// <summary> Initializes a new instance of AzureStoragePropertyDictionary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Azure storage accounts. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AzureStoragePropertyDictionary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, AppServiceStorageAccessInfo> properties, string kind) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Azure storage accounts. </summary>
        public IDictionary<string, AppServiceStorageAccessInfo> Properties { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
