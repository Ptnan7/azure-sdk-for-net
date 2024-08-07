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
    public partial class ConversationPiiResults
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

        /// <summary> Initializes a new instance of <see cref="ConversationPiiResults"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="conversations"> array of conversations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="modelVersion"/> or <paramref name="conversations"/> is null. </exception>
        internal ConversationPiiResults(IEnumerable<DocumentError> errors, string modelVersion, IEnumerable<ConversationalPiiResultWithResultBase> conversations)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));
            Argument.AssertNotNull(conversations, nameof(conversations));

            Errors = errors.ToList();
            ModelVersion = modelVersion;
            Conversations = conversations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiResults"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> statistics. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="conversations"> array of conversations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationPiiResults(IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string modelVersion, IReadOnlyList<ConversationalPiiResultWithResultBase> conversations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
            Conversations = conversations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationPiiResults"/> for deserialization. </summary>
        internal ConversationPiiResults()
        {
        }

        /// <summary> Errors by document id. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> statistics. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> This field indicates which model is used for scoring. </summary>
        public string ModelVersion { get; }
        /// <summary> array of conversations. </summary>
        public IReadOnlyList<ConversationalPiiResultWithResultBase> Conversations { get; }
    }
}
