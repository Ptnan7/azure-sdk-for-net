// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql
{
    internal class MySqlConfigurationOperationSource : IOperationSource<MySqlConfigurationResource>
    {
        private readonly ArmClient _client;

        internal MySqlConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlConfigurationResource IOperationSource<MySqlConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlConfigurationData.DeserializeMySqlConfigurationData(document.RootElement);
            return new MySqlConfigurationResource(_client, data);
        }

        async ValueTask<MySqlConfigurationResource> IOperationSource<MySqlConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlConfigurationData.DeserializeMySqlConfigurationData(document.RootElement);
            return new MySqlConfigurationResource(_client, data);
        }
    }
}
