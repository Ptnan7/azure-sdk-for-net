// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Result of list Api keys and connection strings. </summary>
    public partial class WorkspaceKeyListResult
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceKeyListResult"/>. </summary>
        internal WorkspaceKeyListResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceKeyListResult"/>. </summary>
        /// <param name="isApiKeyEnabled"> Indicator of enablement of the Quantum workspace Api keys. </param>
        /// <param name="primaryKey"> The quantum workspace primary api key. </param>
        /// <param name="secondaryKey"> The quantum workspace secondary api key. </param>
        /// <param name="primaryConnectionString"> The connection string of the primary api key. </param>
        /// <param name="secondaryConnectionString"> The connection string of the secondary api key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceKeyListResult(bool? isApiKeyEnabled, WorkspaceApiKey primaryKey, WorkspaceApiKey secondaryKey, string primaryConnectionString, string secondaryConnectionString, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsApiKeyEnabled = isApiKeyEnabled;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicator of enablement of the Quantum workspace Api keys. </summary>
        public bool? IsApiKeyEnabled { get; }
        /// <summary> The quantum workspace primary api key. </summary>
        public WorkspaceApiKey PrimaryKey { get; }
        /// <summary> The quantum workspace secondary api key. </summary>
        public WorkspaceApiKey SecondaryKey { get; }
        /// <summary> The connection string of the primary api key. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> The connection string of the secondary api key. </summary>
        public string SecondaryConnectionString { get; }
    }
}
