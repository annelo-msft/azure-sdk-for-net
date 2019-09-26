// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Data.AppConfiguration
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Conditional<T>
    {
        /// <summary>
        /// </summary>
        /// <param name="response"></param>
        /// <param name="value"></param>
        public Conditional(Response response, T value)
        {
            WasModifiedVersion = (response.Status == 304 || response.Status == 412);
            Value = value;
        }

        /// <summary>
        /// </summary>
        public bool WasModifiedVersion { get; }

        /// <summary>
        /// </summary>
        public T Value { get; }
    }
}
