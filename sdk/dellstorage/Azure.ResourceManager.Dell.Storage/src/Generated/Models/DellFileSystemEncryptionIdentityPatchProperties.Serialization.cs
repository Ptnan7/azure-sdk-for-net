// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dell.Storage.Models
{
    public partial class DellFileSystemEncryptionIdentityPatchProperties : IUtf8JsonSerializable, IJsonModel<DellFileSystemEncryptionIdentityPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DellFileSystemEncryptionIdentityPatchProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DellFileSystemEncryptionIdentityPatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DellFileSystemEncryptionIdentityPatchProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("identityType"u8);
                writer.WriteStringValue(IdentityType.Value.ToString());
            }
            if (Optional.IsDefined(IdentityResourceId))
            {
                writer.WritePropertyName("identityResourceId"u8);
                writer.WriteStringValue(IdentityResourceId);
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

        DellFileSystemEncryptionIdentityPatchProperties IJsonModel<DellFileSystemEncryptionIdentityPatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DellFileSystemEncryptionIdentityPatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDellFileSystemEncryptionIdentityPatchProperties(document.RootElement, options);
        }

        internal static DellFileSystemEncryptionIdentityPatchProperties DeserializeDellFileSystemEncryptionIdentityPatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DellFileSystemEncryptionIdentityType? identityType = default;
            ResourceIdentifier identityResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityType = new DellFileSystemEncryptionIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DellFileSystemEncryptionIdentityPatchProperties(identityType, identityResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDellStorageContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DellFileSystemEncryptionIdentityPatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DellFileSystemEncryptionIdentityPatchProperties IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDellFileSystemEncryptionIdentityPatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DellFileSystemEncryptionIdentityPatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DellFileSystemEncryptionIdentityPatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
