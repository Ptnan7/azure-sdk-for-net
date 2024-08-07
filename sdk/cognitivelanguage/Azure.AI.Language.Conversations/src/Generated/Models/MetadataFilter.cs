// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Find QnAs that are associated with the given list of metadata. </summary>
    public partial class MetadataFilter
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

        /// <summary> Initializes a new instance of <see cref="MetadataFilter"/>. </summary>
        public MetadataFilter()
        {
            Metadata = new ChangeTrackingList<MetadataRecord>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataFilter"/>. </summary>
        /// <param name="metadata"> List of metadata. </param>
        /// <param name="logicalOperation"> Operation used to join metadata filters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetadataFilter(IList<MetadataRecord> metadata, LogicalOperationKind? logicalOperation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metadata = metadata;
            LogicalOperation = logicalOperation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of metadata. </summary>
        public IList<MetadataRecord> Metadata { get; }
        /// <summary> Operation used to join metadata filters. </summary>
        public LogicalOperationKind? LogicalOperation { get; set; }
    }
}
