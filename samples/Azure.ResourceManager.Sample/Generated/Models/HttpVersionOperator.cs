// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct HttpVersionOperator : IEquatable<HttpVersionOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="HttpVersionOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpVersionOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualValue = "Equal";

        /// <summary> Equal. </summary>
        public static HttpVersionOperator Equal { get; } = new HttpVersionOperator(EqualValue);
        /// <summary> Determines if two <see cref="HttpVersionOperator"/> values are the same. </summary>
        public static bool operator ==(HttpVersionOperator left, HttpVersionOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpVersionOperator"/> values are not the same. </summary>
        public static bool operator !=(HttpVersionOperator left, HttpVersionOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpVersionOperator"/>. </summary>
        public static implicit operator HttpVersionOperator(string value) => new HttpVersionOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpVersionOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpVersionOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
