// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> Sku of the storage associated with the resource. </summary>
    public readonly partial struct StorageSku : IEquatable<StorageSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "standard";
        private const string BasicValue = "basic";

        /// <summary> standard. </summary>
        public static StorageSku Standard { get; } = new StorageSku(StandardValue);
        /// <summary> basic. </summary>
        public static StorageSku Basic { get; } = new StorageSku(BasicValue);
        /// <summary> Determines if two <see cref="StorageSku"/> values are the same. </summary>
        public static bool operator ==(StorageSku left, StorageSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageSku"/> values are not the same. </summary>
        public static bool operator !=(StorageSku left, StorageSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageSku"/>. </summary>
        public static implicit operator StorageSku(string value) => new StorageSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
