// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerProperties : IUtf8JsonSerializable, IJsonModel<ConfidentialLedgerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfidentialLedgerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfidentialLedgerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LedgerName))
            {
                writer.WritePropertyName("ledgerName"u8);
                writer.WriteStringValue(LedgerName);
            }
            if (options.Format != "W" && Optional.IsDefined(LedgerUri))
            {
                writer.WritePropertyName("ledgerUri"u8);
                writer.WriteStringValue(LedgerUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(IdentityServiceUri))
            {
                writer.WritePropertyName("identityServiceUri"u8);
                writer.WriteStringValue(IdentityServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(LedgerInternalNamespace))
            {
                writer.WritePropertyName("ledgerInternalNamespace"u8);
                writer.WriteStringValue(LedgerInternalNamespace);
            }
            if (Optional.IsDefined(RunningState))
            {
                writer.WritePropertyName("runningState"u8);
                writer.WriteStringValue(RunningState.Value.ToString());
            }
            if (Optional.IsDefined(LedgerType))
            {
                writer.WritePropertyName("ledgerType"u8);
                writer.WriteStringValue(LedgerType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(LedgerSku))
            {
                writer.WritePropertyName("ledgerSku"u8);
                writer.WriteStringValue(LedgerSku.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AadBasedSecurityPrincipals))
            {
                writer.WritePropertyName("aadBasedSecurityPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in AadBasedSecurityPrincipals)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CertBasedSecurityPrincipals))
            {
                writer.WritePropertyName("certBasedSecurityPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in CertBasedSecurityPrincipals)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HostLevel))
            {
                writer.WritePropertyName("hostLevel"u8);
                writer.WriteStringValue(HostLevel);
            }
            if (Optional.IsDefined(MaxBodySizeInMb))
            {
                writer.WritePropertyName("maxBodySizeInMb"u8);
                writer.WriteNumberValue(MaxBodySizeInMb.Value);
            }
            if (Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(WriteLBAddressPrefix))
            {
                writer.WritePropertyName("writeLBAddressPrefix"u8);
                writer.WriteStringValue(WriteLBAddressPrefix);
            }
            if (Optional.IsDefined(WorkerThreads))
            {
                writer.WritePropertyName("workerThreads"u8);
                writer.WriteNumberValue(WorkerThreads.Value);
            }
            if (Optional.IsDefined(EnclavePlatform))
            {
                writer.WritePropertyName("enclavePlatform"u8);
                writer.WriteStringValue(EnclavePlatform.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
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

        ConfidentialLedgerProperties IJsonModel<ConfidentialLedgerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfidentialLedgerProperties(document.RootElement, options);
        }

        internal static ConfidentialLedgerProperties DeserializeConfidentialLedgerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ledgerName = default;
            Uri ledgerUri = default;
            Uri identityServiceUri = default;
            string ledgerInternalNamespace = default;
            ConfidentialLedgerRunningState? runningState = default;
            ConfidentialLedgerType? ledgerType = default;
            ConfidentialLedgerProvisioningState? provisioningState = default;
            ConfidentialLedgerSku? ledgerSku = default;
            IList<AadBasedSecurityPrincipal> aadBasedSecurityPrincipals = default;
            IList<CertBasedSecurityPrincipal> certBasedSecurityPrincipals = default;
            string hostLevel = default;
            int? maxBodySizeInMb = default;
            string subjectName = default;
            int? nodeCount = default;
            string writeLBAddressPrefix = default;
            int? workerThreads = default;
            ConfidentialLedgerEnclavePlatform? enclavePlatform = default;
            ConfidentialLedgerApplicationType? applicationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ledgerName"u8))
                {
                    ledgerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerInternalNamespace"u8))
                {
                    ledgerInternalNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningState = new ConfidentialLedgerRunningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerType = new ConfidentialLedgerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ConfidentialLedgerProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerSku = new ConfidentialLedgerSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadBasedSecurityPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AadBasedSecurityPrincipal> array = new List<AadBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AadBasedSecurityPrincipal.DeserializeAadBasedSecurityPrincipal(item, options));
                    }
                    aadBasedSecurityPrincipals = array;
                    continue;
                }
                if (property.NameEquals("certBasedSecurityPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CertBasedSecurityPrincipal> array = new List<CertBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertBasedSecurityPrincipal.DeserializeCertBasedSecurityPrincipal(item, options));
                    }
                    certBasedSecurityPrincipals = array;
                    continue;
                }
                if (property.NameEquals("hostLevel"u8))
                {
                    hostLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBodySizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBodySizeInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("writeLBAddressPrefix"u8))
                {
                    writeLBAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerThreads"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workerThreads = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enclavePlatform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enclavePlatform = new ConfidentialLedgerEnclavePlatform(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationType = new ConfidentialLedgerApplicationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfidentialLedgerProperties(
                ledgerName,
                ledgerUri,
                identityServiceUri,
                ledgerInternalNamespace,
                runningState,
                ledgerType,
                provisioningState,
                ledgerSku,
                aadBasedSecurityPrincipals ?? new ChangeTrackingList<AadBasedSecurityPrincipal>(),
                certBasedSecurityPrincipals ?? new ChangeTrackingList<CertBasedSecurityPrincipal>(),
                hostLevel,
                maxBodySizeInMb,
                subjectName,
                nodeCount,
                writeLBAddressPrefix,
                workerThreads,
                enclavePlatform,
                applicationType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfidentialLedgerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConfidentialLedgerContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConfidentialLedgerProperties IPersistableModel<ConfidentialLedgerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfidentialLedgerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfidentialLedgerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
