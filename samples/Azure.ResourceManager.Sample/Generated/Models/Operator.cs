// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct Operator : IEquatable<Operator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Operator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Operator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string IPMatchValue = "IPMatch";
        private const string GeoMatchValue = "GeoMatch";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string LessThanValue = "LessThan";
        private const string GreaterThanValue = "GreaterThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static Operator Any { get; } = new Operator(AnyValue);
        /// <summary> IPMatch. </summary>
        public static Operator IPMatch { get; } = new Operator(IPMatchValue);
        /// <summary> GeoMatch. </summary>
        public static Operator GeoMatch { get; } = new Operator(GeoMatchValue);
        /// <summary> Equal. </summary>
        public static Operator Equal { get; } = new Operator(EqualValue);
        /// <summary> Contains. </summary>
        public static Operator Contains { get; } = new Operator(ContainsValue);
        /// <summary> LessThan. </summary>
        public static Operator LessThan { get; } = new Operator(LessThanValue);
        /// <summary> GreaterThan. </summary>
        public static Operator GreaterThan { get; } = new Operator(GreaterThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static Operator LessThanOrEqual { get; } = new Operator(LessThanOrEqualValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static Operator GreaterThanOrEqual { get; } = new Operator(GreaterThanOrEqualValue);
        /// <summary> BeginsWith. </summary>
        public static Operator BeginsWith { get; } = new Operator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static Operator EndsWith { get; } = new Operator(EndsWithValue);
        /// <summary> RegEx. </summary>
        public static Operator RegEx { get; } = new Operator(RegExValue);
        /// <summary> Determines if two <see cref="Operator"/> values are the same. </summary>
        public static bool operator ==(Operator left, Operator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Operator"/> values are not the same. </summary>
        public static bool operator !=(Operator left, Operator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Operator"/>. </summary>
        public static implicit operator Operator(string value) => new Operator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Operator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Operator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
