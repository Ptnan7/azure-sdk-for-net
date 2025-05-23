// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesAuthorization : IUtf8JsonSerializable, IJsonModel<ManagedServicesAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesAuthorization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedServicesAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesAuthorization)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsDefined(PrincipalIdDisplayName))
            {
                writer.WritePropertyName("principalIdDisplayName"u8);
                writer.WriteStringValue(PrincipalIdDisplayName);
            }
            writer.WritePropertyName("roleDefinitionId"u8);
            writer.WriteStringValue(RoleDefinitionId);
            if (Optional.IsCollectionDefined(DelegatedRoleDefinitionIds))
            {
                writer.WritePropertyName("delegatedRoleDefinitionIds"u8);
                writer.WriteStartArray();
                foreach (var item in DelegatedRoleDefinitionIds)
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

        ManagedServicesAuthorization IJsonModel<ManagedServicesAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesAuthorization(document.RootElement, options);
        }

        internal static ManagedServicesAuthorization DeserializeManagedServicesAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            string principalIdDisplayName = default;
            string roleDefinitionId = default;
            IList<Guid> delegatedRoleDefinitionIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalIdDisplayName"u8))
                {
                    principalIdDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedRoleDefinitionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    delegatedRoleDefinitionIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedServicesAuthorization(principalId, principalIdDisplayName, roleDefinitionId, delegatedRoleDefinitionIds ?? new ChangeTrackingList<Guid>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServicesAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerManagedServicesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServicesAuthorization IPersistableModel<ManagedServicesAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedServicesAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicesAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
