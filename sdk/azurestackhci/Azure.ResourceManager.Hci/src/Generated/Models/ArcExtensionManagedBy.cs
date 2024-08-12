// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Extension managed by user or Azure. </summary>
    public readonly partial struct ArcExtensionManagedBy : IEquatable<ArcExtensionManagedBy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArcExtensionManagedBy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArcExtensionManagedBy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string AzureValue = "Azure";

        /// <summary> User. </summary>
        public static ArcExtensionManagedBy User { get; } = new ArcExtensionManagedBy(UserValue);
        /// <summary> Azure. </summary>
        public static ArcExtensionManagedBy Azure { get; } = new ArcExtensionManagedBy(AzureValue);
        /// <summary> Determines if two <see cref="ArcExtensionManagedBy"/> values are the same. </summary>
        public static bool operator ==(ArcExtensionManagedBy left, ArcExtensionManagedBy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArcExtensionManagedBy"/> values are not the same. </summary>
        public static bool operator !=(ArcExtensionManagedBy left, ArcExtensionManagedBy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArcExtensionManagedBy"/>. </summary>
        public static implicit operator ArcExtensionManagedBy(string value) => new ArcExtensionManagedBy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArcExtensionManagedBy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArcExtensionManagedBy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
