// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Dataflow BuiltIn Transformation filter properties. </summary>
    public partial class DataflowBuiltInTransformationFilter
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

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationFilter"/>. </summary>
        /// <param name="inputs"> List of fields for filtering in JSON path expression. </param>
        /// <param name="expression"> Condition to filter data. Can reference input fields with {n} where n is the index of the input field starting from 1. Example: $1 &lt; 0 || $1 &gt; $2 (Assuming inputs section $1 and $2 are provided). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="expression"/> is null. </exception>
        public DataflowBuiltInTransformationFilter(IEnumerable<string> inputs, string expression)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(expression, nameof(expression));

            Inputs = inputs.ToList();
            Expression = expression;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationFilter"/>. </summary>
        /// <param name="type"> The type of dataflow operation. </param>
        /// <param name="description"> A user provided optional description of the filter. </param>
        /// <param name="inputs"> List of fields for filtering in JSON path expression. </param>
        /// <param name="expression"> Condition to filter data. Can reference input fields with {n} where n is the index of the input field starting from 1. Example: $1 &lt; 0 || $1 &gt; $2 (Assuming inputs section $1 and $2 are provided). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowBuiltInTransformationFilter(DataflowFilterType? type, string description, IList<string> inputs, string expression, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Description = description;
            Inputs = inputs;
            Expression = expression;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationFilter"/> for deserialization. </summary>
        internal DataflowBuiltInTransformationFilter()
        {
        }

        /// <summary> The type of dataflow operation. </summary>
        public DataflowFilterType? Type { get; set; }
        /// <summary> A user provided optional description of the filter. </summary>
        public string Description { get; set; }
        /// <summary> List of fields for filtering in JSON path expression. </summary>
        public IList<string> Inputs { get; }
        /// <summary> Condition to filter data. Can reference input fields with {n} where n is the index of the input field starting from 1. Example: $1 &lt; 0 || $1 &gt; $2 (Assuming inputs section $1 and $2 are provided). </summary>
        public string Expression { get; set; }
    }
}
