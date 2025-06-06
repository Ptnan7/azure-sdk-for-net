// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceSsoDetailsContent : IUtf8JsonSerializable, IJsonModel<DynatraceSsoDetailsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceSsoDetailsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DynatraceSsoDetailsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSsoDetailsContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UserPrincipal))
            {
                writer.WritePropertyName("userPrincipal"u8);
                writer.WriteStringValue(UserPrincipal);
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

        DynatraceSsoDetailsContent IJsonModel<DynatraceSsoDetailsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSsoDetailsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceSsoDetailsContent(document.RootElement, options);
        }

        internal static DynatraceSsoDetailsContent DeserializeDynatraceSsoDetailsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userPrincipal = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userPrincipal"u8))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DynatraceSsoDetailsContent(userPrincipal, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceSsoDetailsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDynatraceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DynatraceSsoDetailsContent)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceSsoDetailsContent IPersistableModel<DynatraceSsoDetailsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDynatraceSsoDetailsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceSsoDetailsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceSsoDetailsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
