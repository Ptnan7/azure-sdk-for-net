// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RelationshipLinkResourceFormatResource : IJsonModel<RelationshipLinkResourceFormatData>
    {
        private static RelationshipLinkResourceFormatData s_dataDeserializationInstance;
        private static RelationshipLinkResourceFormatData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<RelationshipLinkResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RelationshipLinkResourceFormatData>)Data).Write(writer, options);

        RelationshipLinkResourceFormatData IJsonModel<RelationshipLinkResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RelationshipLinkResourceFormatData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<RelationshipLinkResourceFormatData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RelationshipLinkResourceFormatData>(Data, options, AzureResourceManagerCustomerInsightsContext.Default);

        RelationshipLinkResourceFormatData IPersistableModel<RelationshipLinkResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RelationshipLinkResourceFormatData>(data, options, AzureResourceManagerCustomerInsightsContext.Default);

        string IPersistableModel<RelationshipLinkResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RelationshipLinkResourceFormatData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
