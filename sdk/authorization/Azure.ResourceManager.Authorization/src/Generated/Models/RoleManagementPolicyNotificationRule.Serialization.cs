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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyNotificationRule : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyNotificationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyNotificationRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoleManagementPolicyNotificationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyNotificationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyNotificationRule)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(NotificationDeliveryType))
            {
                writer.WritePropertyName("notificationType"u8);
                writer.WriteStringValue(NotificationDeliveryType.Value.ToString());
            }
            if (Optional.IsDefined(NotificationLevel))
            {
                writer.WritePropertyName("notificationLevel"u8);
                writer.WriteStringValue(NotificationLevel.Value.ToString());
            }
            if (Optional.IsDefined(RecipientType))
            {
                writer.WritePropertyName("recipientType"u8);
                writer.WriteStringValue(RecipientType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NotificationRecipients))
            {
                writer.WritePropertyName("notificationRecipients"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationRecipients)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AreDefaultRecipientsEnabled))
            {
                writer.WritePropertyName("isDefaultRecipientsEnabled"u8);
                writer.WriteBooleanValue(AreDefaultRecipientsEnabled.Value);
            }
        }

        RoleManagementPolicyNotificationRule IJsonModel<RoleManagementPolicyNotificationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyNotificationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyNotificationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyNotificationRule(document.RootElement, options);
        }

        internal static RoleManagementPolicyNotificationRule DeserializeRoleManagementPolicyNotificationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NotificationDeliveryType? notificationType = default;
            RoleManagementPolicyNotificationLevel? notificationLevel = default;
            RoleManagementPolicyRecipientType? recipientType = default;
            IList<string> notificationRecipients = default;
            bool? isDefaultRecipientsEnabled = default;
            string id = default;
            RoleManagementPolicyRuleType ruleType = default;
            RoleManagementPolicyRuleTarget target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationType = new NotificationDeliveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationLevel = new RoleManagementPolicyNotificationLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recipientType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientType = new RoleManagementPolicyRecipientType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationRecipients"u8))
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
                    notificationRecipients = array;
                    continue;
                }
                if (property.NameEquals("isDefaultRecipientsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultRecipientsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoleManagementPolicyNotificationRule(
                id,
                ruleType,
                target,
                serializedAdditionalRawData,
                notificationType,
                notificationLevel,
                recipientType,
                notificationRecipients ?? new ChangeTrackingList<string>(),
                isDefaultRecipientsEnabled);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationDeliveryType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NotificationDeliveryType))
                {
                    builder.Append("  notificationType: ");
                    builder.AppendLine($"'{NotificationDeliveryType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationLevel), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationLevel: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NotificationLevel))
                {
                    builder.Append("  notificationLevel: ");
                    builder.AppendLine($"'{NotificationLevel.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RecipientType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  recipientType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RecipientType))
                {
                    builder.Append("  recipientType: ");
                    builder.AppendLine($"'{RecipientType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationRecipients), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationRecipients: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NotificationRecipients))
                {
                    if (NotificationRecipients.Any())
                    {
                        builder.Append("  notificationRecipients: ");
                        builder.AppendLine("[");
                        foreach (var item in NotificationRecipients)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AreDefaultRecipientsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isDefaultRecipientsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AreDefaultRecipientsEnabled))
                {
                    builder.Append("  isDefaultRecipientsEnabled: ");
                    var boolValue = AreDefaultRecipientsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
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
                    if (Id.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Id}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Id}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ruleType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  ruleType: ");
                builder.AppendLine($"'{RuleType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Target, options, 2, false, "  target: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RoleManagementPolicyNotificationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyNotificationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAuthorizationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyNotificationRule)} does not support writing '{options.Format}' format.");
            }
        }

        RoleManagementPolicyNotificationRule IPersistableModel<RoleManagementPolicyNotificationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyNotificationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoleManagementPolicyNotificationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyNotificationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyNotificationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
