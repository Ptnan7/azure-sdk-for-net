// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class SqlServerJobExecutionOperationSource : IOperationSource<SqlServerJobExecutionResource>
    {
        private readonly ArmClient _client;

        internal SqlServerJobExecutionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerJobExecutionResource IOperationSource<SqlServerJobExecutionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SqlServerJobExecutionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return new SqlServerJobExecutionResource(_client, data);
        }

        async ValueTask<SqlServerJobExecutionResource> IOperationSource<SqlServerJobExecutionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SqlServerJobExecutionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return await Task.FromResult(new SqlServerJobExecutionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
