// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Type of the Applied Scope. </summary>
    public readonly partial struct BillingAppliedScopeType : IEquatable<BillingAppliedScopeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingAppliedScopeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingAppliedScopeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleValue = "Single";
        private const string SharedValue = "Shared";
        private const string ManagementGroupValue = "ManagementGroup";

        /// <summary> Single. </summary>
        public static BillingAppliedScopeType Single { get; } = new BillingAppliedScopeType(SingleValue);
        /// <summary> Shared. </summary>
        public static BillingAppliedScopeType Shared { get; } = new BillingAppliedScopeType(SharedValue);
        /// <summary> ManagementGroup. </summary>
        public static BillingAppliedScopeType ManagementGroup { get; } = new BillingAppliedScopeType(ManagementGroupValue);
        /// <summary> Determines if two <see cref="BillingAppliedScopeType"/> values are the same. </summary>
        public static bool operator ==(BillingAppliedScopeType left, BillingAppliedScopeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingAppliedScopeType"/> values are not the same. </summary>
        public static bool operator !=(BillingAppliedScopeType left, BillingAppliedScopeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BillingAppliedScopeType"/>. </summary>
        public static implicit operator BillingAppliedScopeType(string value) => new BillingAppliedScopeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingAppliedScopeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingAppliedScopeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
