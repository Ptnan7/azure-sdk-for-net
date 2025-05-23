// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    internal class TopicSharedAccessKeysOperationSource : IOperationSource<TopicSharedAccessKeys>
    {
        TopicSharedAccessKeys IOperationSource<TopicSharedAccessKeys>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return TopicSharedAccessKeys.DeserializeTopicSharedAccessKeys(document.RootElement);
        }

        async ValueTask<TopicSharedAccessKeys> IOperationSource<TopicSharedAccessKeys>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return TopicSharedAccessKeys.DeserializeTopicSharedAccessKeys(document.RootElement);
        }
    }
}
