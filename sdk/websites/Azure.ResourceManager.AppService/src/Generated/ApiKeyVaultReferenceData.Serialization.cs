// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ApiKeyVaultReferenceData : IUtf8JsonSerializable, IJsonModel<ApiKeyVaultReferenceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiKeyVaultReferenceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiKeyVaultReferenceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Reference))
            {
                writer.WritePropertyName("reference"u8);
                writer.WriteStringValue(Reference);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("vaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(SecretName))
            {
                writer.WritePropertyName("secretName"u8);
                writer.WriteStringValue(SecretName);
            }
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identityType"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Optional.IsDefined(ActiveVersion))
            {
                writer.WritePropertyName("activeVersion"u8);
                writer.WriteStringValue(ActiveVersion);
            }
            writer.WriteEndObject();
        }

        ApiKeyVaultReferenceData IJsonModel<ApiKeyVaultReferenceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiKeyVaultReferenceData(document.RootElement, options);
        }

        internal static ApiKeyVaultReferenceData DeserializeApiKeyVaultReferenceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string reference = default;
            ResolveStatus? status = default;
            string vaultName = default;
            string secretName = default;
            string secretVersion = default;
            ManagedServiceIdentity identityType = default;
            string details = default;
            ConfigReferenceSource? source = default;
            string activeVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAppServiceContext.Default);
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
                        if (property0.NameEquals("reference"u8))
                        {
                            reference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToResolveStatus();
                            continue;
                        }
                        if (property0.NameEquals("vaultName"u8))
                        {
                            vaultName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretName"u8))
                        {
                            secretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretVersion"u8))
                        {
                            secretVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identityType = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerAppServiceContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            details = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new ConfigReferenceSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeVersion"u8))
                        {
                            activeVersion = property0.Value.GetString();
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
            return new ApiKeyVaultReferenceData(
                id,
                name,
                type,
                systemData,
                reference,
                status,
                vaultName,
                secretName,
                secretVersion,
                identityType,
                details,
                source,
                activeVersion,
                kind,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reference), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    reference: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reference))
                {
                    builder.Append("    reference: ");
                    if (Reference.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reference}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reference}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("    status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VaultName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vaultName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VaultName))
                {
                    builder.Append("    vaultName: ");
                    if (VaultName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VaultName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VaultName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecretName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    secretName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecretName))
                {
                    builder.Append("    secretName: ");
                    if (SecretName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecretName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecretName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecretVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    secretVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecretVersion))
                {
                    builder.Append("    secretVersion: ");
                    if (SecretVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecretVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecretVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Identity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    identityType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Identity))
                {
                    builder.Append("    identityType: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Identity, options, 4, false, "    identityType: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Details), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    details: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Details))
                {
                    builder.Append("    details: ");
                    if (Details.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Details}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Details}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Source), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Source))
                {
                    builder.Append("    source: ");
                    builder.AppendLine($"'{Source.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActiveVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    activeVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActiveVersion))
                {
                    builder.Append("    activeVersion: ");
                    if (ActiveVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ActiveVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ActiveVersion}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiKeyVaultReferenceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support writing '{options.Format}' format.");
            }
        }

        ApiKeyVaultReferenceData IPersistableModel<ApiKeyVaultReferenceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiKeyVaultReferenceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiKeyVaultReferenceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
