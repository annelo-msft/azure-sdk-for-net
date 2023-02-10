// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Azure.Core.Dynamic
{
    public partial class DynamicJson
    {
        // Operators that cast from DynamicJson to another type
        private static readonly Dictionary<Type, MethodInfo> CastFromOperators = typeof(DynamicJson)
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .Where(method => method.Name == "op_Explicit" || method.Name == "op_Implicit")
            .ToDictionary(method => method.ReturnType);

        /// <summary>
        /// Converts the value to a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator bool(DynamicJson value) => value._element.GetBoolean();

        /// <summary>
        /// Converts the value to a <see cref="int"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator int(DynamicJson value) => value._element.GetInt32();

        /// <summary>
        /// Converts the value to a <see cref="long"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator long(DynamicJson value) => value._element.GetInt64();

        /// <summary>
        /// Converts the value to a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator string?(DynamicJson value) => value._element.GetString();

        /// <summary>
        /// Converts the value to a <see cref="float"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator float(DynamicJson value) => value._element.GetSingle();

        /// <summary>
        /// Converts the value to a <see cref="double"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator double(DynamicJson value) => value._element.GetDouble();

        /// <summary>
        /// Converts the value to a <see cref="bool"/> or null.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator bool?(DynamicJson value) => value._element.ValueKind == JsonValueKind.Null ? null : value._element.GetBoolean();

        /// <summary>
        /// Converts the value to a <see cref="int"/> or null.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator int?(DynamicJson value) => value._element.ValueKind == JsonValueKind.Null ? null : value._element.GetInt32();

        /// <summary>
        /// Converts the value to a <see cref="long"/> or null.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator long?(DynamicJson value) => value._element.ValueKind == JsonValueKind.Null ? null : value._element.GetInt64();

        /// <summary>
        /// Converts the value to a <see cref="float"/> or null.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator float?(DynamicJson value) => value._element.ValueKind == JsonValueKind.Null ? null : value._element.GetSingle();

        /// <summary>
        /// Converts the value to a <see cref="double"/> or null.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator double?(DynamicJson value) => value._element.ValueKind == JsonValueKind.Null ? null : value._element.GetDouble();

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given bool,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="bool"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given bool, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, bool right)
        {
            if (left is null)
            {
                return false;
            }

            return (left._element.ValueKind == JsonValueKind.False || left._element.ValueKind == JsonValueKind.True) &&
                ((bool)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given bool,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="bool"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, bool right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given bool,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="bool"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given bool, and false otherwise.</returns>
        public static bool operator ==(bool left, DynamicJson? right)
        {
            if (right is null)
            {
                return false;
            }

            return (right._element.ValueKind == JsonValueKind.False || right._element.ValueKind == JsonValueKind.True) &&
                ((bool)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given bool,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="bool"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given bool, and false otherwise</returns>
        public static bool operator !=(bool left, DynamicJson? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given int,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="int"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given int, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, int right)
        {
            if (left is null)
            {
                return false;
            }

            return left._element.ValueKind == JsonValueKind.Number && ((int)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given int,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="int"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, int right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given int,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="int"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given int, and false otherwise.</returns>
        public static bool operator ==(int left, DynamicJson? right)
        {
            if (right is null)
            {
                return false;
            }

            return right._element.ValueKind == JsonValueKind.Number && ((int)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given int,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="int"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given int, and false otherwise</returns>
        public static bool operator !=(int left, DynamicJson? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given long,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="long"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given long, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, long right)
        {
            if (left is null)
            {
                return false;
            }

            return left._element.ValueKind == JsonValueKind.Number && ((long)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given long,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="long"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, long right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given long,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="long"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given long, and false otherwise.</returns>
        public static bool operator ==(long left, DynamicJson? right)
        {
            if (right is null)
            {
                return false;
            }

            return right._element.ValueKind == JsonValueKind.Number && ((long)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given long,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="long"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given long, and false otherwise</returns>
        public static bool operator !=(long left, DynamicJson? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given string,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="string"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given string, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, string? right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left._element.ValueKind == JsonValueKind.String && ((string?)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given string,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="string"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, string? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given string,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="string"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given string, and false otherwise.</returns>
        public static bool operator ==(string? left, DynamicJson? right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return right._element.ValueKind == JsonValueKind.String && ((string?)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given string,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="string"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(string? left, DynamicJson? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given float,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="float"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given float, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, float right)
        {
            if (left is null)
            {
                return false;
            }

            return left._element.ValueKind == JsonValueKind.Number && ((float)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given float,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="float"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, float right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given float,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="float"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given float, and false otherwise.</returns>
        public static bool operator ==(float left, DynamicJson? right)
        {
            if (right is null)
            {
                return false;
            }

            return right._element.ValueKind == JsonValueKind.Number && ((float)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given float,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="float"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given float, and false otherwise</returns>
        public static bool operator !=(float left, DynamicJson? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given double,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="double"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given double, and false otherwise.</returns>
        public static bool operator ==(DynamicJson? left, double right)
        {
            if (left is null)
            {
                return false;
            }

            return left._element.ValueKind == JsonValueKind.Number && ((double)left) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given double,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="DynamicJson"/> to compare.</param>
        /// <param name="right">The <see cref="double"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given string, and false otherwise</returns>
        public static bool operator !=(DynamicJson? left, double right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="DynamicJson"/> has the same value as a given double,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="double"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>True if the given DynamicJson represents the given double, and false otherwise.</returns>
        public static bool operator ==(double left, DynamicJson? right)
        {
            if (right is null)
            {
                return false;
            }

            return right._element.ValueKind == JsonValueKind.Number && ((double)right) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="DynamicJson"/> has the same value as a given double,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="double"/> to compare.</param>
        /// <param name="right">The <see cref="DynamicJson"/> to compare.</param>
        /// <returns>False if the given DynamicJson represents the given double, and false otherwise</returns>
        public static bool operator !=(double left, DynamicJson? right) => !(left == right);
    }
}
