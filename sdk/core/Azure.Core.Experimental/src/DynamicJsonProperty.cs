// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Json;

namespace Azure.Core.Dynamic
{
    /// <summary>
    /// Represents a single property on a dynamic JSON object.
    /// </summary>
    public readonly struct DynamicJsonProperty
    {
        private readonly string _name;
        private readonly DynamicJson _value;

        internal DynamicJsonProperty(string name, DynamicJson value)
        {
            _name = name;
            _value = value;
        }

        /// <summary>
        /// Gets the name of this property.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Gets or sets the value of this property.
        /// </summary>
        public DynamicJson Value
        {
            get => _value;
            set => _value.Set(value);
        }
    }
}
