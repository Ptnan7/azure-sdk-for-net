// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyRemediationResource : IJsonModel<PolicyRemediationData>
    {
        private static PolicyRemediationData s_dataDeserializationInstance;
        private static PolicyRemediationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PolicyRemediationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PolicyRemediationData>)Data).Write(writer, options);

        PolicyRemediationData IJsonModel<PolicyRemediationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PolicyRemediationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PolicyRemediationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PolicyRemediationData>(Data, options, AzureResourceManagerPolicyInsightsContext.Default);

        PolicyRemediationData IPersistableModel<PolicyRemediationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PolicyRemediationData>(data, options, AzureResourceManagerPolicyInsightsContext.Default);

        string IPersistableModel<PolicyRemediationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PolicyRemediationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
