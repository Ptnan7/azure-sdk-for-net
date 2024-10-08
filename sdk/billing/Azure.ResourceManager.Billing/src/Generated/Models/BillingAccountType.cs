// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The type of customer. </summary>
    public readonly partial struct BillingAccountType : IEquatable<BillingAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string EnterpriseValue = "Enterprise";
        private const string IndividualValue = "Individual";
        private const string PartnerValue = "Partner";
        private const string ResellerValue = "Reseller";
        private const string ClassicPartnerValue = "ClassicPartner";
        private const string InternalValue = "Internal";
        private const string TenantValue = "Tenant";
        private const string BusinessValue = "Business";

        /// <summary> Other. </summary>
        public static BillingAccountType Other { get; } = new BillingAccountType(OtherValue);
        /// <summary> Enterprise. </summary>
        public static BillingAccountType Enterprise { get; } = new BillingAccountType(EnterpriseValue);
        /// <summary> Individual. </summary>
        public static BillingAccountType Individual { get; } = new BillingAccountType(IndividualValue);
        /// <summary> Partner. </summary>
        public static BillingAccountType Partner { get; } = new BillingAccountType(PartnerValue);
        /// <summary> Reseller. </summary>
        public static BillingAccountType Reseller { get; } = new BillingAccountType(ResellerValue);
        /// <summary> ClassicPartner. </summary>
        public static BillingAccountType ClassicPartner { get; } = new BillingAccountType(ClassicPartnerValue);
        /// <summary> Internal. </summary>
        public static BillingAccountType Internal { get; } = new BillingAccountType(InternalValue);
        /// <summary> Tenant. </summary>
        public static BillingAccountType Tenant { get; } = new BillingAccountType(TenantValue);
        /// <summary> Business. </summary>
        public static BillingAccountType Business { get; } = new BillingAccountType(BusinessValue);
        /// <summary> Determines if two <see cref="BillingAccountType"/> values are the same. </summary>
        public static bool operator ==(BillingAccountType left, BillingAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingAccountType"/> values are not the same. </summary>
        public static bool operator !=(BillingAccountType left, BillingAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BillingAccountType"/>. </summary>
        public static implicit operator BillingAccountType(string value) => new BillingAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
