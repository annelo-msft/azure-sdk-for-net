// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Json;

namespace Azure.Core.Tests.PatchModels
{
    /// <summary>
    /// This model illustrates collection properties on Patch models.
    /// </summary>
    public partial class CollectionPatchModel
    {
#pragma warning disable AZC0020 // Avoid using banned types in libraries
        private readonly MutableJsonElement _element;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public CollectionPatchModel()
        {
            _element = MutableJsonDocument.Parse(MutableJsonDocument.EmptyJson).RootElement;
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="element"></param>
        internal CollectionPatchModel(MutableJsonElement element)
        {
            _element = element;
        }

#pragma warning restore AZC0020 // Avoid using banned types in libraries
    }
}
