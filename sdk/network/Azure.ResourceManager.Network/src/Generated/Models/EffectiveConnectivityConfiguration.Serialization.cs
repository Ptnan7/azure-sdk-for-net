// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveConnectivityConfiguration : IUtf8JsonSerializable, IJsonModel<EffectiveConnectivityConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EffectiveConnectivityConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EffectiveConnectivityConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveConnectivityConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(ConfigurationGroups))
            {
                writer.WritePropertyName("configurationGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ConnectivityTopology))
            {
                writer.WritePropertyName("connectivityTopology"u8);
                writer.WriteStringValue(ConnectivityTopology.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Hubs))
            {
                writer.WritePropertyName("hubs"u8);
                writer.WriteStartArray();
                foreach (var item in Hubs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteStringValue(IsGlobal.Value.ToString());
            }
            if (Optional.IsDefined(ConnectivityCapabilities))
            {
                writer.WritePropertyName("connectivityCapabilities"u8);
                writer.WriteObjectValue(ConnectivityCapabilities, options);
            }
            if (Optional.IsCollectionDefined(AppliesToGroups))
            {
                writer.WritePropertyName("appliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AppliesToGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(DeleteExistingPeering))
            {
                writer.WritePropertyName("deleteExistingPeering"u8);
                writer.WriteStringValue(DeleteExistingPeering.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        EffectiveConnectivityConfiguration IJsonModel<EffectiveConnectivityConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveConnectivityConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveConnectivityConfiguration(document.RootElement, options);
        }

        internal static EffectiveConnectivityConfiguration DeserializeEffectiveConnectivityConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<NetworkConfigurationGroup> configurationGroups = default;
            string description = default;
            ConnectivityTopology? connectivityTopology = default;
            IReadOnlyList<ConnectivityHub> hubs = default;
            GlobalMeshSupportFlag? isGlobal = default;
            ConnectivityConfigurationPropertiesConnectivityCapabilities connectivityCapabilities = default;
            IReadOnlyList<ConnectivityGroupItem> appliesToGroups = default;
            NetworkProvisioningState? provisioningState = default;
            DeleteExistingPeering? deleteExistingPeering = default;
            Guid? resourceGuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item, options));
                    }
                    configurationGroups = array;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectivityTopology"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityTopology = new ConnectivityTopology(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityHub> array = new List<ConnectivityHub>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityHub.DeserializeConnectivityHub(item, options));
                            }
                            hubs = array;
                            continue;
                        }
                        if (property0.NameEquals("isGlobal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGlobal = new GlobalMeshSupportFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectivityCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityCapabilities = ConnectivityConfigurationPropertiesConnectivityCapabilities.DeserializeConnectivityConfigurationPropertiesConnectivityCapabilities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("appliesToGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityGroupItem> array = new List<ConnectivityGroupItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityGroupItem.DeserializeConnectivityGroupItem(item, options));
                            }
                            appliesToGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deleteExistingPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteExistingPeering = new DeleteExistingPeering(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EffectiveConnectivityConfiguration(
                id,
                configurationGroups ?? new ChangeTrackingList<NetworkConfigurationGroup>(),
                description,
                connectivityTopology,
                hubs ?? new ChangeTrackingList<ConnectivityHub>(),
                isGlobal,
                connectivityCapabilities,
                appliesToGroups ?? new ChangeTrackingList<ConnectivityGroupItem>(),
                provisioningState,
                deleteExistingPeering,
                resourceGuid,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EffectiveConnectivityConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EffectiveConnectivityConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        EffectiveConnectivityConfiguration IPersistableModel<EffectiveConnectivityConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEffectiveConnectivityConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EffectiveConnectivityConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EffectiveConnectivityConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
