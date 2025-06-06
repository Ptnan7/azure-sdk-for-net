// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    public partial class AvailablePhoneNumber : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("countryCode"u8);
            writer.WriteStringValue(CountryCode);
            writer.WritePropertyName("capabilities"u8);
            writer.WriteObjectValue<PhoneNumberCapabilities>(Capabilities);
            writer.WritePropertyName("phoneNumberType"u8);
            writer.WriteStringValue(PhoneNumberType.ToString());
            writer.WritePropertyName("assignmentType"u8);
            writer.WriteStringValue(AssignmentType.ToString());
            writer.WriteEndObject();
        }

        internal static AvailablePhoneNumber DeserializeAvailablePhoneNumber(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string countryCode = default;
            string phoneNumber = default;
            PhoneNumberCapabilities capabilities = default;
            PhoneNumberType phoneNumberType = default;
            PhoneNumberAssignmentType assignmentType = default;
            PhoneNumberCost cost = default;
            PhoneNumberAvailabilityStatus status = default;
            bool isAgreementToNotResellRequired = default;
            ResponseError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = PhoneNumberCapabilities.DeserializePhoneNumberCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumberType"u8))
                {
                    phoneNumberType = new PhoneNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    assignmentType = new PhoneNumberAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = PhoneNumberCost.DeserializePhoneNumberCost(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new PhoneNumberAvailabilityStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isAgreementToNotResellRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAgreementToNotResellRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new AvailablePhoneNumber(
                id,
                countryCode,
                phoneNumber,
                capabilities,
                phoneNumberType,
                assignmentType,
                cost,
                status,
                isAgreementToNotResellRequired,
                error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AvailablePhoneNumber FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAvailablePhoneNumber(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
