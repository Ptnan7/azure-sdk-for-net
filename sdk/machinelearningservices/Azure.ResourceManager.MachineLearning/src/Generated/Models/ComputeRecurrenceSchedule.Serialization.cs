// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ComputeRecurrenceSchedule : IUtf8JsonSerializable, IJsonModel<ComputeRecurrenceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeRecurrenceSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeRecurrenceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeRecurrenceSchedule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hours"u8);
            writer.WriteStartArray();
            foreach (var item in Hours)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("minutes"u8);
            writer.WriteStartArray();
            foreach (var item in Minutes)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(MonthDays))
            {
                if (MonthDays != null)
                {
                    writer.WritePropertyName("monthDays"u8);
                    writer.WriteStartArray();
                    foreach (var item in MonthDays)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("monthDays");
                }
            }
            if (Optional.IsCollectionDefined(WeekDays))
            {
                if (WeekDays != null)
                {
                    writer.WritePropertyName("weekDays"u8);
                    writer.WriteStartArray();
                    foreach (var item in WeekDays)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("weekDays");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ComputeRecurrenceSchedule IJsonModel<ComputeRecurrenceSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeRecurrenceSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeRecurrenceSchedule(document.RootElement, options);
        }

        internal static ComputeRecurrenceSchedule DeserializeComputeRecurrenceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> hours = default;
            IList<int> minutes = default;
            IList<int> monthDays = default;
            IList<ComputeWeekDay> weekDays = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hours"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hours = array;
                    continue;
                }
                if (property.NameEquals("minutes"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    minutes = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        monthDays = null;
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    monthDays = array;
                    continue;
                }
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weekDays = null;
                        continue;
                    }
                    List<ComputeWeekDay> array = new List<ComputeWeekDay>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ComputeWeekDay(item.GetString()));
                    }
                    weekDays = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeRecurrenceSchedule(hours, minutes, monthDays ?? new ChangeTrackingList<int>(), weekDays ?? new ChangeTrackingList<ComputeWeekDay>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeRecurrenceSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeRecurrenceSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeRecurrenceSchedule IPersistableModel<ComputeRecurrenceSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeRecurrenceSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeRecurrenceSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeRecurrenceSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
