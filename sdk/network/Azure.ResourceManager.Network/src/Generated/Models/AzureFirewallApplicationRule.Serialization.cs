// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureFirewallApplicationRule : IUtf8JsonSerializable, IJsonModel<AzureFirewallApplicationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFirewallApplicationRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureFirewallApplicationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallApplicationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallApplicationRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TargetFqdns))
            {
                writer.WritePropertyName("targetFqdns"u8);
                writer.WriteStartArray();
                foreach (var item in TargetFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FqdnTags))
            {
                writer.WritePropertyName("fqdnTags"u8);
                writer.WriteStartArray();
                foreach (var item in FqdnTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceIPGroups))
            {
                writer.WritePropertyName("sourceIpGroups"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AzureFirewallApplicationRule IJsonModel<AzureFirewallApplicationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallApplicationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFirewallApplicationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFirewallApplicationRule(document.RootElement, options);
        }

        internal static AzureFirewallApplicationRule DeserializeAzureFirewallApplicationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string description = default;
            IList<string> sourceAddresses = default;
            IList<AzureFirewallApplicationRuleProtocol> protocols = default;
            IList<string> targetFqdns = default;
            IList<string> fqdnTags = default;
            IList<string> sourceIPGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("protocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallApplicationRuleProtocol> array = new List<AzureFirewallApplicationRuleProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureFirewallApplicationRuleProtocol.DeserializeAzureFirewallApplicationRuleProtocol(item, options));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("targetFqdns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    targetFqdns = array;
                    continue;
                }
                if (property.NameEquals("fqdnTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fqdnTags = array;
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceIPGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureFirewallApplicationRule(
                name,
                description,
                sourceAddresses ?? new ChangeTrackingList<string>(),
                protocols ?? new ChangeTrackingList<AzureFirewallApplicationRuleProtocol>(),
                targetFqdns ?? new ChangeTrackingList<string>(),
                fqdnTags ?? new ChangeTrackingList<string>(),
                sourceIPGroups ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureFirewallApplicationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallApplicationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallApplicationRule)} does not support writing '{options.Format}' format.");
            }
        }

        AzureFirewallApplicationRule IPersistableModel<AzureFirewallApplicationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFirewallApplicationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureFirewallApplicationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureFirewallApplicationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureFirewallApplicationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
