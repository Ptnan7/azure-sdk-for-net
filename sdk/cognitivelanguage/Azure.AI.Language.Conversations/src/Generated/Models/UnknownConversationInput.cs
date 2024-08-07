// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Unknown version of ConversationInput. </summary>
    internal partial class UnknownConversationInput : ConversationInput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConversationInput"/>. </summary>
        /// <param name="id"> Unique identifier for the conversation. </param>
        /// <param name="language"> Language of the conversation item in BCP-47 format. </param>
        /// <param name="modality"> modality. </param>
        /// <param name="domain"> domain. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownConversationInput(string id, string language, InputModality modality, ConversationDomain? domain, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, language, modality, domain, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownConversationInput"/> for deserialization. </summary>
        internal UnknownConversationInput()
        {
        }
    }
}
