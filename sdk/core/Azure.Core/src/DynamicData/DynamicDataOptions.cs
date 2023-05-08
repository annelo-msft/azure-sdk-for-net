// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;

namespace Azure.Core.Dynamic
{
    internal class DynamicDataOptions
    {
        private static readonly JsonSerializerOptions 

        public JsonSerializerOptions SerializeOptions { get; set; }
        public JsonSerializerDefaults DeserializeOptions { get; set; }
    }
}
