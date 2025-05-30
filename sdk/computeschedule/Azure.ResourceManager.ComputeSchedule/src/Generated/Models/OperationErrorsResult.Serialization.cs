// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    public partial class OperationErrorsResult : IUtf8JsonSerializable, IJsonModel<OperationErrorsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationErrorsResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OperationErrorsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationErrorsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationErrorsResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ActivationOn))
            {
                writer.WritePropertyName("activationTime"u8);
                writer.WriteStringValue(ActivationOn.Value, "O");
            }
            if (Optional.IsDefined(CompletedOn))
            {
                writer.WritePropertyName("completedAt"u8);
                writer.WriteStringValue(CompletedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(OperationErrors))
            {
                writer.WritePropertyName("operationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in OperationErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestErrorCode))
            {
                writer.WritePropertyName("requestErrorCode"u8);
                writer.WriteStringValue(RequestErrorCode);
            }
            if (Optional.IsDefined(RequestErrorDetails))
            {
                writer.WritePropertyName("requestErrorDetails"u8);
                writer.WriteStringValue(RequestErrorDetails);
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

        OperationErrorsResult IJsonModel<OperationErrorsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationErrorsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationErrorsResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationErrorsResult(document.RootElement, options);
        }

        internal static OperationErrorsResult DeserializeOperationErrorsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? activationTime = default;
            DateTimeOffset? completedAt = default;
            IReadOnlyList<OperationErrorDetails> operationErrors = default;
            string requestErrorCode = default;
            string requestErrorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationErrorDetails> array = new List<OperationErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationErrorDetails.DeserializeOperationErrorDetails(item, options));
                    }
                    operationErrors = array;
                    continue;
                }
                if (property.NameEquals("requestErrorCode"u8))
                {
                    requestErrorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestErrorDetails"u8))
                {
                    requestErrorDetails = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OperationErrorsResult(
                operationId,
                creationTime,
                activationTime,
                completedAt,
                operationErrors ?? new ChangeTrackingList<OperationErrorDetails>(),
                requestErrorCode,
                requestErrorDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationErrorsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationErrorsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeScheduleContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OperationErrorsResult)} does not support writing '{options.Format}' format.");
            }
        }

        OperationErrorsResult IPersistableModel<OperationErrorsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationErrorsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOperationErrorsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationErrorsResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationErrorsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
