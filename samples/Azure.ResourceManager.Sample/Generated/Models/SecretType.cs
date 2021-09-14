// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The type of the Secret to create. </summary>
    public readonly partial struct SecretType : IEquatable<SecretType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SecretType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecretType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlSigningKeyValue = "UrlSigningKey";
        private const string CustomerCertificateValue = "CustomerCertificate";
        private const string ManagedCertificateValue = "ManagedCertificate";

        /// <summary> UrlSigningKey. </summary>
        public static SecretType UrlSigningKey { get; } = new SecretType(UrlSigningKeyValue);
        /// <summary> CustomerCertificate. </summary>
        public static SecretType CustomerCertificate { get; } = new SecretType(CustomerCertificateValue);
        /// <summary> ManagedCertificate. </summary>
        public static SecretType ManagedCertificate { get; } = new SecretType(ManagedCertificateValue);
        /// <summary> Determines if two <see cref="SecretType"/> values are the same. </summary>
        public static bool operator ==(SecretType left, SecretType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecretType"/> values are not the same. </summary>
        public static bool operator !=(SecretType left, SecretType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecretType"/>. </summary>
        public static implicit operator SecretType(string value) => new SecretType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecretType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecretType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
