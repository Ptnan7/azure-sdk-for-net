// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Describes operator to be matched
    /// Serialized Name: HostNameOperator
    /// </summary>
    public readonly partial struct HostNameOperator : IEquatable<HostNameOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostNameOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostNameOperator(string value)
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

        /// <summary>
        /// Any
        /// Serialized Name: HostNameOperator.Any
        /// </summary>
        public static HostNameOperator Any { get; } = new HostNameOperator(AnyValue);
        /// <summary>
        /// Equal
        /// Serialized Name: HostNameOperator.Equal
        /// </summary>
        public static HostNameOperator Equal { get; } = new HostNameOperator(EqualValue);
        /// <summary>
        /// Contains
        /// Serialized Name: HostNameOperator.Contains
        /// </summary>
        public static HostNameOperator Contains { get; } = new HostNameOperator(ContainsValue);
        /// <summary>
        /// BeginsWith
        /// Serialized Name: HostNameOperator.BeginsWith
        /// </summary>
        public static HostNameOperator BeginsWith { get; } = new HostNameOperator(BeginsWithValue);
        /// <summary>
        /// EndsWith
        /// Serialized Name: HostNameOperator.EndsWith
        /// </summary>
        public static HostNameOperator EndsWith { get; } = new HostNameOperator(EndsWithValue);
        /// <summary>
        /// LessThan
        /// Serialized Name: HostNameOperator.LessThan
        /// </summary>
        public static HostNameOperator LessThan { get; } = new HostNameOperator(LessThanValue);
        /// <summary>
        /// LessThanOrEqual
        /// Serialized Name: HostNameOperator.LessThanOrEqual
        /// </summary>
        public static HostNameOperator LessThanOrEqual { get; } = new HostNameOperator(LessThanOrEqualValue);
        /// <summary>
        /// GreaterThan
        /// Serialized Name: HostNameOperator.GreaterThan
        /// </summary>
        public static HostNameOperator GreaterThan { get; } = new HostNameOperator(GreaterThanValue);
        /// <summary>
        /// GreaterThanOrEqual
        /// Serialized Name: HostNameOperator.GreaterThanOrEqual
        /// </summary>
        public static HostNameOperator GreaterThanOrEqual { get; } = new HostNameOperator(GreaterThanOrEqualValue);
        /// <summary>
        /// RegEx
        /// Serialized Name: HostNameOperator.RegEx
        /// </summary>
        public static HostNameOperator RegEx { get; } = new HostNameOperator(RegExValue);
        /// <summary> Determines if two <see cref="HostNameOperator"/> values are the same. </summary>
        public static bool operator ==(HostNameOperator left, HostNameOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostNameOperator"/> values are not the same. </summary>
        public static bool operator !=(HostNameOperator left, HostNameOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HostNameOperator"/>. </summary>
        public static implicit operator HostNameOperator(string value) => new HostNameOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostNameOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostNameOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
