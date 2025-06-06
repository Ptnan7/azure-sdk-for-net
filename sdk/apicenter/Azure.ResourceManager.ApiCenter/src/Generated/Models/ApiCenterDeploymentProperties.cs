// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> API deployment entity properties. </summary>
    public partial class ApiCenterDeploymentProperties
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

        /// <summary> Initializes a new instance of <see cref="ApiCenterDeploymentProperties"/>. </summary>
        public ApiCenterDeploymentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiCenterDeploymentProperties"/>. </summary>
        /// <param name="title"> API deployment title. </param>
        /// <param name="description"> Description of the deployment. </param>
        /// <param name="environmentId"> API center-scoped environment resource ID. </param>
        /// <param name="definitionId"> API center-scoped definition resource ID. </param>
        /// <param name="state"> State of API deployment. </param>
        /// <param name="server"> The deployment server. </param>
        /// <param name="customProperties"> The custom metadata defined for API catalog entities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiCenterDeploymentProperties(string title, string description, ResourceIdentifier environmentId, ResourceIdentifier definitionId, ApiCenterDeploymentState? state, ApiCenterDeploymentServer server, BinaryData customProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Title = title;
            Description = description;
            EnvironmentId = environmentId;
            DefinitionId = definitionId;
            State = state;
            Server = server;
            CustomProperties = customProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> API deployment title. </summary>
        public string Title { get; set; }
        /// <summary> Description of the deployment. </summary>
        public string Description { get; set; }
        /// <summary> API center-scoped environment resource ID. </summary>
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary> API center-scoped definition resource ID. </summary>
        public ResourceIdentifier DefinitionId { get; set; }
        /// <summary> State of API deployment. </summary>
        public ApiCenterDeploymentState? State { get; set; }
        /// <summary> The deployment server. </summary>
        internal ApiCenterDeploymentServer Server { get; set; }
        /// <summary> Base runtime URLs for this deployment. </summary>
        public IList<Uri> ServerRuntimeUri
        {
            get
            {
                if (Server is null)
                    Server = new ApiCenterDeploymentServer();
                return Server.RuntimeUri;
            }
        }

        /// <summary>
        /// The custom metadata defined for API catalog entities.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData CustomProperties { get; set; }
    }
}
