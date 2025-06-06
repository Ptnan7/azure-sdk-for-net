// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Sms.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Sms
{
    internal partial class OptOutsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of OptOutsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public OptOutsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2025-05-29-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateAddRequest(string @from, IEnumerable<OptOutRecipient> recipients)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sms/optouts:add", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new OptOutRequest(@from, recipients.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Add phone numbers to the optouts list which shall stop receiving messages from a sender number. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public async Task<Response<OptOutResponse>> AddAsync(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateAddRequest(@from, recipients);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Add phone numbers to the optouts list which shall stop receiving messages from a sender number. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public Response<OptOutResponse> Add(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateAddRequest(@from, recipients);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveRequest(string @from, IEnumerable<OptOutRecipient> recipients)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sms/optouts:remove", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new OptOutRequest(@from, recipients.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Remove phone numbers from the optouts list. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public async Task<Response<OptOutResponse>> RemoveAsync(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateRemoveRequest(@from, recipients);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Remove phone numbers from the optouts list. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public Response<OptOutResponse> Remove(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateRemoveRequest(@from, recipients);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCheckRequest(string @from, IEnumerable<OptOutRecipient> recipients)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sms/optouts:check", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new OptOutRequest(@from, recipients.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Check the opt out status for a recipient phone number with a sender phone number. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public async Task<Response<OptOutResponse>> CheckAsync(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateCheckRequest(@from, recipients);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Check the opt out status for a recipient phone number with a sender phone number. </summary>
        /// <param name="from"> The sender's identifier (typically phone number in E.164 format) that is owned by the authenticated account. </param>
        /// <param name="recipients"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="OptOutRecipient"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/> or <paramref name="recipients"/> is null. </exception>
        public Response<OptOutResponse> Check(string @from, IEnumerable<OptOutRecipient> recipients, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (recipients == null)
            {
                throw new ArgumentNullException(nameof(recipients));
            }

            using var message = CreateCheckRequest(@from, recipients);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OptOutResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = OptOutResponse.DeserializeOptOutResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
