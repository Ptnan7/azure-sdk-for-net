// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// A class representing the IPv6FirewallRule data model.             An IPv6
/// server firewall rule.
/// </summary>
public partial class IPv6FirewallRuleData : ProvisioningConstruct
{
    /// <summary>
    /// The start IP address of the firewall rule. Must be IPv6 format.
    /// </summary>
    public BicepValue<string> StartIPv6Address { get => _startIPv6Address; set => _startIPv6Address.Assign(value); }
    private readonly BicepValue<string> _startIPv6Address;

    /// <summary>
    /// The end IP address of the firewall rule. Must be IPv6 format. Must be
    /// greater than or equal to startIpv6Address.
    /// </summary>
    public BicepValue<string> EndIPv6Address { get => _endIPv6Address; set => _endIPv6Address.Assign(value); }
    private readonly BicepValue<string> _endIPv6Address;

    /// <summary>
    /// Resource ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Resource name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Resource type.
    /// </summary>
    public BicepValue<ResourceType> ResourceType { get => _resourceType; }
    private readonly BicepValue<ResourceType> _resourceType;

    /// <summary>
    /// Creates a new IPv6FirewallRuleData.
    /// </summary>
    public IPv6FirewallRuleData()
    {
        _startIPv6Address = BicepValue<string>.DefineProperty(this, "StartIPv6Address", ["properties", "startIPv6Address"]);
        _endIPv6Address = BicepValue<string>.DefineProperty(this, "EndIPv6Address", ["properties", "endIPv6Address"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _resourceType = BicepValue<ResourceType>.DefineProperty(this, "ResourceType", ["type"], isOutput: true);
    }
}
