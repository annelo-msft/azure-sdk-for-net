// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Core.Experimental
{
    /// <summary>
    /// Options to control dynamic data behavior.
    /// </summary>
    public class DynamicDataOptions
    {
        /// <summary>
        /// Gets or sets a value that indicates whether property names on dynamic data values are case insensitive.
        /// </summary>
        public bool PropertyNameCaseInsensitive { get; set; }
    }
}
