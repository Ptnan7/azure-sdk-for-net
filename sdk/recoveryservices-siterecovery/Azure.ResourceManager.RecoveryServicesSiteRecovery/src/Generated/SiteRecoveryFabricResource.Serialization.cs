// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    public partial class SiteRecoveryFabricResource : IJsonModel<SiteRecoveryFabricData>
    {
        private static SiteRecoveryFabricData s_dataDeserializationInstance;
        private static SiteRecoveryFabricData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SiteRecoveryFabricData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SiteRecoveryFabricData>)Data).Write(writer, options);

        SiteRecoveryFabricData IJsonModel<SiteRecoveryFabricData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SiteRecoveryFabricData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SiteRecoveryFabricData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SiteRecoveryFabricData>(Data, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);

        SiteRecoveryFabricData IPersistableModel<SiteRecoveryFabricData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SiteRecoveryFabricData>(data, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);

        string IPersistableModel<SiteRecoveryFabricData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SiteRecoveryFabricData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
