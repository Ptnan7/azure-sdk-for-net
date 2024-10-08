// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;
using System.Net;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SitePrivateEndpointConnection.
/// </summary>
public partial class SitePrivateEndpointConnection : Resource
{
    /// <summary>
    /// The System.String to use.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Private IPAddresses mapped to the remote private endpoint.
    /// </summary>
    public BicepList<IPAddress> IPAddresses { get => _iPAddresses; set => _iPAddresses.Assign(value); }
    private readonly BicepList<IPAddress> _iPAddresses;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The state of a private link connection.
    /// </summary>
    public BicepValue<PrivateLinkConnectionState> PrivateLinkServiceConnectionState { get => _privateLinkServiceConnectionState; set => _privateLinkServiceConnectionState.Assign(value); }
    private readonly BicepValue<PrivateLinkConnectionState> _privateLinkServiceConnectionState;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Gets the provisioning state.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSite> _parent;

    /// <summary>
    /// Creates a new SitePrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SitePrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SitePrivateEndpointConnection.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SitePrivateEndpointConnection(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/privateEndpointConnections", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _iPAddresses = BicepList<IPAddress>.DefineProperty(this, "IPAddresses", ["properties", "ipAddresses"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _privateLinkServiceConnectionState = BicepValue<PrivateLinkConnectionState>.DefineProperty(this, "PrivateLinkServiceConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SitePrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SitePrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SitePrivateEndpointConnection.</param>
    /// <returns>The existing SitePrivateEndpointConnection resource.</returns>
    public static SitePrivateEndpointConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SitePrivateEndpointConnection
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 2, maxLength: 64, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
