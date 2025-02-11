// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtRenameRules.Models
{
    /// <summary>
    /// Specifies the SecurityType of the VM. Applicable for OS disks only.
    /// Serialized Name: DiskSecurityTypes
    /// </summary>
    public readonly partial struct DiskSecurityType : IEquatable<DiskSecurityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskSecurityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskSecurityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrustedLaunchValue = "TrustedLaunch";
        private const string ConfidentialVmGuestStateOnlyEncryptedWithPlatformKeyValue = "ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey";
        private const string ConfidentialVmDiskEncryptedWithPlatformKeyValue = "ConfidentialVM_DiskEncryptedWithPlatformKey";
        private const string ConfidentialVmDiskEncryptedWithCustomerKeyValue = "ConfidentialVM_DiskEncryptedWithCustomerKey";

        /// <summary>
        /// Trusted Launch provides security features such as secure boot and virtual Trusted Platform Module (vTPM)
        /// Serialized Name: DiskSecurityTypes.TrustedLaunch
        /// </summary>
        public static DiskSecurityType TrustedLaunch { get; } = new DiskSecurityType(TrustedLaunchValue);
        /// <summary>
        /// Indicates Confidential VM disk with only VM guest state encrypted
        /// Serialized Name: DiskSecurityTypes.ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey
        /// </summary>
        public static DiskSecurityType ConfidentialVmGuestStateOnlyEncryptedWithPlatformKey { get; } = new DiskSecurityType(ConfidentialVmGuestStateOnlyEncryptedWithPlatformKeyValue);
        /// <summary>
        /// Indicates Confidential VM disk with both OS disk and VM guest state encrypted with a platform managed key
        /// Serialized Name: DiskSecurityTypes.ConfidentialVM_DiskEncryptedWithPlatformKey
        /// </summary>
        public static DiskSecurityType ConfidentialVmDiskEncryptedWithPlatformKey { get; } = new DiskSecurityType(ConfidentialVmDiskEncryptedWithPlatformKeyValue);
        /// <summary>
        /// Indicates Confidential VM disk with both OS disk and VM guest state encrypted with a customer managed key
        /// Serialized Name: DiskSecurityTypes.ConfidentialVM_DiskEncryptedWithCustomerKey
        /// </summary>
        public static DiskSecurityType ConfidentialVmDiskEncryptedWithCustomerKey { get; } = new DiskSecurityType(ConfidentialVmDiskEncryptedWithCustomerKeyValue);
        /// <summary> Determines if two <see cref="DiskSecurityType"/> values are the same. </summary>
        public static bool operator ==(DiskSecurityType left, DiskSecurityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskSecurityType"/> values are not the same. </summary>
        public static bool operator !=(DiskSecurityType left, DiskSecurityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskSecurityType"/>. </summary>
        public static implicit operator DiskSecurityType(string value) => new DiskSecurityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskSecurityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskSecurityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
