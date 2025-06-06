// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class FailoverGroupResource : IJsonModel<FailoverGroupData>
    {
        private static FailoverGroupData s_dataDeserializationInstance;
        private static FailoverGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FailoverGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FailoverGroupData>)Data).Write(writer, options);

        FailoverGroupData IJsonModel<FailoverGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FailoverGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FailoverGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FailoverGroupData>(Data, options, AzureResourceManagerSqlContext.Default);

        FailoverGroupData IPersistableModel<FailoverGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FailoverGroupData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<FailoverGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FailoverGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
