// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubTestRouteContent : IUtf8JsonSerializable, IJsonModel<IotHubTestRouteContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubTestRouteContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubTestRouteContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestRouteContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteObjectValue(Message, options);
            }
            writer.WritePropertyName("route"u8);
            writer.WriteObjectValue(Route, options);
            if (Optional.IsDefined(Twin))
            {
                writer.WritePropertyName("twin"u8);
                writer.WriteObjectValue(Twin, options);
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

        IotHubTestRouteContent IJsonModel<IotHubTestRouteContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestRouteContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestRouteContent(document.RootElement, options);
        }

        internal static IotHubTestRouteContent DeserializeIotHubTestRouteContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RoutingMessage message = default;
            RoutingRuleProperties route = default;
            RoutingTwin twin = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = RoutingMessage.DeserializeRoutingMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("route"u8))
                {
                    route = RoutingRuleProperties.DeserializeRoutingRuleProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = RoutingTwin.DeserializeRoutingTwin(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubTestRouteContent(message, route, twin, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubTestRouteContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotHubContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotHubTestRouteContent)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubTestRouteContent IPersistableModel<IotHubTestRouteContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotHubTestRouteContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubTestRouteContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubTestRouteContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
