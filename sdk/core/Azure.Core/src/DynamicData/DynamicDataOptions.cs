// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Serialization;

namespace Azure.Core.Dynamic
{
    /// <summary>
    /// Provides options to be used with <see cref="DynamicData"/>.
    /// </summary>
    internal class DynamicDataOptions
    {
        private static DynamicDataOptions _default = new()
        {
            DateTimeHandling = DynamicDateTimeHandling.Rfc3339
        };
        internal static DynamicDataOptions Default
        {
            get => _default;
            set => _default = value;
        }

        /// <summary>
        /// </summary>
        public PropertyNameConversion PropertyNameConversion { get; set; }

        /// <summary>
        /// Gets or sets an object that specifies how DateTime and DateTimeOffset should be handled when serializing and deserializing.
        /// </summary>
        public DynamicDateTimeHandling DateTimeHandling { get; set; }
    }
}
