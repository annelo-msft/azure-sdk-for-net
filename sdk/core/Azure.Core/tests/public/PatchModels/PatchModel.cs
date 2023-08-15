// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    /// <summary>
    /// Base implementation of a patch model.
    /// </summary>
    internal abstract partial class PatchModel<T>
    {
#pragma warning disable AZC0020 // Avoid using banned types in libraries
        private readonly MutableJsonElement _element;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public PatchModel(MutableJsonElement element)
        {
            _element = element;
        }
#pragma warning restore AZC0020 // Avoid using banned types in libraries
    }
}
