// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ContinentsResponseCountryOrRegionsItem : IUtf8JsonSerializable, IJsonModel<ContinentsResponseCountryOrRegionsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinentsResponseCountryOrRegionsItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContinentsResponseCountryOrRegionsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponseCountryOrRegionsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinentsResponseCountryOrRegionsItem)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(ContinentId))
            {
                writer.WritePropertyName("continentId"u8);
                writer.WriteStringValue(ContinentId);
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

        ContinentsResponseCountryOrRegionsItem IJsonModel<ContinentsResponseCountryOrRegionsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponseCountryOrRegionsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinentsResponseCountryOrRegionsItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinentsResponseCountryOrRegionsItem(document.RootElement, options);
        }

        internal static ContinentsResponseCountryOrRegionsItem DeserializeContinentsResponseCountryOrRegionsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string continentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("continentId"u8))
                {
                    continentId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContinentsResponseCountryOrRegionsItem(id, continentId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContinentsResponseCountryOrRegionsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponseCountryOrRegionsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContinentsResponseCountryOrRegionsItem)} does not support writing '{options.Format}' format.");
            }
        }

        ContinentsResponseCountryOrRegionsItem IPersistableModel<ContinentsResponseCountryOrRegionsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponseCountryOrRegionsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContinentsResponseCountryOrRegionsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContinentsResponseCountryOrRegionsItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinentsResponseCountryOrRegionsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
