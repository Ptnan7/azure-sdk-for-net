// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleMetadata : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCollectionRuleMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DataCollectionRuleMetadata IJsonModel<DataCollectionRuleMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleMetadata(document.RootElement, options);
        }

        internal static DataCollectionRuleMetadata DeserializeDataCollectionRuleMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisionedBy = default;
            string provisionedByResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionedBy"u8))
                {
                    provisionedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisionedByResourceId"u8))
                {
                    provisionedByResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataCollectionRuleMetadata(provisionedBy, provisionedByResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRuleMetadata IPersistableModel<DataCollectionRuleMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCollectionRuleMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
