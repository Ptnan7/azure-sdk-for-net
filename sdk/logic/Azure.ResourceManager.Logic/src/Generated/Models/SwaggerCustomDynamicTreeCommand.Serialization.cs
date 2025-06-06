// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTreeCommand : IUtf8JsonSerializable, IJsonModel<SwaggerCustomDynamicTreeCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwaggerCustomDynamicTreeCommand>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SwaggerCustomDynamicTreeCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(ItemsPath))
            {
                writer.WritePropertyName("itemsPath"u8);
                writer.WriteStringValue(ItemsPath);
            }
            if (Optional.IsDefined(ItemValuePath))
            {
                writer.WritePropertyName("itemValuePath"u8);
                writer.WriteStringValue(ItemValuePath);
            }
            if (Optional.IsDefined(ItemTitlePath))
            {
                writer.WritePropertyName("itemTitlePath"u8);
                writer.WriteStringValue(ItemTitlePath);
            }
            if (Optional.IsDefined(ItemFullTitlePath))
            {
                writer.WritePropertyName("itemFullTitlePath"u8);
                writer.WriteStringValue(ItemFullTitlePath);
            }
            if (Optional.IsDefined(ItemIsParent))
            {
                writer.WritePropertyName("itemIsParent"u8);
                writer.WriteStringValue(ItemIsParent);
            }
            if (Optional.IsDefined(SelectableFilter))
            {
                writer.WritePropertyName("selectableFilter"u8);
                writer.WriteStringValue(SelectableFilter);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        SwaggerCustomDynamicTreeCommand IJsonModel<SwaggerCustomDynamicTreeCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTreeCommand(document.RootElement, options);
        }

        internal static SwaggerCustomDynamicTreeCommand DeserializeSwaggerCustomDynamicTreeCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            string itemsPath = default;
            string itemValuePath = default;
            string itemTitlePath = default;
            string itemFullTitlePath = default;
            string itemIsParent = default;
            string selectableFilter = default;
            IDictionary<string, SwaggerCustomDynamicTreeParameterInfo> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsPath"u8))
                {
                    itemsPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemValuePath"u8))
                {
                    itemValuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemTitlePath"u8))
                {
                    itemTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemFullTitlePath"u8))
                {
                    itemFullTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIsParent"u8))
                {
                    itemIsParent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectableFilter"u8))
                {
                    selectableFilter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerCustomDynamicTreeParameterInfo> dictionary = new Dictionary<string, SwaggerCustomDynamicTreeParameterInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerCustomDynamicTreeParameterInfo.DeserializeSwaggerCustomDynamicTreeParameterInfo(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SwaggerCustomDynamicTreeCommand(
                operationId,
                itemsPath,
                itemValuePath,
                itemTitlePath,
                itemFullTitlePath,
                itemIsParent,
                selectableFilter,
                parameters ?? new ChangeTrackingDictionary<string, SwaggerCustomDynamicTreeParameterInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SwaggerCustomDynamicTreeCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support writing '{options.Format}' format.");
            }
        }

        SwaggerCustomDynamicTreeCommand IPersistableModel<SwaggerCustomDynamicTreeCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTreeCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSwaggerCustomDynamicTreeCommand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTreeCommand)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwaggerCustomDynamicTreeCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
