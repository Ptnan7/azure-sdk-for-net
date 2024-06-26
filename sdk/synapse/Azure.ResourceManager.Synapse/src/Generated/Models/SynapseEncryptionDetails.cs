// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Details of the encryption associated with the workspace. </summary>
    public partial class SynapseEncryptionDetails
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

        /// <summary> Initializes a new instance of <see cref="SynapseEncryptionDetails"/>. </summary>
        public SynapseEncryptionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseEncryptionDetails"/>. </summary>
        /// <param name="isDoubleEncryptionEnabled"> Double Encryption enabled. </param>
        /// <param name="cmk"> Customer Managed Key Details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseEncryptionDetails(bool? isDoubleEncryptionEnabled, WorkspaceCustomerManagedKeyDetails cmk, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsDoubleEncryptionEnabled = isDoubleEncryptionEnabled;
            Cmk = cmk;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Double Encryption enabled. </summary>
        public bool? IsDoubleEncryptionEnabled { get; }
        /// <summary> Customer Managed Key Details. </summary>
        public WorkspaceCustomerManagedKeyDetails Cmk { get; set; }
    }
}
