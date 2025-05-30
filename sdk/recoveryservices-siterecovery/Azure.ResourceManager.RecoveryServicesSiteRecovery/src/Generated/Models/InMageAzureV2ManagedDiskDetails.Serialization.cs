// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2ManagedDiskDetails : IUtf8JsonSerializable, IJsonModel<InMageAzureV2ManagedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageAzureV2ManagedDiskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageAzureV2ManagedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2ManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2ManagedDiskDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(SeedManagedDiskId))
            {
                writer.WritePropertyName("seedManagedDiskId"u8);
                writer.WriteStringValue(SeedManagedDiskId);
            }
            if (Optional.IsDefined(ReplicaDiskType))
            {
                writer.WritePropertyName("replicaDiskType"u8);
                writer.WriteStringValue(ReplicaDiskType);
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsDefined(TargetDiskName))
            {
                writer.WritePropertyName("targetDiskName"u8);
                writer.WriteStringValue(TargetDiskName);
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

        InMageAzureV2ManagedDiskDetails IJsonModel<InMageAzureV2ManagedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2ManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2ManagedDiskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2ManagedDiskDetails(document.RootElement, options);
        }

        internal static InMageAzureV2ManagedDiskDetails DeserializeInMageAzureV2ManagedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string seedManagedDiskId = default;
            string replicaDiskType = default;
            ResourceIdentifier diskEncryptionSetId = default;
            string targetDiskName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaDiskType"u8))
                {
                    replicaDiskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageAzureV2ManagedDiskDetails(
                diskId,
                seedManagedDiskId,
                replicaDiskType,
                diskEncryptionSetId,
                targetDiskName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageAzureV2ManagedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2ManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2ManagedDiskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageAzureV2ManagedDiskDetails IPersistableModel<InMageAzureV2ManagedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2ManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInMageAzureV2ManagedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2ManagedDiskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageAzureV2ManagedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
