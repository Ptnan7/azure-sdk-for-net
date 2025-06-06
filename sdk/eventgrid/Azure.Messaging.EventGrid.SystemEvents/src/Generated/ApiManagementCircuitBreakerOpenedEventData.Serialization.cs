// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementCircuitBreakerOpenedEventDataConverter))]
    public partial class ApiManagementCircuitBreakerOpenedEventData : IUtf8JsonSerializable, IJsonModel<ApiManagementCircuitBreakerOpenedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementCircuitBreakerOpenedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementCircuitBreakerOpenedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementCircuitBreakerOpenedEventData)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("backendName"u8);
            writer.WriteStringValue(BackendName);
            writer.WritePropertyName("circuitBreaker"u8);
            writer.WriteObjectValue(CircuitBreaker, options);
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

        ApiManagementCircuitBreakerOpenedEventData IJsonModel<ApiManagementCircuitBreakerOpenedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementCircuitBreakerOpenedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementCircuitBreakerOpenedEventData(document.RootElement, options);
        }

        internal static ApiManagementCircuitBreakerOpenedEventData DeserializeApiManagementCircuitBreakerOpenedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string backendName = default;
            ApiManagementCircuitBreakerProperties circuitBreaker = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendName"u8))
                {
                    backendName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("circuitBreaker"u8))
                {
                    circuitBreaker = ApiManagementCircuitBreakerProperties.DeserializeApiManagementCircuitBreakerProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiManagementCircuitBreakerOpenedEventData(backendName, circuitBreaker, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureMessagingEventGridSystemEventsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementCircuitBreakerOpenedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementCircuitBreakerOpenedEventData IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiManagementCircuitBreakerOpenedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementCircuitBreakerOpenedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementCircuitBreakerOpenedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ApiManagementCircuitBreakerOpenedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeApiManagementCircuitBreakerOpenedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }

        internal partial class ApiManagementCircuitBreakerOpenedEventDataConverter : JsonConverter<ApiManagementCircuitBreakerOpenedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementCircuitBreakerOpenedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model, ModelSerializationExtensions.WireOptions);
            }

            public override ApiManagementCircuitBreakerOpenedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementCircuitBreakerOpenedEventData(document.RootElement);
            }
        }
    }
}
