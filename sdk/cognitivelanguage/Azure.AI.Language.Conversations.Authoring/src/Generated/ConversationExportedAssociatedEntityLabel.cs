// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents an associated entity label for an intent. </summary>
    public partial class ConversationExportedAssociatedEntityLabel
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

        /// <summary> Initializes a new instance of <see cref="ConversationExportedAssociatedEntityLabel"/>. </summary>
        /// <param name="category"> The category of the entity label. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="category"/> is null. </exception>
        public ConversationExportedAssociatedEntityLabel(string category)
        {
            Argument.AssertNotNull(category, nameof(category));

            Category = category;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationExportedAssociatedEntityLabel"/>. </summary>
        /// <param name="category"> The category of the entity label. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationExportedAssociatedEntityLabel(string category, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationExportedAssociatedEntityLabel"/> for deserialization. </summary>
        internal ConversationExportedAssociatedEntityLabel()
        {
        }

        /// <summary> The category of the entity label. </summary>
        public string Category { get; }
    }
}
