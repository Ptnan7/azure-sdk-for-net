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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkSecurityPerimeterProfileResource"/> and their operations.
    /// Each <see cref="NetworkSecurityPerimeterProfileResource"/> in the collection will belong to the same instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// To get a <see cref="NetworkSecurityPerimeterProfileCollection"/> instance call the GetNetworkSecurityPerimeterProfiles method from an instance of <see cref="NetworkSecurityPerimeterResource"/>.
    /// </summary>
    public partial class NetworkSecurityPerimeterProfileCollection : ArmCollection, IEnumerable<NetworkSecurityPerimeterProfileResource>, IAsyncEnumerable<NetworkSecurityPerimeterProfileResource>
    {
        private readonly ClientDiagnostics _networkSecurityPerimeterProfileClientDiagnostics;
        private readonly NetworkSecurityPerimeterProfilesRestOperations _networkSecurityPerimeterProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterProfileCollection"/> class for mocking. </summary>
        protected NetworkSecurityPerimeterProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityPerimeterProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityPerimeterProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityPerimeterProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkSecurityPerimeterProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkSecurityPerimeterProfileResource.ResourceType, out string networkSecurityPerimeterProfileApiVersion);
            _networkSecurityPerimeterProfileRestClient = new NetworkSecurityPerimeterProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityPerimeterProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityPerimeterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityPerimeterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="data"> Parameters that hold the NspProfile resource to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkSecurityPerimeterProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string profileName, NetworkSecurityPerimeterProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data, cancellationToken).ConfigureAwait(false);
                var uri = _networkSecurityPerimeterProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkSecurityPerimeterProfileResource>(Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a network profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="data"> Parameters that hold the NspProfile resource to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkSecurityPerimeterProfileResource> CreateOrUpdate(WaitUntil waitUntil, string profileName, NetworkSecurityPerimeterProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterProfileRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data, cancellationToken);
                var uri = _networkSecurityPerimeterProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkSecurityPerimeterProfileResource>(Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the specified NSP profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityPerimeterProfileResource>> GetAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified NSP profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<NetworkSecurityPerimeterProfileResource> Get(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the NSP profiles in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityPerimeterProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityPerimeterProfileResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterProfileRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterProfileRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterProfileResource(Client, NetworkSecurityPerimeterProfileData.DeserializeNetworkSecurityPerimeterProfileData(e)), _networkSecurityPerimeterProfileClientDiagnostics, Pipeline, "NetworkSecurityPerimeterProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the NSP profiles in the specified network security perimeter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityPerimeterProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityPerimeterProfileResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityPerimeterProfileRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityPerimeterProfileRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityPerimeterProfileResource(Client, NetworkSecurityPerimeterProfileData.DeserializeNetworkSecurityPerimeterProfileData(e)), _networkSecurityPerimeterProfileClientDiagnostics, Pipeline, "NetworkSecurityPerimeterProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<bool> Exists(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkSecurityPerimeterProfileResource>> GetIfExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityPerimeterProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterProfileResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityPerimeters/{networkSecurityPerimeterName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkSecurityPerimeterProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the NSP profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual NullableResponse<NetworkSecurityPerimeterProfileResource> GetIfExists(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _networkSecurityPerimeterProfileClientDiagnostics.CreateScope("NetworkSecurityPerimeterProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityPerimeterProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityPerimeterProfileResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityPerimeterProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityPerimeterProfileResource> IEnumerable<NetworkSecurityPerimeterProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityPerimeterProfileResource> IAsyncEnumerable<NetworkSecurityPerimeterProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
