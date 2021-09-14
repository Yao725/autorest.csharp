// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Resource status of the policy. </summary>
    public readonly partial struct PolicyResourceState : IEquatable<PolicyResourceState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PolicyResourceState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string EnablingValue = "Enabling";
        private const string EnabledValue = "Enabled";
        private const string DisablingValue = "Disabling";
        private const string DisabledValue = "Disabled";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static PolicyResourceState Creating { get; } = new PolicyResourceState(CreatingValue);
        /// <summary> Enabling. </summary>
        public static PolicyResourceState Enabling { get; } = new PolicyResourceState(EnablingValue);
        /// <summary> Enabled. </summary>
        public static PolicyResourceState Enabled { get; } = new PolicyResourceState(EnabledValue);
        /// <summary> Disabling. </summary>
        public static PolicyResourceState Disabling { get; } = new PolicyResourceState(DisablingValue);
        /// <summary> Disabled. </summary>
        public static PolicyResourceState Disabled { get; } = new PolicyResourceState(DisabledValue);
        /// <summary> Deleting. </summary>
        public static PolicyResourceState Deleting { get; } = new PolicyResourceState(DeletingValue);
        /// <summary> Determines if two <see cref="PolicyResourceState"/> values are the same. </summary>
        public static bool operator ==(PolicyResourceState left, PolicyResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyResourceState"/> values are not the same. </summary>
        public static bool operator !=(PolicyResourceState left, PolicyResourceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyResourceState"/>. </summary>
        public static implicit operator PolicyResourceState(string value) => new PolicyResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
