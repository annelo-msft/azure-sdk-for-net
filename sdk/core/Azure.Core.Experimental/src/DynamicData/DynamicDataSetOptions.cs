// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Core.Dynamic
{
    /// <summary>
    /// Options for setting DynamicData properties.
    /// </summary>
    public enum DynamicDataSetOptions
    {
        /// <summary>
        /// DynamicData instance is read-only.
        /// </summary>
        None,

        /// <summary>
        /// Member names written to the data buffer will exactly match the C# dynamic property names.
        /// </summary>
        ExactNames,

        /// <summary>
        /// Member names written to the data buffer will be converted to camelCase from the C# dynamic property names.
        /// </summary>
        CamelCaseNames
    }
}
