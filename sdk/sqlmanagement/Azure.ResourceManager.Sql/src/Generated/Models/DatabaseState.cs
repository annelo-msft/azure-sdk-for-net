// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The DatabaseState. </summary>
    public readonly partial struct DatabaseState : IEquatable<DatabaseState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DatabaseState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "All";
        private const string LiveValue = "Live";
        private const string DeletedValue = "Deleted";

        /// <summary> All. </summary>
        public static DatabaseState All { get; } = new DatabaseState(AllValue);
        /// <summary> Live. </summary>
        public static DatabaseState Live { get; } = new DatabaseState(LiveValue);
        /// <summary> Deleted. </summary>
        public static DatabaseState Deleted { get; } = new DatabaseState(DeletedValue);
        /// <summary> Determines if two <see cref="DatabaseState"/> values are the same. </summary>
        public static bool operator ==(DatabaseState left, DatabaseState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseState"/> values are not the same. </summary>
        public static bool operator !=(DatabaseState left, DatabaseState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseState"/>. </summary>
        public static implicit operator DatabaseState(string value) => new DatabaseState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
