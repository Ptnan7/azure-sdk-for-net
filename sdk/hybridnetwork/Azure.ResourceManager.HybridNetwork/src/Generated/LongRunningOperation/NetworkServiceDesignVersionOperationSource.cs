// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class NetworkServiceDesignVersionOperationSource : IOperationSource<NetworkServiceDesignVersionResource>
    {
        private readonly ArmClient _client;

        internal NetworkServiceDesignVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkServiceDesignVersionResource IOperationSource<NetworkServiceDesignVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkServiceDesignVersionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridNetworkContext.Default);
            return new NetworkServiceDesignVersionResource(_client, data);
        }

        async ValueTask<NetworkServiceDesignVersionResource> IOperationSource<NetworkServiceDesignVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkServiceDesignVersionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHybridNetworkContext.Default);
            return await Task.FromResult(new NetworkServiceDesignVersionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
