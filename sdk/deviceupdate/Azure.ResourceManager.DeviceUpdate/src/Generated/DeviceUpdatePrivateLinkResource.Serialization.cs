// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DeviceUpdate
{
    public partial class DeviceUpdatePrivateLinkResource : IJsonModel<DeviceUpdatePrivateLinkData>
    {
        private static DeviceUpdatePrivateLinkData s_dataDeserializationInstance;
        private static DeviceUpdatePrivateLinkData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DeviceUpdatePrivateLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeviceUpdatePrivateLinkData>)Data).Write(writer, options);

        DeviceUpdatePrivateLinkData IJsonModel<DeviceUpdatePrivateLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeviceUpdatePrivateLinkData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DeviceUpdatePrivateLinkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DeviceUpdatePrivateLinkData>(Data, options, AzureResourceManagerDeviceUpdateContext.Default);

        DeviceUpdatePrivateLinkData IPersistableModel<DeviceUpdatePrivateLinkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeviceUpdatePrivateLinkData>(data, options, AzureResourceManagerDeviceUpdateContext.Default);

        string IPersistableModel<DeviceUpdatePrivateLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeviceUpdatePrivateLinkData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
