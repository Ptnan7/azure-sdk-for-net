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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal partial class DiskRestorePointRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DiskRestorePointRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DiskRestorePointRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-01-02";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByRestorePointRequestUri(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByRestorePointRequest(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName)
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
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiskRestorePointList>> ListByRestorePointAsync(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));

            using var message = CreateListByRestorePointRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = DiskRestorePointList.DeserializeDiskRestorePointList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiskRestorePointList> ListByRestorePoint(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));

            using var message = CreateListByRestorePointRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = DiskRestorePointList.DeserializeDiskRestorePointList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName)
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
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiskRestorePointData>> GetAsync(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = DiskRestorePointData.DeserializeDiskRestorePointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DiskRestorePointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiskRestorePointData> Get(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = DiskRestorePointData.DeserializeDiskRestorePointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DiskRestorePointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGrantAccessRequestUri(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, GrantAccessData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendPath("/beginGetAccess", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGrantAccessRequest(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, GrantAccessData data)
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
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendPath("/beginGetAccess", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Grants access to a diskRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="data"> Access data object supplied in the body of the get disk access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/>, <paramref name="diskRestorePointName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> GrantAccessAsync(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, GrantAccessData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateGrantAccessRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Grants access to a diskRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="data"> Access data object supplied in the body of the get disk access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/>, <paramref name="diskRestorePointName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response GrantAccess(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, GrantAccessData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateGrantAccessRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateRevokeAccessRequestUri(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendPath("/endGetAccess", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateRevokeAccessRequest(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName)
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
            uri.AppendPath("/providers/Microsoft.Compute/restorePointCollections/", false);
            uri.AppendPath(restorePointGroupName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(vmRestorePointName, true);
            uri.AppendPath("/diskRestorePoints/", false);
            uri.AppendPath(diskRestorePointName, true);
            uri.AppendPath("/endGetAccess", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Revokes access to a diskRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> RevokeAccessAsync(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var message = CreateRevokeAccessRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Revokes access to a diskRestorePoint. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="diskRestorePointName"> The name of the DiskRestorePoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/>, <paramref name="vmRestorePointName"/> or <paramref name="diskRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response RevokeAccess(string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var message = CreateRevokeAccessRequest(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByRestorePointNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByRestorePointNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName)
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

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiskRestorePointList>> ListByRestorePointNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));

            using var message = CreateListByRestorePointNextPageRequest(nextLink, subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = DiskRestorePointList.DeserializeDiskRestorePointList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="restorePointGroupName"> The name of the restore point collection that the disk restore point belongs. </param>
        /// <param name="vmRestorePointName"> The name of the vm restore point that the disk disk restore point belongs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="restorePointGroupName"/> or <paramref name="vmRestorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiskRestorePointList> ListByRestorePointNextPage(string nextLink, string subscriptionId, string resourceGroupName, string restorePointGroupName, string vmRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(restorePointGroupName, nameof(restorePointGroupName));
            Argument.AssertNotNullOrEmpty(vmRestorePointName, nameof(vmRestorePointName));

            using var message = CreateListByRestorePointNextPageRequest(nextLink, subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiskRestorePointList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = DiskRestorePointList.DeserializeDiskRestorePointList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
