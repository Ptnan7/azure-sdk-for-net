// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> The properties of Solution Type. </summary>
    public partial class PublicCloudConnectorSolutionTypeSettings
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

        /// <summary> Initializes a new instance of <see cref="PublicCloudConnectorSolutionTypeSettings"/>. </summary>
        /// <param name="solutionType"> The type of the solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionType"/> is null. </exception>
        public PublicCloudConnectorSolutionTypeSettings(string solutionType)
        {
            Argument.AssertNotNull(solutionType, nameof(solutionType));

            SolutionType = solutionType;
        }

        /// <summary> Initializes a new instance of <see cref="PublicCloudConnectorSolutionTypeSettings"/>. </summary>
        /// <param name="solutionType"> The type of the solution. </param>
        /// <param name="solutionSettings"> Solution settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicCloudConnectorSolutionTypeSettings(string solutionType, PublicCloudConnectorSolutionSettings solutionSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SolutionType = solutionType;
            SolutionSettings = solutionSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PublicCloudConnectorSolutionTypeSettings"/> for deserialization. </summary>
        internal PublicCloudConnectorSolutionTypeSettings()
        {
        }

        /// <summary> The type of the solution. </summary>
        public string SolutionType { get; }
        /// <summary> Solution settings. </summary>
        public PublicCloudConnectorSolutionSettings SolutionSettings { get; set; }
    }
}
