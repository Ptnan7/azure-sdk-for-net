// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CognitiveServices
{
    public partial class CognitiveServicesPrivateEndpointConnectionResource : IJsonModel<CognitiveServicesPrivateEndpointConnectionData>
    {
        private static CognitiveServicesPrivateEndpointConnectionData s_dataDeserializationInstance;
        private static CognitiveServicesPrivateEndpointConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<CognitiveServicesPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesPrivateEndpointConnectionData>)Data).Write(writer, options);

        CognitiveServicesPrivateEndpointConnectionData IJsonModel<CognitiveServicesPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CognitiveServicesPrivateEndpointConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<CognitiveServicesPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CognitiveServicesPrivateEndpointConnectionData>(Data, options, AzureResourceManagerCognitiveServicesContext.Default);

        CognitiveServicesPrivateEndpointConnectionData IPersistableModel<CognitiveServicesPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CognitiveServicesPrivateEndpointConnectionData>(data, options, AzureResourceManagerCognitiveServicesContext.Default);

        string IPersistableModel<CognitiveServicesPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CognitiveServicesPrivateEndpointConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
