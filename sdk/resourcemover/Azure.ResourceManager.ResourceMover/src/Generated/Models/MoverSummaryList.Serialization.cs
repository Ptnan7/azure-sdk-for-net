// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverSummaryList : IUtf8JsonSerializable, IJsonModel<MoverSummaryList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverSummaryList>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MoverSummaryList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverSummaryList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverSummaryList)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FieldName))
            {
                writer.WritePropertyName("fieldName"u8);
                writer.WriteStringValue(FieldName);
            }
            if (Optional.IsCollectionDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStartArray();
                foreach (var item in Summary)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        MoverSummaryList IJsonModel<MoverSummaryList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverSummaryList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverSummaryList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverSummaryList(document.RootElement, options);
        }

        internal static MoverSummaryList DeserializeMoverSummaryList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fieldName = default;
            IReadOnlyList<MoverSummaryItemInfo> summary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverSummaryItemInfo> array = new List<MoverSummaryItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverSummaryItemInfo.DeserializeMoverSummaryItemInfo(item, options));
                    }
                    summary = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MoverSummaryList(fieldName, summary ?? new ChangeTrackingList<MoverSummaryItemInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverSummaryList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverSummaryList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceMoverContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MoverSummaryList)} does not support writing '{options.Format}' format.");
            }
        }

        MoverSummaryList IPersistableModel<MoverSummaryList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverSummaryList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMoverSummaryList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverSummaryList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverSummaryList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
