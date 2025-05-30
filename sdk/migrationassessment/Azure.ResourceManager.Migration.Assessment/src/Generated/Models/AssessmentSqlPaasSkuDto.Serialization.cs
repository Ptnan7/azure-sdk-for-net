// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    public partial class AssessmentSqlPaasSkuDto : IUtf8JsonSerializable, IJsonModel<AssessmentSqlPaasSkuDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssessmentSqlPaasSkuDto>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssessmentSqlPaasSkuDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentSqlPaasSkuDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessmentSqlPaasSkuDto)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AzureSqlServiceTier))
            {
                writer.WritePropertyName("azureSqlServiceTier"u8);
                writer.WriteStringValue(AzureSqlServiceTier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AzureSqlComputeTier))
            {
                writer.WritePropertyName("azureSqlComputeTier"u8);
                writer.WriteStringValue(AzureSqlComputeTier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AzureSqlHardwareGeneration))
            {
                writer.WritePropertyName("azureSqlHardwareGeneration"u8);
                writer.WriteStringValue(AzureSqlHardwareGeneration.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StorageMaxSizeInMB))
            {
                writer.WritePropertyName("storageMaxSizeInMB"u8);
                writer.WriteNumberValue(StorageMaxSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PredictedDataSizeInMB))
            {
                writer.WritePropertyName("predictedDataSizeInMB"u8);
                writer.WriteNumberValue(PredictedDataSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PredictedLogSizeInMB))
            {
                writer.WritePropertyName("predictedLogSizeInMB"u8);
                writer.WriteNumberValue(PredictedLogSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Cores))
            {
                writer.WritePropertyName("cores"u8);
                writer.WriteNumberValue(Cores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureSqlTargetType))
            {
                writer.WritePropertyName("azureSqlTargetType"u8);
                writer.WriteStringValue(AzureSqlTargetType.Value.ToString());
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

        AssessmentSqlPaasSkuDto IJsonModel<AssessmentSqlPaasSkuDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentSqlPaasSkuDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessmentSqlPaasSkuDto)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssessmentSqlPaasSkuDto(document.RootElement, options);
        }

        internal static AssessmentSqlPaasSkuDto DeserializeAssessmentSqlPaasSkuDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssessmentSqlServiceTier? azureSqlServiceTier = default;
            MigrationAssessmentComputeTier? azureSqlComputeTier = default;
            MigrationAssessmentHardwareGeneration? azureSqlHardwareGeneration = default;
            double? storageMaxSizeInMB = default;
            double? predictedDataSizeInMB = default;
            double? predictedLogSizeInMB = default;
            int? cores = default;
            MigrationAssessmentTargetType? azureSqlTargetType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSqlServiceTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureSqlServiceTier = new AssessmentSqlServiceTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureSqlComputeTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureSqlComputeTier = new MigrationAssessmentComputeTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureSqlHardwareGeneration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureSqlHardwareGeneration = new MigrationAssessmentHardwareGeneration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageMaxSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageMaxSizeInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("predictedDataSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    predictedDataSizeInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("predictedLogSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    predictedLogSizeInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("azureSqlTargetType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureSqlTargetType = new MigrationAssessmentTargetType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssessmentSqlPaasSkuDto(
                azureSqlServiceTier,
                azureSqlComputeTier,
                azureSqlHardwareGeneration,
                storageMaxSizeInMB,
                predictedDataSizeInMB,
                predictedLogSizeInMB,
                cores,
                azureSqlTargetType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssessmentSqlPaasSkuDto>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentSqlPaasSkuDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMigrationAssessmentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AssessmentSqlPaasSkuDto)} does not support writing '{options.Format}' format.");
            }
        }

        AssessmentSqlPaasSkuDto IPersistableModel<AssessmentSqlPaasSkuDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentSqlPaasSkuDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAssessmentSqlPaasSkuDto(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssessmentSqlPaasSkuDto)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssessmentSqlPaasSkuDto>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
