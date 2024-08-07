// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> The template for adding optional properties. </summary>
    public partial class InformaticaNetworkInterfaceConfigurationUpdate
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

        /// <summary> Initializes a new instance of <see cref="InformaticaNetworkInterfaceConfigurationUpdate"/>. </summary>
        public InformaticaNetworkInterfaceConfigurationUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InformaticaNetworkInterfaceConfigurationUpdate"/>. </summary>
        /// <param name="vnetId"> Virtual network resource id. </param>
        /// <param name="subnetId"> Virtual network subnet resource id. </param>
        /// <param name="vnetResourceGuid"> Virtual network resource guid. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InformaticaNetworkInterfaceConfigurationUpdate(ResourceIdentifier vnetId, ResourceIdentifier subnetId, string vnetResourceGuid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VnetId = vnetId;
            SubnetId = subnetId;
            VnetResourceGuid = vnetResourceGuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Virtual network resource id. </summary>
        public ResourceIdentifier VnetId { get; set; }
        /// <summary> Virtual network subnet resource id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Virtual network resource guid. </summary>
        public string VnetResourceGuid { get; set; }
    }
}
