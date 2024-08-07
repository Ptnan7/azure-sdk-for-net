// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The result from PII detection and redaction operation for each conversation. </summary>
    public partial class ConversationPiiItemResult
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

        /// <summary> Initializes a new instance of <see cref="ConversationPiiItemResult"/>. </summary>
        /// <param name="id"> Id of the result. </param>
        /// <param name="redactedContent"> Transcript content response that the service generates, with all necessary personally identifiable information redacted. </param>
        /// <param name="entities"> Array of Entities. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="redactedContent"/> or <paramref name="entities"/> is null. </exception>
        internal ConversationPiiItemResult(string id, RedactedTranscriptContent redactedContent, IEnumerable<NamedEntity> entities)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(redactedContent, nameof(redactedContent));
            Argument.AssertNotNull(entities, nameof(entities));

            Id = id;
            RedactedContent = redactedContent;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiItemResult"/>. </summary>
        /// <param name="id"> Id of the result. </param>
        /// <param name="redactedContent"> Transcript content response that the service generates, with all necessary personally identifiable information redacted. </param>
        /// <param name="entities"> Array of Entities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationPiiItemResult(string id, RedactedTranscriptContent redactedContent, IReadOnlyList<NamedEntity> entities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            RedactedContent = redactedContent;
            Entities = entities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiItemResult"/> for deserialization. </summary>
        internal ConversationPiiItemResult()
        {
        }

        /// <summary> Id of the result. </summary>
        public string Id { get; }
        /// <summary> Transcript content response that the service generates, with all necessary personally identifiable information redacted. </summary>
        public RedactedTranscriptContent RedactedContent { get; }
        /// <summary> Array of Entities. </summary>
        public IReadOnlyList<NamedEntity> Entities { get; }
    }
}
