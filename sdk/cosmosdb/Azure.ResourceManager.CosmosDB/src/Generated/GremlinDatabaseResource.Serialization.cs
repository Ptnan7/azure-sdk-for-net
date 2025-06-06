// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class GremlinDatabaseResource : IJsonModel<GremlinDatabaseData>
    {
        private static GremlinDatabaseData s_dataDeserializationInstance;
        private static GremlinDatabaseData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<GremlinDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GremlinDatabaseData>)Data).Write(writer, options);

        GremlinDatabaseData IJsonModel<GremlinDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GremlinDatabaseData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<GremlinDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GremlinDatabaseData>(Data, options, AzureResourceManagerCosmosDBContext.Default);

        GremlinDatabaseData IPersistableModel<GremlinDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GremlinDatabaseData>(data, options, AzureResourceManagerCosmosDBContext.Default);

        string IPersistableModel<GremlinDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GremlinDatabaseData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
