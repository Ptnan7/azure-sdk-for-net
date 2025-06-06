// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class IstioPluginCertificateAuthority : IUtf8JsonSerializable, IJsonModel<IstioPluginCertificateAuthority>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IstioPluginCertificateAuthority>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IstioPluginCertificateAuthority>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(CertObjectName))
            {
                writer.WritePropertyName("certObjectName"u8);
                writer.WriteStringValue(CertObjectName);
            }
            if (Optional.IsDefined(KeyObjectName))
            {
                writer.WritePropertyName("keyObjectName"u8);
                writer.WriteStringValue(KeyObjectName);
            }
            if (Optional.IsDefined(RootCertObjectName))
            {
                writer.WritePropertyName("rootCertObjectName"u8);
                writer.WriteStringValue(RootCertObjectName);
            }
            if (Optional.IsDefined(CertChainObjectName))
            {
                writer.WritePropertyName("certChainObjectName"u8);
                writer.WriteStringValue(CertChainObjectName);
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

        IstioPluginCertificateAuthority IJsonModel<IstioPluginCertificateAuthority>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIstioPluginCertificateAuthority(document.RootElement, options);
        }

        internal static IstioPluginCertificateAuthority DeserializeIstioPluginCertificateAuthority(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier keyVaultId = default;
            string certObjectName = default;
            string keyObjectName = default;
            string rootCertObjectName = default;
            string certChainObjectName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certObjectName"u8))
                {
                    certObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyObjectName"u8))
                {
                    keyObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootCertObjectName"u8))
                {
                    rootCertObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certChainObjectName"u8))
                {
                    certChainObjectName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IstioPluginCertificateAuthority(
                keyVaultId,
                certObjectName,
                keyObjectName,
                rootCertObjectName,
                certChainObjectName,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyVaultId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultId))
                {
                    builder.Append("  keyVaultId: ");
                    builder.AppendLine($"'{KeyVaultId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertObjectName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certObjectName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertObjectName))
                {
                    builder.Append("  certObjectName: ");
                    if (CertObjectName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertObjectName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertObjectName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyObjectName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyObjectName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyObjectName))
                {
                    builder.Append("  keyObjectName: ");
                    if (KeyObjectName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KeyObjectName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KeyObjectName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RootCertObjectName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rootCertObjectName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RootCertObjectName))
                {
                    builder.Append("  rootCertObjectName: ");
                    if (RootCertObjectName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RootCertObjectName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RootCertObjectName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertChainObjectName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certChainObjectName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertChainObjectName))
                {
                    builder.Append("  certChainObjectName: ");
                    if (CertChainObjectName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertChainObjectName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertChainObjectName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<IstioPluginCertificateAuthority>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support writing '{options.Format}' format.");
            }
        }

        IstioPluginCertificateAuthority IPersistableModel<IstioPluginCertificateAuthority>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioPluginCertificateAuthority>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIstioPluginCertificateAuthority(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IstioPluginCertificateAuthority)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IstioPluginCertificateAuthority>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
