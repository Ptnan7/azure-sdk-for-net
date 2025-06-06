// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlPrivateEndpointConnectionResource : IJsonModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>
    {
        private static CosmosDBForPostgreSqlPrivateEndpointConnectionData s_dataDeserializationInstance;
        private static CosmosDBForPostgreSqlPrivateEndpointConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>)Data).Write(writer, options);

        CosmosDBForPostgreSqlPrivateEndpointConnectionData IJsonModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(Data, options, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);

        CosmosDBForPostgreSqlPrivateEndpointConnectionData IPersistableModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(data, options, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);

        string IPersistableModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBForPostgreSqlPrivateEndpointConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
