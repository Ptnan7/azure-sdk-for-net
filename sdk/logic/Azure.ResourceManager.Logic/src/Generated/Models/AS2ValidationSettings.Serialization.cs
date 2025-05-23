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
    public partial class AS2ValidationSettings : IUtf8JsonSerializable, IJsonModel<AS2ValidationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2ValidationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AS2ValidationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2ValidationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2ValidationSettings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("overrideMessageProperties"u8);
            writer.WriteBooleanValue(OverrideMessageProperties);
            writer.WritePropertyName("encryptMessage"u8);
            writer.WriteBooleanValue(EncryptMessage);
            writer.WritePropertyName("signMessage"u8);
            writer.WriteBooleanValue(SignMessage);
            writer.WritePropertyName("compressMessage"u8);
            writer.WriteBooleanValue(CompressMessage);
            writer.WritePropertyName("checkDuplicateMessage"u8);
            writer.WriteBooleanValue(CheckDuplicateMessage);
            writer.WritePropertyName("interchangeDuplicatesValidityDays"u8);
            writer.WriteNumberValue(InterchangeDuplicatesValidityDays);
            writer.WritePropertyName("checkCertificateRevocationListOnSend"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnSend);
            writer.WritePropertyName("checkCertificateRevocationListOnReceive"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnReceive);
            writer.WritePropertyName("encryptionAlgorithm"u8);
            writer.WriteStringValue(EncryptionAlgorithm.ToString());
            if (Optional.IsDefined(SigningAlgorithm))
            {
                writer.WritePropertyName("signingAlgorithm"u8);
                writer.WriteStringValue(SigningAlgorithm.Value.ToString());
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

        AS2ValidationSettings IJsonModel<AS2ValidationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2ValidationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2ValidationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2ValidationSettings(document.RootElement, options);
        }

        internal static AS2ValidationSettings DeserializeAS2ValidationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool overrideMessageProperties = default;
            bool encryptMessage = default;
            bool signMessage = default;
            bool compressMessage = default;
            bool checkDuplicateMessage = default;
            int interchangeDuplicatesValidityDays = default;
            bool checkCertificateRevocationListOnSend = default;
            bool checkCertificateRevocationListOnReceive = default;
            AS2EncryptionAlgorithm encryptionAlgorithm = default;
            AS2SigningAlgorithm? signingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overrideMessageProperties"u8))
                {
                    overrideMessageProperties = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptMessage"u8))
                {
                    encryptMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signMessage"u8))
                {
                    signMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("compressMessage"u8))
                {
                    compressMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkDuplicateMessage"u8))
                {
                    checkDuplicateMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeDuplicatesValidityDays"u8))
                {
                    interchangeDuplicatesValidityDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnSend"u8))
                {
                    checkCertificateRevocationListOnSend = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnReceive"u8))
                {
                    checkCertificateRevocationListOnReceive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = new AS2EncryptionAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signingAlgorithm = new AS2SigningAlgorithm(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AS2ValidationSettings(
                overrideMessageProperties,
                encryptMessage,
                signMessage,
                compressMessage,
                checkDuplicateMessage,
                interchangeDuplicatesValidityDays,
                checkCertificateRevocationListOnSend,
                checkCertificateRevocationListOnReceive,
                encryptionAlgorithm,
                signingAlgorithm,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2ValidationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2ValidationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AS2ValidationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AS2ValidationSettings IPersistableModel<AS2ValidationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2ValidationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAS2ValidationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2ValidationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2ValidationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
