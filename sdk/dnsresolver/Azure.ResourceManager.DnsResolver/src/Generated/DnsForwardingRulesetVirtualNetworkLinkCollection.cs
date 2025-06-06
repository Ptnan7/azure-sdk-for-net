// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> and their operations.
    /// Each <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> in the collection will belong to the same instance of <see cref="DnsForwardingRulesetResource"/>.
    /// To get a <see cref="DnsForwardingRulesetVirtualNetworkLinkCollection"/> instance call the GetDnsForwardingRulesetVirtualNetworkLinks method from an instance of <see cref="DnsForwardingRulesetResource"/>.
    /// </summary>
    public partial class DnsForwardingRulesetVirtualNetworkLinkCollection : ArmCollection, IEnumerable<DnsForwardingRulesetVirtualNetworkLinkResource>, IAsyncEnumerable<DnsForwardingRulesetVirtualNetworkLinkResource>
    {
        private readonly ClientDiagnostics _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics;
        private readonly VirtualNetworkLinksRestOperations _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetVirtualNetworkLinkCollection"/> class for mocking. </summary>
        protected DnsForwardingRulesetVirtualNetworkLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsForwardingRulesetVirtualNetworkLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsForwardingRulesetVirtualNetworkLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsForwardingRulesetVirtualNetworkLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsForwardingRulesetVirtualNetworkLinkResource.ResourceType, out string dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksApiVersion);
            _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient = new VirtualNetworkLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsForwardingRulesetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsForwardingRulesetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_CreateOrUpdate</description>
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkLinkName, DnsForwardingRulesetVirtualNetworkLinkData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>(new DnsForwardingRulesetVirtualNetworkLinkOperationSource(Client), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a virtual network link to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_CreateOrUpdate</description>
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkLinkName, DnsForwardingRulesetVirtualNetworkLinkData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsForwardingRulesetVirtualNetworkLinkResource>(new DnsForwardingRulesetVirtualNetworkLinkOperationSource(Client), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<Response<DnsForwardingRulesetVirtualNetworkLinkResource>> GetAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken).ConfigureAwait(false);
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<DnsForwardingRulesetVirtualNetworkLinkResource> Get(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken);
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
        /// Lists virtual network links to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_List</description>
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
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsForwardingRulesetVirtualNetworkLinkResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsForwardingRulesetVirtualNetworkLinkResource(Client, DnsForwardingRulesetVirtualNetworkLinkData.DeserializeDnsForwardingRulesetVirtualNetworkLinkData(e)), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, "DnsForwardingRulesetVirtualNetworkLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists virtual network links to a DNS forwarding ruleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsForwardingRulesets/{dnsForwardingRulesetName}/virtualNetworkLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_List</description>
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
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsForwardingRulesetVirtualNetworkLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsForwardingRulesetVirtualNetworkLinkResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsForwardingRulesetVirtualNetworkLinkResource(Client, DnsForwardingRulesetVirtualNetworkLinkData.DeserializeDnsForwardingRulesetVirtualNetworkLinkData(e)), _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics, Pipeline, "DnsForwardingRulesetVirtualNetworkLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<NullableResponse<DnsForwardingRulesetVirtualNetworkLinkResource>> GetIfExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DnsForwardingRulesetVirtualNetworkLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetVirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual NullableResponse<DnsForwardingRulesetVirtualNetworkLinkResource> GetIfExists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksClientDiagnostics.CreateScope("DnsForwardingRulesetVirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dnsForwardingRulesetVirtualNetworkLinkVirtualNetworkLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DnsForwardingRulesetVirtualNetworkLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DnsForwardingRulesetVirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsForwardingRulesetVirtualNetworkLinkResource> IEnumerable<DnsForwardingRulesetVirtualNetworkLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsForwardingRulesetVirtualNetworkLinkResource> IAsyncEnumerable<DnsForwardingRulesetVirtualNetworkLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
