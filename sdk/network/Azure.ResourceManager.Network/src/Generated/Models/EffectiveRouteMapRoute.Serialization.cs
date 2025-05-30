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
    public partial class EffectiveRouteMapRoute : IUtf8JsonSerializable, IJsonModel<EffectiveRouteMapRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EffectiveRouteMapRoute>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EffectiveRouteMapRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveRouteMapRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveRouteMapRoute)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (Optional.IsDefined(BgpCommunities))
            {
                writer.WritePropertyName("bgpCommunities"u8);
                writer.WriteStringValue(BgpCommunities);
            }
            if (Optional.IsDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
            }
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

        EffectiveRouteMapRoute IJsonModel<EffectiveRouteMapRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveRouteMapRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveRouteMapRoute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveRouteMapRoute(document.RootElement, options);
        }

        internal static EffectiveRouteMapRoute DeserializeEffectiveRouteMapRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prefix = default;
            string bgpCommunities = default;
            string asPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bgpCommunities"u8))
                {
                    bgpCommunities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EffectiveRouteMapRoute(prefix, bgpCommunities, asPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EffectiveRouteMapRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveRouteMapRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EffectiveRouteMapRoute)} does not support writing '{options.Format}' format.");
            }
        }

        EffectiveRouteMapRoute IPersistableModel<EffectiveRouteMapRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveRouteMapRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEffectiveRouteMapRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EffectiveRouteMapRoute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EffectiveRouteMapRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
