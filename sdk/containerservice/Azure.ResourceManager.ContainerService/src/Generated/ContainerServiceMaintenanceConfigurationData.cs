// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ContainerServiceMaintenanceConfiguration data model.
    /// See [planned maintenance](https://docs.microsoft.com/azure/aks/planned-maintenance) for more information about planned maintenance.
    /// </summary>
    public partial class ContainerServiceMaintenanceConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceConfigurationData"/>. </summary>
        public ContainerServiceMaintenanceConfigurationData()
        {
            TimesInWeek = new ChangeTrackingList<ContainerServiceTimeInWeek>();
            NotAllowedTimes = new ChangeTrackingList<ContainerServiceTimeSpan>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timesInWeek"> If two array entries specify the same day of the week, the applied configuration is the union of times in both entries. </param>
        /// <param name="notAllowedTimes"> Time slots on which upgrade is not allowed. </param>
        /// <param name="maintenanceWindow"> Maintenance window for the maintenance configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceMaintenanceConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ContainerServiceTimeInWeek> timesInWeek, IList<ContainerServiceTimeSpan> notAllowedTimes, ContainerServiceMaintenanceWindow maintenanceWindow, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TimesInWeek = timesInWeek;
            NotAllowedTimes = notAllowedTimes;
            MaintenanceWindow = maintenanceWindow;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> If two array entries specify the same day of the week, the applied configuration is the union of times in both entries. </summary>
        [WirePath("properties.timeInWeek")]
        public IList<ContainerServiceTimeInWeek> TimesInWeek { get; }
        /// <summary> Time slots on which upgrade is not allowed. </summary>
        [WirePath("properties.notAllowedTime")]
        public IList<ContainerServiceTimeSpan> NotAllowedTimes { get; }
        /// <summary> Maintenance window for the maintenance configuration. </summary>
        [WirePath("properties.maintenanceWindow")]
        public ContainerServiceMaintenanceWindow MaintenanceWindow { get; set; }
    }
}
