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
    public partial class RecoveryPlanInMageRcmFailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanInMageRcmFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanInMageRcmFailoverContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPlanInMageRcmFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailoverContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(UseMultiVmSyncPoint))
            {
                writer.WritePropertyName("useMultiVmSyncPoint"u8);
                writer.WriteStringValue(UseMultiVmSyncPoint);
            }
        }

        RecoveryPlanInMageRcmFailoverContent IJsonModel<RecoveryPlanInMageRcmFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailoverContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanInMageRcmFailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanInMageRcmFailoverContent DeserializeRecoveryPlanInMageRcmFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPlanPointType recoveryPointType = default;
            string useMultiVmSyncPoint = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new RecoveryPlanPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useMultiVmSyncPoint"u8))
                {
                    useMultiVmSyncPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPlanInMageRcmFailoverContent(instanceType, serializedAdditionalRawData, recoveryPointType, useMultiVmSyncPoint);
        }

        BinaryData IPersistableModel<RecoveryPlanInMageRcmFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailoverContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanInMageRcmFailoverContent IPersistableModel<RecoveryPlanInMageRcmFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanInMageRcmFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecoveryPlanInMageRcmFailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanInMageRcmFailoverContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanInMageRcmFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
