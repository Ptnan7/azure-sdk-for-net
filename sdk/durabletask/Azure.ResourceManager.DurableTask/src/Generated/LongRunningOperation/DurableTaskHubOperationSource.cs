// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DurableTask
{
    internal class DurableTaskHubOperationSource : IOperationSource<DurableTaskHubResource>
    {
        private readonly ArmClient _client;

        internal DurableTaskHubOperationSource(ArmClient client)
        {
            _client = client;
        }

        DurableTaskHubResource IOperationSource<DurableTaskHubResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DurableTaskHubData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDurableTaskContext.Default);
            return new DurableTaskHubResource(_client, data);
        }

        async ValueTask<DurableTaskHubResource> IOperationSource<DurableTaskHubResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DurableTaskHubData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDurableTaskContext.Default);
            return await Task.FromResult(new DurableTaskHubResource(_client, data)).ConfigureAwait(false);
        }
    }
}
