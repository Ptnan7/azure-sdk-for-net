﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Autorest.CSharp.Core;
using Azure.Core.Pipeline;
using Azure.Core;
using Azure.ResourceManager.Resources;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ChaosTargetTypeResource"/> and their operations.
    /// Each <see cref="ChaosTargetTypeResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="ChaosTargetTypeCollection"/> instance call the GetChaosTargetTypes method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `ChaosTargetMetadataCollection` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ChaosTargetTypeCollection : ArmCollection, IEnumerable<ChaosTargetTypeResource>, IAsyncEnumerable<ChaosTargetTypeResource>
    {
        private readonly ClientDiagnostics _chaosTargetTypeTargetTypesClientDiagnostics;
        private readonly TargetTypesRestOperations _chaosTargetTypeTargetTypesRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetTypeCollection"/> class for mocking. </summary>
        protected ChaosTargetTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ChaosTargetTypeCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _chaosTargetTypeTargetTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ChaosTargetTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ChaosTargetTypeResource.ResourceType, out string chaosTargetTypeTargetTypesApiVersion);
            _chaosTargetTypeTargetTypesRestClient = new TargetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosTargetTypeTargetTypesApiVersion);
#if DEBUG
            ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<Response<ChaosTargetTypeResource>> GetAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _chaosTargetTypeTargetTypesRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual Response<ChaosTargetTypeResource> Get(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _chaosTargetTypeTargetTypesRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ChaosTargetTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ChaosTargetTypeResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosTargetTypeTargetTypesRestClient.CreateListRequest(Id.SubscriptionId, _locationName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosTargetTypeTargetTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _locationName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ChaosTargetTypeResource(Client, ChaosTargetTypeData.DeserializeChaosTargetTypeData(e)), _chaosTargetTypeTargetTypesClientDiagnostics, Pipeline, "ChaosTargetTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ChaosTargetTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ChaosTargetTypeResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosTargetTypeTargetTypesRestClient.CreateListRequest(Id.SubscriptionId, _locationName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosTargetTypeTargetTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _locationName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ChaosTargetTypeResource(Client, ChaosTargetTypeData.DeserializeChaosTargetTypeData(e)), _chaosTargetTypeTargetTypesClientDiagnostics, Pipeline, "ChaosTargetTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _chaosTargetTypeTargetTypesRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _chaosTargetTypeTargetTypesRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<ChaosTargetTypeResource>> GetIfExistsAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _chaosTargetTypeTargetTypesRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ChaosTargetTypeResource>(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual NullableResponse<ChaosTargetTypeResource> GetIfExists(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _chaosTargetTypeTargetTypesClientDiagnostics.CreateScope("ChaosTargetTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _chaosTargetTypeTargetTypesRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ChaosTargetTypeResource>(response.GetRawResponse());
                var targetTypeResponse = CustomizationHelper.GetTargetTypeData(response.Value);
                return Response.FromValue(new ChaosTargetTypeResource(Client, targetTypeResponse), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ChaosTargetTypeResource> IEnumerable<ChaosTargetTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ChaosTargetTypeResource> IAsyncEnumerable<ChaosTargetTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
