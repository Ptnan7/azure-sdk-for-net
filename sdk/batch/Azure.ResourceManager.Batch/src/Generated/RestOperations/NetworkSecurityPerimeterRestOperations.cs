// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Batch.Models;

namespace Azure.ResourceManager.Batch
{
    internal partial class NetworkSecurityPerimeterRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of NetworkSecurityPerimeterRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public NetworkSecurityPerimeterRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-07-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListConfigurationsRequestUri(string subscriptionId, string resourceGroupName, string accountName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListConfigurationsRequest(string subscriptionId, string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the NSP configurations in the specified account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkSecurityPerimeterConfigurationListResult>> ListConfigurationsAsync(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListConfigurationsRequest(subscriptionId, resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = NetworkSecurityPerimeterConfigurationListResult.DeserializeNetworkSecurityPerimeterConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the NSP configurations in the specified account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkSecurityPerimeterConfigurationListResult> ListConfigurations(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListConfigurationsRequest(subscriptionId, resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = NetworkSecurityPerimeterConfigurationListResult.DeserializeNetworkSecurityPerimeterConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetConfigurationRequestUri(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(networkSecurityPerimeterConfigurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetConfigurationRequest(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(networkSecurityPerimeterConfigurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about the specified NSP configuration. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkSecurityPerimeterConfigurationData>> GetConfigurationAsync(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var message = CreateGetConfigurationRequest(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkSecurityPerimeterConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about the specified NSP configuration. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkSecurityPerimeterConfigurationData> GetConfiguration(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var message = CreateGetConfigurationRequest(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkSecurityPerimeterConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateReconcileConfigurationRequestUri(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(networkSecurityPerimeterConfigurationName, true);
            uri.AppendPath("/reconcile", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateReconcileConfigurationRequest(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/networkSecurityPerimeterConfigurations/", false);
            uri.AppendPath(networkSecurityPerimeterConfigurationName, true);
            uri.AppendPath("/reconcile", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Reconciles the specified NSP configuration. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ReconcileConfigurationAsync(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var message = CreateReconcileConfigurationRequest(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reconciles the specified NSP configuration. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="networkSecurityPerimeterConfigurationName"> The name for Network Security Perimeter configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="networkSecurityPerimeterConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response ReconcileConfiguration(string subscriptionId, string resourceGroupName, string accountName, string networkSecurityPerimeterConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(networkSecurityPerimeterConfigurationName, nameof(networkSecurityPerimeterConfigurationName));

            using var message = CreateReconcileConfigurationRequest(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListConfigurationsNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string accountName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListConfigurationsNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the NSP configurations in the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkSecurityPerimeterConfigurationListResult>> ListConfigurationsNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListConfigurationsNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = NetworkSecurityPerimeterConfigurationListResult.DeserializeNetworkSecurityPerimeterConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the NSP configurations in the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkSecurityPerimeterConfigurationListResult> ListConfigurationsNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListConfigurationsNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkSecurityPerimeterConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = NetworkSecurityPerimeterConfigurationListResult.DeserializeNetworkSecurityPerimeterConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
