// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Storage.Common;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class StorageError
    {
        internal static StorageError DeserializeStorageError(XElement element)
        {
            string message = default;
            long? copySourceStatusCode = default;
            string copySourceErrorCode = default;
            string copySourceErrorMessage = default;
            string authenticationErrorDetail = default;
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            if (element.Element("CopySourceStatusCode") is XElement copySourceStatusCodeElement)
            {
                copySourceStatusCode = (long?)copySourceStatusCodeElement;
            }
            if (element.Element("CopySourceErrorCode") is XElement copySourceErrorCodeElement)
            {
                copySourceErrorCode = (string)copySourceErrorCodeElement;
            }
            if (element.Element("CopySourceErrorMessage") is XElement copySourceErrorMessageElement)
            {
                copySourceErrorMessage = (string)copySourceErrorMessageElement;
            }
            if (element.Element("AuthenticationErrorDetail") is XElement authenticationErrorDetailElement)
            {
                authenticationErrorDetail = (string)authenticationErrorDetailElement;
            }
            return new StorageError(message, copySourceStatusCode, copySourceErrorCode, copySourceErrorMessage, authenticationErrorDetail);
        }

        internal static StorageError DeserializeStorageError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            long? copySourceStatusCode = default;
            string copySourceErrorCode = default;
            string copySourceErrorMessage = default;
            string authenticationErrorDetail = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("CopySourceStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copySourceStatusCode = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("CopySourceErrorCode"u8))
                {
                    copySourceErrorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("CopySourceErrorMessage"u8))
                {
                    copySourceErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("AuthenticationErrorDetail"u8))
                {
                    authenticationErrorDetail = property.Value.GetString();
                    continue;
                }
            }
            return new StorageError(message, copySourceStatusCode, copySourceErrorCode, copySourceErrorMessage, authenticationErrorDetail);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeStorageError(document.RootElement);
        }
    }
}
