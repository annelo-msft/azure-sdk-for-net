// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The response from the ListKeys operation. </summary>
    internal partial class StorageAccountGetKeysResult
    {
        /// <summary> Initializes a new instance of StorageAccountGetKeysResult. </summary>
        internal StorageAccountGetKeysResult()
        {
            Keys = new Core.ChangeTrackingList<StorageAccountKey>();
        }

        /// <summary> Initializes a new instance of StorageAccountGetKeysResult. </summary>
        /// <param name="keys"> Gets the list of storage account keys and their properties for the specified storage account. </param>
        internal StorageAccountGetKeysResult(IReadOnlyList<StorageAccountKey> keys)
        {
            Keys = keys;
        }

        /// <summary> Gets the list of storage account keys and their properties for the specified storage account. </summary>
        public IReadOnlyList<StorageAccountKey> Keys { get; }
    }
}
