// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> The list of device operations with server paging support. </summary>
    internal partial class DeviceOperationsList
    {
        /// <summary> Initializes a new instance of DeviceOperationsList. </summary>
        /// <param name="value"> The collection of pageable items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DeviceOperationsList(IEnumerable<DeviceOperation> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DeviceOperationsList. </summary>
        /// <param name="value"> The collection of pageable items. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal DeviceOperationsList(IReadOnlyList<DeviceOperation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of pageable items. </summary>
        public IReadOnlyList<DeviceOperation> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
