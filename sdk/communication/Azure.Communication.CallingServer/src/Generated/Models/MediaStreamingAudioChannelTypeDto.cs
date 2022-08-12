// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> Audio channel type to stream, eg. unmixed audio, mixed audio. </summary>
    public readonly partial struct MediaStreamingAudioChannelTypeDto : IEquatable<MediaStreamingAudioChannelTypeDto>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaStreamingAudioChannelTypeDto"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaStreamingAudioChannelTypeDto(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MixedValue = "mixed";
        private const string UnmixedValue = "unmixed";

        /// <summary> mixed. </summary>
        public static MediaStreamingAudioChannelTypeDto Mixed { get; } = new MediaStreamingAudioChannelTypeDto(MixedValue);
        /// <summary> unmixed. </summary>
        public static MediaStreamingAudioChannelTypeDto Unmixed { get; } = new MediaStreamingAudioChannelTypeDto(UnmixedValue);
        /// <summary> Determines if two <see cref="MediaStreamingAudioChannelTypeDto"/> values are the same. </summary>
        public static bool operator ==(MediaStreamingAudioChannelTypeDto left, MediaStreamingAudioChannelTypeDto right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaStreamingAudioChannelTypeDto"/> values are not the same. </summary>
        public static bool operator !=(MediaStreamingAudioChannelTypeDto left, MediaStreamingAudioChannelTypeDto right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaStreamingAudioChannelTypeDto"/>. </summary>
        public static implicit operator MediaStreamingAudioChannelTypeDto(string value) => new MediaStreamingAudioChannelTypeDto(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaStreamingAudioChannelTypeDto other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaStreamingAudioChannelTypeDto other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
