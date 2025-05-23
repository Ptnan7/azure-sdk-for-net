// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CarbonOptimization.Models
{
    [PersistableModelProxy(typeof(UnknownCarbonEmission))]
    public partial class CarbonEmission : IUtf8JsonSerializable, IJsonModel<CarbonEmission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CarbonEmission>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CarbonEmission>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CarbonEmission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CarbonEmission)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType.ToString());
            writer.WritePropertyName("latestMonthEmissions"u8);
            writer.WriteNumberValue(LatestMonthEmissions);
            writer.WritePropertyName("previousMonthEmissions"u8);
            writer.WriteNumberValue(PreviousMonthEmissions);
            if (Optional.IsDefined(MonthOverMonthEmissionsChangeRatio))
            {
                writer.WritePropertyName("monthOverMonthEmissionsChangeRatio"u8);
                writer.WriteNumberValue(MonthOverMonthEmissionsChangeRatio.Value);
            }
            if (Optional.IsDefined(MonthlyEmissionsChangeValue))
            {
                writer.WritePropertyName("monthlyEmissionsChangeValue"u8);
                writer.WriteNumberValue(MonthlyEmissionsChangeValue.Value);
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

        CarbonEmission IJsonModel<CarbonEmission>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CarbonEmission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CarbonEmission)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCarbonEmission(document.RootElement, options);
        }

        internal static CarbonEmission DeserializeCarbonEmission(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ItemDetailsData": return CarbonEmissionItemDetail.DeserializeCarbonEmissionItemDetail(element, options);
                    case "MonthlySummaryData": return CarbonEmissionMonthlySummary.DeserializeCarbonEmissionMonthlySummary(element, options);
                    case "OverallSummaryData": return CarbonEmissionOverallSummary.DeserializeCarbonEmissionOverallSummary(element, options);
                    case "ResourceGroupItemDetailsData": return ResourceGroupCarbonEmissionItemDetail.DeserializeResourceGroupCarbonEmissionItemDetail(element, options);
                    case "ResourceGroupTopItemsMonthlySummaryData": return ResourceGroupCarbonEmissionTopItemMonthlySummary.DeserializeResourceGroupCarbonEmissionTopItemMonthlySummary(element, options);
                    case "ResourceGroupTopItemsSummaryData": return ResourceGroupCarbonEmissionTopItemsSummary.DeserializeResourceGroupCarbonEmissionTopItemsSummary(element, options);
                    case "ResourceItemDetailsData": return ResourceCarbonEmissionItemDetail.DeserializeResourceCarbonEmissionItemDetail(element, options);
                    case "ResourceTopItemsMonthlySummaryData": return ResourceCarbonEmissionTopItemMonthlySummary.DeserializeResourceCarbonEmissionTopItemMonthlySummary(element, options);
                    case "ResourceTopItemsSummaryData": return ResourceCarbonEmissionTopItemsSummary.DeserializeResourceCarbonEmissionTopItemsSummary(element, options);
                    case "TopItemsMonthlySummaryData": return CarbonEmissionTopItemMonthlySummary.DeserializeCarbonEmissionTopItemMonthlySummary(element, options);
                    case "TopItemsSummaryData": return CarbonEmissionTopItemsSummary.DeserializeCarbonEmissionTopItemsSummary(element, options);
                }
            }
            return UnknownCarbonEmission.DeserializeUnknownCarbonEmission(element, options);
        }

        BinaryData IPersistableModel<CarbonEmission>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CarbonEmission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCarbonOptimizationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CarbonEmission)} does not support writing '{options.Format}' format.");
            }
        }

        CarbonEmission IPersistableModel<CarbonEmission>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CarbonEmission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCarbonEmission(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CarbonEmission)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CarbonEmission>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
