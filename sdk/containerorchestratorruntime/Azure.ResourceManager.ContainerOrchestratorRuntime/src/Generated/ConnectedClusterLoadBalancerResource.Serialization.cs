// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    public partial class ConnectedClusterLoadBalancerResource : IJsonModel<ConnectedClusterLoadBalancerData>
    {
        private static ConnectedClusterLoadBalancerData s_dataDeserializationInstance;
        private static ConnectedClusterLoadBalancerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ConnectedClusterLoadBalancerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ConnectedClusterLoadBalancerData>)Data).Write(writer, options);

        ConnectedClusterLoadBalancerData IJsonModel<ConnectedClusterLoadBalancerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ConnectedClusterLoadBalancerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ConnectedClusterLoadBalancerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ConnectedClusterLoadBalancerData>(Data, options, AzureResourceManagerContainerOrchestratorRuntimeContext.Default);

        ConnectedClusterLoadBalancerData IPersistableModel<ConnectedClusterLoadBalancerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ConnectedClusterLoadBalancerData>(data, options, AzureResourceManagerContainerOrchestratorRuntimeContext.Default);

        string IPersistableModel<ConnectedClusterLoadBalancerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ConnectedClusterLoadBalancerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
