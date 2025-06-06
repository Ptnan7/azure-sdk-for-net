// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Fabric model properties. </summary>
    public partial class DataReplicationFabricProperties
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

        /// <summary> Initializes a new instance of <see cref="DataReplicationFabricProperties"/>. </summary>
        /// <param name="customProperties">
        /// Fabric model custom properties.
        /// Please note <see cref="DataReplicationFabricCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzStackHciFabricCustomProperties"/>, <see cref="HyperVMigrateFabricCustomProperties"/> and <see cref="VMwareMigrateFabricCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        public DataReplicationFabricProperties(DataReplicationFabricCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            HealthErrors = new ChangeTrackingList<DataReplicationHealthErrorInfo>();
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationFabricProperties"/>. </summary>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the fabric. </param>
        /// <param name="serviceEndpoint"> Gets or sets the service endpoint. </param>
        /// <param name="serviceResourceId"> Gets or sets the service resource Id. </param>
        /// <param name="health"> Gets or sets the fabric health. </param>
        /// <param name="healthErrors"> Gets or sets the list of health errors. </param>
        /// <param name="customProperties">
        /// Fabric model custom properties.
        /// Please note <see cref="DataReplicationFabricCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzStackHciFabricCustomProperties"/>, <see cref="HyperVMigrateFabricCustomProperties"/> and <see cref="VMwareMigrateFabricCustomProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationFabricProperties(DataReplicationProvisioningState? provisioningState, string serviceEndpoint, ResourceIdentifier serviceResourceId, DataReplicationHealthStatus? health, IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors, DataReplicationFabricCustomProperties customProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            ServiceEndpoint = serviceEndpoint;
            ServiceResourceId = serviceResourceId;
            Health = health;
            HealthErrors = healthErrors;
            CustomProperties = customProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationFabricProperties"/> for deserialization. </summary>
        internal DataReplicationFabricProperties()
        {
        }

        /// <summary> Gets or sets the provisioning state of the fabric. </summary>
        public DataReplicationProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets or sets the service resource Id. </summary>
        public ResourceIdentifier ServiceResourceId { get; }
        /// <summary> Gets or sets the fabric health. </summary>
        public DataReplicationHealthStatus? Health { get; }
        /// <summary> Gets or sets the list of health errors. </summary>
        public IReadOnlyList<DataReplicationHealthErrorInfo> HealthErrors { get; }
        /// <summary>
        /// Fabric model custom properties.
        /// Please note <see cref="DataReplicationFabricCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzStackHciFabricCustomProperties"/>, <see cref="HyperVMigrateFabricCustomProperties"/> and <see cref="VMwareMigrateFabricCustomProperties"/>.
        /// </summary>
        public DataReplicationFabricCustomProperties CustomProperties { get; set; }
    }
}
