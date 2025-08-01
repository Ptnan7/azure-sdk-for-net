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
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class SessionHostData : IUtf8JsonSerializable, IJsonModel<SessionHostData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionHostData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SessionHostData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(LastHeartBeatOn))
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartBeatOn.Value, "O");
            }
            if (Optional.IsDefined(Sessions))
            {
                writer.WritePropertyName("sessions"u8);
                writer.WriteNumberValue(Sessions.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AllowNewSession))
            {
                writer.WritePropertyName("allowNewSession"u8);
                writer.WriteBooleanValue(AllowNewSession.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VmId);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(AssignedUser))
            {
                writer.WritePropertyName("assignedUser"u8);
                writer.WriteStringValue(AssignedUser);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StatusTimestamp))
            {
                writer.WritePropertyName("statusTimestamp"u8);
                writer.WriteStringValue(StatusTimestamp.Value, "O");
            }
            if (Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsDefined(SxsStackVersion))
            {
                writer.WritePropertyName("sxSStackVersion"u8);
                writer.WriteStringValue(SxsStackVersion);
            }
            if (Optional.IsDefined(UpdateState))
            {
                writer.WritePropertyName("updateState"u8);
                writer.WriteStringValue(UpdateState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdateTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdateErrorMessage))
            {
                writer.WritePropertyName("updateErrorMessage"u8);
                writer.WriteStringValue(UpdateErrorMessage);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SessionHostHealthCheckResults))
            {
                writer.WritePropertyName("sessionHostHealthCheckResults"u8);
                writer.WriteStartArray();
                foreach (var item in SessionHostHealthCheckResults)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        SessionHostData IJsonModel<SessionHostData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionHostData(document.RootElement, options);
        }

        internal static SessionHostData DeserializeSessionHostData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string objectId = default;
            DateTimeOffset? lastHeartBeat = default;
            int? sessions = default;
            string agentVersion = default;
            bool? allowNewSession = default;
            string virtualMachineId = default;
            ResourceIdentifier resourceId = default;
            string assignedUser = default;
            string friendlyName = default;
            SessionHostStatus? status = default;
            DateTimeOffset? statusTimestamp = default;
            string osVersion = default;
            string sxsStackVersion = default;
            SessionHostUpdateState? updateState = default;
            DateTimeOffset? lastUpdateTime = default;
            string updateErrorMessage = default;
            IReadOnlyList<SessionHostHealthCheckReport> sessionHostHealthCheckResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDesktopVirtualizationContext.Default);
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
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            lastHeartBeat = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sessions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessions = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowNewSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowNewSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineId"u8))
                        {
                            virtualMachineId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("assignedUser"u8))
                        {
                            assignedUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SessionHostStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            statusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osVersion"u8))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sxSStackVersion"u8))
                        {
                            sxsStackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateState = new SessionHostUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateErrorMessage"u8))
                        {
                            updateErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionHostHealthCheckResults"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SessionHostHealthCheckReport> array = new List<SessionHostHealthCheckReport>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SessionHostHealthCheckReport.DeserializeSessionHostHealthCheckReport(item, options));
                            }
                            sessionHostHealthCheckResults = array;
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
            return new SessionHostData(
                id,
                name,
                type,
                systemData,
                objectId,
                lastHeartBeat,
                sessions,
                agentVersion,
                allowNewSession,
                virtualMachineId,
                resourceId,
                assignedUser,
                friendlyName,
                status,
                statusTimestamp,
                osVersion,
                sxsStackVersion,
                updateState,
                lastUpdateTime,
                updateErrorMessage,
                sessionHostHealthCheckResults ?? new ChangeTrackingList<SessionHostHealthCheckReport>(),
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    objectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ObjectId))
                {
                    builder.Append("    objectId: ");
                    if (ObjectId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ObjectId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ObjectId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastHeartBeatOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastHeartBeat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastHeartBeatOn))
                {
                    builder.Append("    lastHeartBeat: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastHeartBeatOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sessions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sessions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sessions))
                {
                    builder.Append("    sessions: ");
                    builder.AppendLine($"{Sessions.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    agentVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentVersion))
                {
                    builder.Append("    agentVersion: ");
                    if (AgentVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowNewSession), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    allowNewSession: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowNewSession))
                {
                    builder.Append("    allowNewSession: ");
                    var boolValue = AllowNewSession.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    virtualMachineId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmId))
                {
                    builder.Append("    virtualMachineId: ");
                    if (VmId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceId))
                {
                    builder.Append("    resourceId: ");
                    builder.AppendLine($"'{ResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignedUser), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    assignedUser: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignedUser))
                {
                    builder.Append("    assignedUser: ");
                    if (AssignedUser.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AssignedUser}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AssignedUser}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FriendlyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    friendlyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FriendlyName))
                {
                    builder.Append("    friendlyName: ");
                    if (FriendlyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FriendlyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FriendlyName}'");
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
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    statusTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StatusTimestamp))
                {
                    builder.Append("    statusTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(StatusTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OSVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    osVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OSVersion))
                {
                    builder.Append("    osVersion: ");
                    if (OSVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OSVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OSVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SxsStackVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sxSStackVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SxsStackVersion))
                {
                    builder.Append("    sxSStackVersion: ");
                    if (SxsStackVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SxsStackVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SxsStackVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdateState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    updateState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdateState))
                {
                    builder.Append("    updateState: ");
                    builder.AppendLine($"'{UpdateState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastUpdateTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdatedOn))
                {
                    builder.Append("    lastUpdateTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdateErrorMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    updateErrorMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdateErrorMessage))
                {
                    builder.Append("    updateErrorMessage: ");
                    if (UpdateErrorMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UpdateErrorMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UpdateErrorMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SessionHostHealthCheckResults), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sessionHostHealthCheckResults: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SessionHostHealthCheckResults))
                {
                    if (SessionHostHealthCheckResults.Any())
                    {
                        builder.Append("    sessionHostHealthCheckResults: ");
                        builder.AppendLine("[");
                        foreach (var item in SessionHostHealthCheckResults)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    sessionHostHealthCheckResults: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SessionHostData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDesktopVirtualizationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SessionHostData)} does not support writing '{options.Format}' format.");
            }
        }

        SessionHostData IPersistableModel<SessionHostData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSessionHostData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionHostData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionHostData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
