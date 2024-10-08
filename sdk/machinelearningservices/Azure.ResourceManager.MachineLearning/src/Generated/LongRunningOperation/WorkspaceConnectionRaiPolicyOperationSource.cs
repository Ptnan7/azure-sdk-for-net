// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class WorkspaceConnectionRaiPolicyOperationSource : IOperationSource<WorkspaceConnectionRaiPolicyResource>
    {
        private readonly ArmClient _client;

        internal WorkspaceConnectionRaiPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkspaceConnectionRaiPolicyResource IOperationSource<WorkspaceConnectionRaiPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RaiPolicyPropertiesBasicResourceData.DeserializeRaiPolicyPropertiesBasicResourceData(document.RootElement);
            return new WorkspaceConnectionRaiPolicyResource(_client, data);
        }

        async ValueTask<WorkspaceConnectionRaiPolicyResource> IOperationSource<WorkspaceConnectionRaiPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RaiPolicyPropertiesBasicResourceData.DeserializeRaiPolicyPropertiesBasicResourceData(document.RootElement);
            return new WorkspaceConnectionRaiPolicyResource(_client, data);
        }
    }
}
