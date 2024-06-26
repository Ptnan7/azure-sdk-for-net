// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class ManagedBackupShortTermRetentionPolicyOperationSource : IOperationSource<ManagedBackupShortTermRetentionPolicyResource>
    {
        private readonly ArmClient _client;

        internal ManagedBackupShortTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedBackupShortTermRetentionPolicyResource IOperationSource<ManagedBackupShortTermRetentionPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedBackupShortTermRetentionPolicyResource(_client, data);
        }

        async ValueTask<ManagedBackupShortTermRetentionPolicyResource> IOperationSource<ManagedBackupShortTermRetentionPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedBackupShortTermRetentionPolicyResource(_client, data);
        }
    }
}
