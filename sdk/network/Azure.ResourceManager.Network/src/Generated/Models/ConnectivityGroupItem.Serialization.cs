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
    public partial class ConnectivityGroupItem : IUtf8JsonSerializable, IJsonModel<ConnectivityGroupItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityGroupItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectivityGroupItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityGroupItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityGroupItem)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("networkGroupId"u8);
            writer.WriteStringValue(NetworkGroupId);
            if (Optional.IsDefined(UseHubGateway))
            {
                writer.WritePropertyName("useHubGateway"u8);
                writer.WriteStringValue(UseHubGateway.Value.ToString());
            }
            if (Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteStringValue(IsGlobal.Value.ToString());
            }
            writer.WritePropertyName("groupConnectivity"u8);
            writer.WriteStringValue(GroupConnectivity.ToString());
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

        ConnectivityGroupItem IJsonModel<ConnectivityGroupItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityGroupItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityGroupItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityGroupItem(document.RootElement, options);
        }

        internal static ConnectivityGroupItem DeserializeConnectivityGroupItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkGroupId = default;
            HubGatewayUsageFlag? useHubGateway = default;
            GlobalMeshSupportFlag? isGlobal = default;
            GroupConnectivity groupConnectivity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkGroupId"u8))
                {
                    networkGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useHubGateway"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useHubGateway = new HubGatewayUsageFlag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isGlobal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isGlobal = new GlobalMeshSupportFlag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groupConnectivity"u8))
                {
                    groupConnectivity = new GroupConnectivity(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectivityGroupItem(networkGroupId, useHubGateway, isGlobal, groupConnectivity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityGroupItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityGroupItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityGroupItem)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectivityGroupItem IPersistableModel<ConnectivityGroupItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityGroupItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectivityGroupItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityGroupItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityGroupItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
