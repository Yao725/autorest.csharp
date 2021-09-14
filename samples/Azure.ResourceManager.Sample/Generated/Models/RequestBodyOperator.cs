// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct RequestBodyOperator : IEquatable<RequestBodyOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RequestBodyOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestBodyOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static RequestBodyOperator Any { get; } = new RequestBodyOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static RequestBodyOperator Equal { get; } = new RequestBodyOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static RequestBodyOperator Contains { get; } = new RequestBodyOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static RequestBodyOperator BeginsWith { get; } = new RequestBodyOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static RequestBodyOperator EndsWith { get; } = new RequestBodyOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static RequestBodyOperator LessThan { get; } = new RequestBodyOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static RequestBodyOperator LessThanOrEqual { get; } = new RequestBodyOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static RequestBodyOperator GreaterThan { get; } = new RequestBodyOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static RequestBodyOperator GreaterThanOrEqual { get; } = new RequestBodyOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static RequestBodyOperator RegEx { get; } = new RequestBodyOperator(RegExValue);
        /// <summary> Determines if two <see cref="RequestBodyOperator"/> values are the same. </summary>
        public static bool operator ==(RequestBodyOperator left, RequestBodyOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestBodyOperator"/> values are not the same. </summary>
        public static bool operator !=(RequestBodyOperator left, RequestBodyOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestBodyOperator"/>. </summary>
        public static implicit operator RequestBodyOperator(string value) => new RequestBodyOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestBodyOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestBodyOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
