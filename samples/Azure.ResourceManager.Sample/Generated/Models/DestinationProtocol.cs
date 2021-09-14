// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Protocol to use for the redirect. The default value is MatchRequest. </summary>
    public readonly partial struct DestinationProtocol : IEquatable<DestinationProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DestinationProtocol"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DestinationProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MatchRequestValue = "MatchRequest";
        private const string HttpValue = "Http";
        private const string HttpsValue = "Https";

        /// <summary> MatchRequest. </summary>
        public static DestinationProtocol MatchRequest { get; } = new DestinationProtocol(MatchRequestValue);
        /// <summary> Http. </summary>
        public static DestinationProtocol Http { get; } = new DestinationProtocol(HttpValue);
        /// <summary> Https. </summary>
        public static DestinationProtocol Https { get; } = new DestinationProtocol(HttpsValue);
        /// <summary> Determines if two <see cref="DestinationProtocol"/> values are the same. </summary>
        public static bool operator ==(DestinationProtocol left, DestinationProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DestinationProtocol"/> values are not the same. </summary>
        public static bool operator !=(DestinationProtocol left, DestinationProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DestinationProtocol"/>. </summary>
        public static implicit operator DestinationProtocol(string value) => new DestinationProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DestinationProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DestinationProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
