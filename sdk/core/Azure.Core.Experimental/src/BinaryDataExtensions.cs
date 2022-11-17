// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Experimental;

namespace Azure
{
    /// <summary>
    /// Extensions to BinaryData.
    /// </summary>
    public static class BinaryDataExtensions
    {
        /// <summary>
        /// </summary>
        public static dynamic ToDynamic(this BinaryData data)
        {
            return JsonData.Parse(data);
        }

        /// <summary>
        /// </summary>
        public static dynamic ToDynamic(this BinaryData data, DynamicDataOptions options)
        {
            return JsonData.Parse(data, options);
        }
    }
}
