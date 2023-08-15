// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Json;

namespace Azure.Core.Tests.PatchModels
{
    /// <summary>
    /// Base implementation of a patch model.
    /// </summary>
    internal abstract partial class PatchModel<T>
    {
#pragma warning disable AZC0020 // Avoid using banned types in libraries
        private readonly MutableJsonElement _element;
        private readonly Func<MutableJsonElement, T> _constructor;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public PatchModel(Func<MutableJsonElement, T> factory)
        {
            _constructor = factory;
        }
#pragma warning restore AZC0020 // Avoid using banned types in libraries
    }
}
