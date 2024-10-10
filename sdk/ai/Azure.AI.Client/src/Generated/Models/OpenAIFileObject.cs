// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Client.Models
{
    /// <summary> The OpenAIFile_object. </summary>
    internal readonly partial struct OpenAIFileObject : IEquatable<OpenAIFileObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OpenAIFileObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OpenAIFileObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileValue = "file";

        /// <summary> file. </summary>
        public static OpenAIFileObject File { get; } = new OpenAIFileObject(FileValue);
        /// <summary> Determines if two <see cref="OpenAIFileObject"/> values are the same. </summary>
        public static bool operator ==(OpenAIFileObject left, OpenAIFileObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OpenAIFileObject"/> values are not the same. </summary>
        public static bool operator !=(OpenAIFileObject left, OpenAIFileObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OpenAIFileObject"/>. </summary>
        public static implicit operator OpenAIFileObject(string value) => new OpenAIFileObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OpenAIFileObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OpenAIFileObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
