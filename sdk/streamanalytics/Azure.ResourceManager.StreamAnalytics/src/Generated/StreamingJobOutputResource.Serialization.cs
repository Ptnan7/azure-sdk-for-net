// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.StreamAnalytics
{
    public partial class StreamingJobOutputResource : IJsonModel<StreamingJobOutputData>
    {
        private static StreamingJobOutputData s_dataDeserializationInstance;
        private static StreamingJobOutputData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<StreamingJobOutputData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StreamingJobOutputData>)Data).Write(writer, options);

        StreamingJobOutputData IJsonModel<StreamingJobOutputData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StreamingJobOutputData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<StreamingJobOutputData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<StreamingJobOutputData>(Data, options, AzureResourceManagerStreamAnalyticsContext.Default);

        StreamingJobOutputData IPersistableModel<StreamingJobOutputData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StreamingJobOutputData>(data, options, AzureResourceManagerStreamAnalyticsContext.Default);

        string IPersistableModel<StreamingJobOutputData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StreamingJobOutputData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
