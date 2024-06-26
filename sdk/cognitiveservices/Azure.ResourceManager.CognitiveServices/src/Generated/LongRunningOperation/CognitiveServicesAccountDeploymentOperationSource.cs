// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices
{
    internal class CognitiveServicesAccountDeploymentOperationSource : IOperationSource<CognitiveServicesAccountDeploymentResource>
    {
        private readonly ArmClient _client;

        internal CognitiveServicesAccountDeploymentOperationSource(ArmClient client)
        {
            _client = client;
        }

        CognitiveServicesAccountDeploymentResource IOperationSource<CognitiveServicesAccountDeploymentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CognitiveServicesAccountDeploymentData.DeserializeCognitiveServicesAccountDeploymentData(document.RootElement);
            return new CognitiveServicesAccountDeploymentResource(_client, data);
        }

        async ValueTask<CognitiveServicesAccountDeploymentResource> IOperationSource<CognitiveServicesAccountDeploymentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CognitiveServicesAccountDeploymentData.DeserializeCognitiveServicesAccountDeploymentData(document.RootElement);
            return new CognitiveServicesAccountDeploymentResource(_client, data);
        }
    }
}
