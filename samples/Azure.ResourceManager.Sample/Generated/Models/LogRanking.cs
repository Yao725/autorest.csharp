// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The LogRanking. </summary>
    public readonly partial struct LogRanking : IEquatable<LogRanking>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LogRanking"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogRanking(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlValue = "url";
        private const string ReferrerValue = "referrer";
        private const string BrowserValue = "browser";
        private const string UserAgentValue = "userAgent";
        private const string CountryOrRegionValue = "countryOrRegion";

        /// <summary> url. </summary>
        public static LogRanking Url { get; } = new LogRanking(UrlValue);
        /// <summary> referrer. </summary>
        public static LogRanking Referrer { get; } = new LogRanking(ReferrerValue);
        /// <summary> browser. </summary>
        public static LogRanking Browser { get; } = new LogRanking(BrowserValue);
        /// <summary> userAgent. </summary>
        public static LogRanking UserAgent { get; } = new LogRanking(UserAgentValue);
        /// <summary> countryOrRegion. </summary>
        public static LogRanking CountryOrRegion { get; } = new LogRanking(CountryOrRegionValue);
        /// <summary> Determines if two <see cref="LogRanking"/> values are the same. </summary>
        public static bool operator ==(LogRanking left, LogRanking right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogRanking"/> values are not the same. </summary>
        public static bool operator !=(LogRanking left, LogRanking right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogRanking"/>. </summary>
        public static implicit operator LogRanking(string value) => new LogRanking(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogRanking other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogRanking other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
