// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBLocationProperties : IUtf8JsonSerializable, IJsonModel<CosmosDBLocationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBLocationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBLocationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBLocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBLocationProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DoesSupportAvailabilityZone))
            {
                writer.WritePropertyName("supportsAvailabilityZone"u8);
                writer.WriteBooleanValue(DoesSupportAvailabilityZone.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsResidencyRestricted))
            {
                writer.WritePropertyName("isResidencyRestricted"u8);
                writer.WriteBooleanValue(IsResidencyRestricted.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BackupStorageRedundancies))
            {
                writer.WritePropertyName("backupStorageRedundancies"u8);
                writer.WriteStartArray();
                foreach (var item in BackupStorageRedundancies)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsSubscriptionRegionAccessAllowedForRegular))
            {
                writer.WritePropertyName("isSubscriptionRegionAccessAllowedForRegular"u8);
                writer.WriteBooleanValue(IsSubscriptionRegionAccessAllowedForRegular.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsSubscriptionRegionAccessAllowedForAz))
            {
                writer.WritePropertyName("isSubscriptionRegionAccessAllowedForAz"u8);
                writer.WriteBooleanValue(IsSubscriptionRegionAccessAllowedForAz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        CosmosDBLocationProperties IJsonModel<CosmosDBLocationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBLocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBLocationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBLocationProperties(document.RootElement, options);
        }

        internal static CosmosDBLocationProperties DeserializeCosmosDBLocationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? supportsAvailabilityZone = default;
            bool? isResidencyRestricted = default;
            IReadOnlyList<CosmosDBBackupStorageRedundancy> backupStorageRedundancies = default;
            bool? isSubscriptionRegionAccessAllowedForRegular = default;
            bool? isSubscriptionRegionAccessAllowedForAz = default;
            CosmosDBStatus? status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportsAvailabilityZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportsAvailabilityZone = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isResidencyRestricted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResidencyRestricted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupStorageRedundancies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBBackupStorageRedundancy> array = new List<CosmosDBBackupStorageRedundancy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CosmosDBBackupStorageRedundancy(item.GetString()));
                    }
                    backupStorageRedundancies = array;
                    continue;
                }
                if (property.NameEquals("isSubscriptionRegionAccessAllowedForRegular"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSubscriptionRegionAccessAllowedForRegular = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSubscriptionRegionAccessAllowedForAz"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSubscriptionRegionAccessAllowedForAz = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBLocationProperties(
                supportsAvailabilityZone,
                isResidencyRestricted,
                backupStorageRedundancies ?? new ChangeTrackingList<CosmosDBBackupStorageRedundancy>(),
                isSubscriptionRegionAccessAllowedForRegular,
                isSubscriptionRegionAccessAllowedForAz,
                status,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DoesSupportAvailabilityZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportsAvailabilityZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DoesSupportAvailabilityZone))
                {
                    builder.Append("  supportsAvailabilityZone: ");
                    var boolValue = DoesSupportAvailabilityZone.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsResidencyRestricted), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isResidencyRestricted: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsResidencyRestricted))
                {
                    builder.Append("  isResidencyRestricted: ");
                    var boolValue = IsResidencyRestricted.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupStorageRedundancies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupStorageRedundancies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BackupStorageRedundancies))
                {
                    if (BackupStorageRedundancies.Any())
                    {
                        builder.Append("  backupStorageRedundancies: ");
                        builder.AppendLine("[");
                        foreach (var item in BackupStorageRedundancies)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubscriptionRegionAccessAllowedForRegular), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSubscriptionRegionAccessAllowedForRegular: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubscriptionRegionAccessAllowedForRegular))
                {
                    builder.Append("  isSubscriptionRegionAccessAllowedForRegular: ");
                    var boolValue = IsSubscriptionRegionAccessAllowedForRegular.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubscriptionRegionAccessAllowedForAz), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSubscriptionRegionAccessAllowedForAz: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubscriptionRegionAccessAllowedForAz))
                {
                    builder.Append("  isSubscriptionRegionAccessAllowedForAz: ");
                    var boolValue = IsSubscriptionRegionAccessAllowedForAz.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBLocationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBLocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCosmosDBContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBLocationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBLocationProperties IPersistableModel<CosmosDBLocationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBLocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCosmosDBLocationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBLocationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBLocationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
