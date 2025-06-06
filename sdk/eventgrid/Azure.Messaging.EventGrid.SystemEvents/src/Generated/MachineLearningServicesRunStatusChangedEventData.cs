// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.MachineLearningServices.RunStatusChanged event. </summary>
    public partial class MachineLearningServicesRunStatusChangedEventData
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicesRunStatusChangedEventData"/>. </summary>
        /// <param name="experimentId"> The ID of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="experimentName"> The name of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="runId"> The ID of the Machine Learning Run. </param>
        /// <param name="runType"> The Run Type of the Machine Learning Run. </param>
        /// <param name="runStatus"> The status of the Machine Learning Run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentId"/>, <paramref name="experimentName"/>, <paramref name="runId"/>, <paramref name="runType"/> or <paramref name="runStatus"/> is null. </exception>
        internal MachineLearningServicesRunStatusChangedEventData(string experimentId, string experimentName, string runId, string runType, string runStatus)
        {
            Argument.AssertNotNull(experimentId, nameof(experimentId));
            Argument.AssertNotNull(experimentName, nameof(experimentName));
            Argument.AssertNotNull(runId, nameof(runId));
            Argument.AssertNotNull(runType, nameof(runType));
            Argument.AssertNotNull(runStatus, nameof(runStatus));

            ExperimentId = experimentId;
            ExperimentName = experimentName;
            RunId = runId;
            RunType = runType;
            RunStatus = runStatus;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicesRunStatusChangedEventData"/>. </summary>
        /// <param name="experimentId"> The ID of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="experimentName"> The name of the experiment that the Machine Learning Run belongs to. </param>
        /// <param name="runId"> The ID of the Machine Learning Run. </param>
        /// <param name="runType"> The Run Type of the Machine Learning Run. </param>
        /// <param name="runTags"> The tags of the Machine Learning Run. </param>
        /// <param name="runProperties"> The properties of the Machine Learning Run. </param>
        /// <param name="runStatus"> The status of the Machine Learning Run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningServicesRunStatusChangedEventData(string experimentId, string experimentName, string runId, string runType, object runTags, object runProperties, string runStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExperimentId = experimentId;
            ExperimentName = experimentName;
            RunId = runId;
            RunType = runType;
            RunTags = runTags;
            RunProperties = runProperties;
            RunStatus = runStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicesRunStatusChangedEventData"/> for deserialization. </summary>
        internal MachineLearningServicesRunStatusChangedEventData()
        {
        }

        /// <summary> The ID of the experiment that the Machine Learning Run belongs to. </summary>
        public string ExperimentId { get; }
        /// <summary> The name of the experiment that the Machine Learning Run belongs to. </summary>
        public string ExperimentName { get; }
        /// <summary> The ID of the Machine Learning Run. </summary>
        public string RunId { get; }
        /// <summary> The Run Type of the Machine Learning Run. </summary>
        public string RunType { get; }
        /// <summary> The status of the Machine Learning Run. </summary>
        public string RunStatus { get; }
    }
}
