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
    public partial class IpamPoolUsage : IUtf8JsonSerializable, IJsonModel<IpamPoolUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IpamPoolUsage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IpamPoolUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpamPoolUsage)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ChildPools))
            {
                writer.WritePropertyName("childPools"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AllocatedAddressPrefixes))
            {
                writer.WritePropertyName("allocatedAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllocatedAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReservedAddressPrefixes))
            {
                writer.WritePropertyName("reservedAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in ReservedAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AvailableAddressPrefixes))
            {
                writer.WritePropertyName("availableAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TotalNumberOfIPAddresses))
            {
                writer.WritePropertyName("totalNumberOfIPAddresses"u8);
                writer.WriteStringValue(TotalNumberOfIPAddresses);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfAllocatedIPAddresses))
            {
                writer.WritePropertyName("numberOfAllocatedIPAddresses"u8);
                writer.WriteStringValue(NumberOfAllocatedIPAddresses);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfReservedIPAddresses))
            {
                writer.WritePropertyName("numberOfReservedIPAddresses"u8);
                writer.WriteStringValue(NumberOfReservedIPAddresses);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfAvailableIPAddresses))
            {
                writer.WritePropertyName("numberOfAvailableIPAddresses"u8);
                writer.WriteStringValue(NumberOfAvailableIPAddresses);
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

        IpamPoolUsage IJsonModel<IpamPoolUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpamPoolUsage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIpamPoolUsage(document.RootElement, options);
        }

        internal static IpamPoolUsage DeserializeIpamPoolUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> addressPrefixes = default;
            IReadOnlyList<IpamResourceBasics> childPools = default;
            IReadOnlyList<string> allocatedAddressPrefixes = default;
            IReadOnlyList<string> reservedAddressPrefixes = default;
            IReadOnlyList<string> availableAddressPrefixes = default;
            string totalNumberOfIPAddresses = default;
            string numberOfAllocatedIPAddresses = default;
            string numberOfReservedIPAddresses = default;
            string numberOfAvailableIPAddresses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefixes"u8))
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
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("childPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IpamResourceBasics> array = new List<IpamResourceBasics>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IpamResourceBasics.DeserializeIpamResourceBasics(item, options));
                    }
                    childPools = array;
                    continue;
                }
                if (property.NameEquals("allocatedAddressPrefixes"u8))
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
                    allocatedAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("reservedAddressPrefixes"u8))
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
                    reservedAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("availableAddressPrefixes"u8))
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
                    availableAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("totalNumberOfIPAddresses"u8))
                {
                    totalNumberOfIPAddresses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfAllocatedIPAddresses"u8))
                {
                    numberOfAllocatedIPAddresses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfReservedIPAddresses"u8))
                {
                    numberOfReservedIPAddresses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfAvailableIPAddresses"u8))
                {
                    numberOfAvailableIPAddresses = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IpamPoolUsage(
                addressPrefixes ?? new ChangeTrackingList<string>(),
                childPools ?? new ChangeTrackingList<IpamResourceBasics>(),
                allocatedAddressPrefixes ?? new ChangeTrackingList<string>(),
                reservedAddressPrefixes ?? new ChangeTrackingList<string>(),
                availableAddressPrefixes ?? new ChangeTrackingList<string>(),
                totalNumberOfIPAddresses,
                numberOfAllocatedIPAddresses,
                numberOfReservedIPAddresses,
                numberOfAvailableIPAddresses,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IpamPoolUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IpamPoolUsage)} does not support writing '{options.Format}' format.");
            }
        }

        IpamPoolUsage IPersistableModel<IpamPoolUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIpamPoolUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IpamPoolUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IpamPoolUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
