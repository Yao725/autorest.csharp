// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines the source of the SSL certificate. </summary>
    public readonly partial struct CertificateSource : IEquatable<CertificateSource>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CertificateSource"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificateSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureKeyVaultValue = "AzureKeyVault";
        private const string CdnValue = "Cdn";

        /// <summary> AzureKeyVault. </summary>
        public static CertificateSource AzureKeyVault { get; } = new CertificateSource(AzureKeyVaultValue);
        /// <summary> Cdn. </summary>
        public static CertificateSource Cdn { get; } = new CertificateSource(CdnValue);
        /// <summary> Determines if two <see cref="CertificateSource"/> values are the same. </summary>
        public static bool operator ==(CertificateSource left, CertificateSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificateSource"/> values are not the same. </summary>
        public static bool operator !=(CertificateSource left, CertificateSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CertificateSource"/>. </summary>
        public static implicit operator CertificateSource(string value) => new CertificateSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificateSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificateSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
