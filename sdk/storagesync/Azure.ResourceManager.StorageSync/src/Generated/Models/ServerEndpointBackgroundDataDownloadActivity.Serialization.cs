// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointBackgroundDataDownloadActivity : IUtf8JsonSerializable, IJsonModel<ServerEndpointBackgroundDataDownloadActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEndpointBackgroundDataDownloadActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerEndpointBackgroundDataDownloadActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointBackgroundDataDownloadActivity)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedTimestamp"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PercentProgress))
            {
                writer.WritePropertyName("percentProgress"u8);
                writer.WriteNumberValue(PercentProgress.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DownloadedBytes))
            {
                writer.WritePropertyName("downloadedBytes"u8);
                writer.WriteNumberValue(DownloadedBytes.Value);
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

        ServerEndpointBackgroundDataDownloadActivity IJsonModel<ServerEndpointBackgroundDataDownloadActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointBackgroundDataDownloadActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointBackgroundDataDownloadActivity(document.RootElement, options);
        }

        internal static ServerEndpointBackgroundDataDownloadActivity DeserializeServerEndpointBackgroundDataDownloadActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            DateTimeOffset? startedTimestamp = default;
            int? percentProgress = default;
            long? downloadedBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("downloadedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadedBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerEndpointBackgroundDataDownloadActivity(timestamp, startedTimestamp, percentProgress, downloadedBytes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageSyncContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointBackgroundDataDownloadActivity)} does not support writing '{options.Format}' format.");
            }
        }

        ServerEndpointBackgroundDataDownloadActivity IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeServerEndpointBackgroundDataDownloadActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointBackgroundDataDownloadActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointBackgroundDataDownloadActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
