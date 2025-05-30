// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DnsResolver.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A Class representing a DnsForwardingRulesetVirtualNetworkLink along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDnsForwardingRulesetVirtualNetworkLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="DnsForwardingRulesetResource"/> using the GetDnsForwardingRulesetVirtualNetworkLink method.
    /// </summary>
    public partial class DnsForwardingRulesetVirtualNetworkLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="rulesetName"> The rulesetName. </param>
        /// <param name="virtualNetworkLinkName"> The virtualNetworkLinkName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string rulesetName, string virtualNetworkLinkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{rulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics;
        private readonly VirtualNetworkLinksRestOperations _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient;
        private readonly DnsForwardingRulesetVirtualNetworkLinkData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/dnsForwardingRulesets/virtualNetworkLinks";

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> class for mocking. </summary>
        protected DnsForwardingRulesetVirtualNetworkLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DnsForwardingRulesetVirtualNetworkLinkResource(ArmClient client, DnsForwardingRulesetVirtualNetworkLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DnsForwardingRulesetVirtualNetworkLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksApiVersion);
            _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient = new VirtualNetworkLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DnsForwardingRulesetVirtualNetworkLinkData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsForwardingRulesetVirtualNetworkLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetVirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsForwardingRulesetVirtualNetworkLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Get");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetVirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a virtual network link to a DNS forwarding ruleset. WARNING: This operation cannot be undone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Delete");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation(_dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a virtual network link to a DNS forwarding ruleset. WARNING: This operation cannot be undone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Delete");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new DnsResolverArmOperation(_dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>> UpdateAsync(WaitUntil waitUntil, DnsForwardingRulesetVirtualNetworkLinkPatch patch, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Update");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>(new DnsForwardingRulesetVirtualNetworkLinkOperationSource(Client), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource> Update(WaitUntil waitUntil, DnsForwardingRulesetVirtualNetworkLinkPatch patch, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkResource.Update");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>(new DnsForwardingRulesetVirtualNetworkLinkOperationSource(Client), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
