// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SiteManager.Models
{
    /// <summary> The provisioning state of a resource type. </summary>
    public readonly partial struct EdgeSiteProvisioningState : IEquatable<EdgeSiteProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeSiteProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeSiteProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Resource has been created. </summary>
        public static EdgeSiteProvisioningState Succeeded { get; } = new EdgeSiteProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static EdgeSiteProvisioningState Failed { get; } = new EdgeSiteProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static EdgeSiteProvisioningState Canceled { get; } = new EdgeSiteProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="EdgeSiteProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EdgeSiteProvisioningState left, EdgeSiteProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeSiteProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EdgeSiteProvisioningState left, EdgeSiteProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeSiteProvisioningState"/>. </summary>
        public static implicit operator EdgeSiteProvisioningState(string value) => new EdgeSiteProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeSiteProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeSiteProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
