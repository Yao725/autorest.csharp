// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The LogMetricsGroupBy. </summary>
    public readonly partial struct LogMetricsGroupBy : IEquatable<LogMetricsGroupBy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LogMetricsGroupBy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogMetricsGroupBy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpStatusCodeValue = "httpStatusCode";
        private const string ProtocolValue = "protocol";
        private const string CacheStatusValue = "cacheStatus";
        private const string CountryValue = "country";
        private const string CustomDomainValue = "customDomain";

        /// <summary> httpStatusCode. </summary>
        public static LogMetricsGroupBy HttpStatusCode { get; } = new LogMetricsGroupBy(HttpStatusCodeValue);
        /// <summary> protocol. </summary>
        public static LogMetricsGroupBy Protocol { get; } = new LogMetricsGroupBy(ProtocolValue);
        /// <summary> cacheStatus. </summary>
        public static LogMetricsGroupBy CacheStatus { get; } = new LogMetricsGroupBy(CacheStatusValue);
        /// <summary> country. </summary>
        public static LogMetricsGroupBy Country { get; } = new LogMetricsGroupBy(CountryValue);
        /// <summary> customDomain. </summary>
        public static LogMetricsGroupBy CustomDomain { get; } = new LogMetricsGroupBy(CustomDomainValue);
        /// <summary> Determines if two <see cref="LogMetricsGroupBy"/> values are the same. </summary>
        public static bool operator ==(LogMetricsGroupBy left, LogMetricsGroupBy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogMetricsGroupBy"/> values are not the same. </summary>
        public static bool operator !=(LogMetricsGroupBy left, LogMetricsGroupBy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogMetricsGroupBy"/>. </summary>
        public static implicit operator LogMetricsGroupBy(string value) => new LogMetricsGroupBy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogMetricsGroupBy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogMetricsGroupBy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
