// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The details of the managed identity used for CMK. </summary>
    public partial class BackupVaultCmkKekIdentity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupVaultCmkKekIdentity"/>. </summary>
        public BackupVaultCmkKekIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupVaultCmkKekIdentity"/>. </summary>
        /// <param name="identityType"> The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created managed identity. </param>
        /// <param name="identityId"> The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types: 'UserAssigned' only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupVaultCmkKekIdentity(BackupVaultCmkKekIdentityType? identityType, string identityId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdentityType = identityType;
            IdentityId = identityId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created managed identity. </summary>
        public BackupVaultCmkKekIdentityType? IdentityType { get; set; }
        /// <summary> The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types: 'UserAssigned' only. </summary>
        public string IdentityId { get; set; }
    }
}
