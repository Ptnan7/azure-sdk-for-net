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
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    public partial class AppConfigurationStoreData : IUtf8JsonSerializable, IJsonModel<AppConfigurationStoreData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationStoreData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppConfigurationStoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStoreData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                if (PrivateEndpointConnections != null)
                {
                    writer.WritePropertyName("privateEndpointConnections"u8);
                    writer.WriteStartArray();
                    foreach (var item in PrivateEndpointConnections)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("privateEndpointConnections");
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(SoftDeleteRetentionInDays))
            {
                writer.WritePropertyName("softDeleteRetentionInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionInDays.Value);
            }
            if (Optional.IsDefined(EnablePurgeProtection))
            {
                writer.WritePropertyName("enablePurgeProtection"u8);
                writer.WriteBooleanValue(EnablePurgeProtection.Value);
            }
            if (Optional.IsDefined(DataPlaneProxy))
            {
                writer.WritePropertyName("dataPlaneProxy"u8);
                writer.WriteObjectValue(DataPlaneProxy, options);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        AppConfigurationStoreData IJsonModel<AppConfigurationStoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStoreData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationStoreData(document.RootElement, options);
        }

        internal static AppConfigurationStoreData DeserializeAppConfigurationStoreData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            AppConfigurationSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            AppConfigurationProvisioningState? provisioningState = default;
            DateTimeOffset? creationDate = default;
            string endpoint = default;
            AppConfigurationStoreEncryptionProperties encryption = default;
            IReadOnlyList<AppConfigurationPrivateEndpointConnectionReference> privateEndpointConnections = default;
            AppConfigurationPublicNetworkAccess? publicNetworkAccess = default;
            bool? disableLocalAuth = default;
            int? softDeleteRetentionInDays = default;
            bool? enablePurgeProtection = default;
            AppConfigurationDataPlaneProxyProperties dataPlaneProxy = default;
            AppConfigurationCreateMode? createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerAppConfigurationContext.Default);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = AppConfigurationSku.DeserializeAppConfigurationSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAppConfigurationContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AppConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = AppConfigurationStoreEncryptionProperties.DeserializeAppConfigurationStoreEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateEndpointConnections = null;
                                continue;
                            }
                            List<AppConfigurationPrivateEndpointConnectionReference> array = new List<AppConfigurationPrivateEndpointConnectionReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppConfigurationPrivateEndpointConnectionReference.DeserializeAppConfigurationPrivateEndpointConnectionReference(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new AppConfigurationPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("softDeleteRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softDeleteRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enablePurgeProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurgeProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataPlaneProxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataPlaneProxy = AppConfigurationDataPlaneProxyProperties.DeserializeAppConfigurationDataPlaneProxyProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = property0.Value.GetString().ToAppConfigurationCreateMode();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppConfigurationStoreData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                sku,
                provisioningState,
                creationDate,
                endpoint,
                encryption,
                privateEndpointConnections ?? new ChangeTrackingList<AppConfigurationPrivateEndpointConnectionReference>(),
                publicNetworkAccess,
                disableLocalAuth,
                softDeleteRetentionInDays,
                enablePurgeProtection,
                dataPlaneProxy,
                createMode,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Identity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  identity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Identity))
                {
                    builder.Append("  identity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Identity, options, 2, false, "  identity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SkuName", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine("{");
                builder.Append("    name: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    creationDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    creationDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Endpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    endpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Endpoint))
                {
                    builder.Append("    endpoint: ");
                    if (Endpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Endpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Endpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("EncryptionKeyVaultProperties", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    encryption: ");
                builder.AppendLine("{");
                builder.AppendLine("      encryption: {");
                builder.Append("        keyVaultProperties: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Encryption))
                {
                    builder.Append("    encryption: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Encryption, options, 4, false, "    encryption: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateEndpointConnections), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateEndpointConnections: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PrivateEndpointConnections))
                {
                    if (PrivateEndpointConnections.Any())
                    {
                        builder.Append("    privateEndpointConnections: ");
                        builder.AppendLine("[");
                        foreach (var item in PrivateEndpointConnections)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    privateEndpointConnections: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicNetworkAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    publicNetworkAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicNetworkAccess))
                {
                    builder.Append("    publicNetworkAccess: ");
                    builder.AppendLine($"'{PublicNetworkAccess.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisableLocalAuth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    disableLocalAuth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisableLocalAuth))
                {
                    builder.Append("    disableLocalAuth: ");
                    var boolValue = DisableLocalAuth.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SoftDeleteRetentionInDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    softDeleteRetentionInDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SoftDeleteRetentionInDays))
                {
                    builder.Append("    softDeleteRetentionInDays: ");
                    builder.AppendLine($"{SoftDeleteRetentionInDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnablePurgeProtection), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enablePurgeProtection: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnablePurgeProtection))
                {
                    builder.Append("    enablePurgeProtection: ");
                    var boolValue = EnablePurgeProtection.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataPlaneProxy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    dataPlaneProxy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataPlaneProxy))
                {
                    builder.Append("    dataPlaneProxy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DataPlaneProxy, options, 4, false, "    dataPlaneProxy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreateMode))
                {
                    builder.Append("    createMode: ");
                    builder.AppendLine($"'{CreateMode.Value.ToSerialString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppConfigurationStoreData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppConfigurationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStoreData)} does not support writing '{options.Format}' format.");
            }
        }

        AppConfigurationStoreData IPersistableModel<AppConfigurationStoreData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppConfigurationStoreData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStoreData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppConfigurationStoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
