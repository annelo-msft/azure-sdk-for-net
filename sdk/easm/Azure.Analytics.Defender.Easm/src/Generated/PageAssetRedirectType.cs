// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The redirect type of a page. </summary>
    public readonly partial struct PageAssetRedirectType : IEquatable<PageAssetRedirectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PageAssetRedirectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PageAssetRedirectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpHeaderValue = "httpHeader";
        private const string MetaRefreshValue = "metaRefresh";
        private const string JavascriptValue = "javascript";
        private const string FinalValue = "final";

        /// <summary> httpHeader. </summary>
        public static PageAssetRedirectType HttpHeader { get; } = new PageAssetRedirectType(HttpHeaderValue);
        /// <summary> metaRefresh. </summary>
        public static PageAssetRedirectType MetaRefresh { get; } = new PageAssetRedirectType(MetaRefreshValue);
        /// <summary> javascript. </summary>
        public static PageAssetRedirectType Javascript { get; } = new PageAssetRedirectType(JavascriptValue);
        /// <summary> final. </summary>
        public static PageAssetRedirectType Final { get; } = new PageAssetRedirectType(FinalValue);
        /// <summary> Determines if two <see cref="PageAssetRedirectType"/> values are the same. </summary>
        public static bool operator ==(PageAssetRedirectType left, PageAssetRedirectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PageAssetRedirectType"/> values are not the same. </summary>
        public static bool operator !=(PageAssetRedirectType left, PageAssetRedirectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PageAssetRedirectType"/>. </summary>
        public static implicit operator PageAssetRedirectType(string value) => new PageAssetRedirectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PageAssetRedirectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PageAssetRedirectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
