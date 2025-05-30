// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MongoDBAtlas.Models
{
    public partial class MongoDBAtlasPartnerProperties : IUtf8JsonSerializable, IJsonModel<MongoDBAtlasPartnerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBAtlasPartnerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoDBAtlasPartnerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasPartnerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBAtlasPartnerProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OrganizationId))
            {
                writer.WritePropertyName("organizationId"u8);
                writer.WriteStringValue(OrganizationId);
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUrl"u8);
                writer.WriteStringValue(RedirectUri);
            }
            writer.WritePropertyName("organizationName"u8);
            writer.WriteStringValue(OrganizationName);
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

        MongoDBAtlasPartnerProperties IJsonModel<MongoDBAtlasPartnerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasPartnerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBAtlasPartnerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBAtlasPartnerProperties(document.RootElement, options);
        }

        internal static MongoDBAtlasPartnerProperties DeserializeMongoDBAtlasPartnerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string organizationId = default;
            string redirectUrl = default;
            string organizationName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationId"u8))
                {
                    organizationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectUrl"u8))
                {
                    redirectUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationName"u8))
                {
                    organizationName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoDBAtlasPartnerProperties(organizationId, redirectUrl, organizationName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBAtlasPartnerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasPartnerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMongoDBAtlasContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MongoDBAtlasPartnerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MongoDBAtlasPartnerProperties IPersistableModel<MongoDBAtlasPartnerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasPartnerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMongoDBAtlasPartnerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBAtlasPartnerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBAtlasPartnerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
