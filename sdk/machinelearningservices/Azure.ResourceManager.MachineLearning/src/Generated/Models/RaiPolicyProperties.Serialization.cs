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
    public partial class RaiPolicyProperties : IUtf8JsonSerializable, IJsonModel<RaiPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RaiPolicyProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RaiPolicyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiPolicyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BasePolicyName))
            {
                writer.WritePropertyName("basePolicyName"u8);
                writer.WriteStringValue(BasePolicyName);
            }
            if (Optional.IsCollectionDefined(CompletionBlocklists))
            {
                writer.WritePropertyName("completionBlocklists"u8);
                writer.WriteStartArray();
                foreach (var item in CompletionBlocklists)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContentFilters))
            {
                writer.WritePropertyName("contentFilters"u8);
                writer.WriteStartArray();
                foreach (var item in ContentFilters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PromptBlocklists))
            {
                writer.WritePropertyName("promptBlocklists"u8);
                writer.WriteStartArray();
                foreach (var item in PromptBlocklists)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PolicyType.Value.ToString());
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

        RaiPolicyProperties IJsonModel<RaiPolicyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiPolicyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRaiPolicyProperties(document.RootElement, options);
        }

        internal static RaiPolicyProperties DeserializeRaiPolicyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string basePolicyName = default;
            IList<RaiBlocklistConfig> completionBlocklists = default;
            IList<RaiPolicyContentFilter> contentFilters = default;
            RaiPolicyMode? mode = default;
            IList<RaiBlocklistConfig> promptBlocklists = default;
            RaiPolicyType? type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("basePolicyName"u8))
                {
                    basePolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("completionBlocklists"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RaiBlocklistConfig> array = new List<RaiBlocklistConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RaiBlocklistConfig.DeserializeRaiBlocklistConfig(item, options));
                    }
                    completionBlocklists = array;
                    continue;
                }
                if (property.NameEquals("contentFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RaiPolicyContentFilter> array = new List<RaiPolicyContentFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RaiPolicyContentFilter.DeserializeRaiPolicyContentFilter(item, options));
                    }
                    contentFilters = array;
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new RaiPolicyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("promptBlocklists"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RaiBlocklistConfig> array = new List<RaiBlocklistConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RaiBlocklistConfig.DeserializeRaiBlocklistConfig(item, options));
                    }
                    promptBlocklists = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RaiPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RaiPolicyProperties(
                basePolicyName,
                completionBlocklists ?? new ChangeTrackingList<RaiBlocklistConfig>(),
                contentFilters ?? new ChangeTrackingList<RaiPolicyContentFilter>(),
                mode,
                promptBlocklists ?? new ChangeTrackingList<RaiBlocklistConfig>(),
                type,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RaiPolicyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RaiPolicyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        RaiPolicyProperties IPersistableModel<RaiPolicyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRaiPolicyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RaiPolicyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RaiPolicyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
