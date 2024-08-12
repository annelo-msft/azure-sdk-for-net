// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The deployment mode of EnterpriseCloudEngine(ECE) action for a cluster. </summary>
    public readonly partial struct EceDeploymentMode : IEquatable<EceDeploymentMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EceDeploymentMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EceDeploymentMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidateValue = "Validate";
        private const string DeployValue = "Deploy";

        /// <summary> Validate ECE action deployment for a cluster. </summary>
        public static EceDeploymentMode Validate { get; } = new EceDeploymentMode(ValidateValue);
        /// <summary> Deploy ECE action deployment for a cluster. </summary>
        public static EceDeploymentMode Deploy { get; } = new EceDeploymentMode(DeployValue);
        /// <summary> Determines if two <see cref="EceDeploymentMode"/> values are the same. </summary>
        public static bool operator ==(EceDeploymentMode left, EceDeploymentMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EceDeploymentMode"/> values are not the same. </summary>
        public static bool operator !=(EceDeploymentMode left, EceDeploymentMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EceDeploymentMode"/>. </summary>
        public static implicit operator EceDeploymentMode(string value) => new EceDeploymentMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EceDeploymentMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EceDeploymentMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
