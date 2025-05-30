// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of calling event participant user. </summary>
    public partial class AcsCallParticipantProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsCallParticipantProperties"/>. </summary>
        internal AcsCallParticipantProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsCallParticipantProperties"/>. </summary>
        /// <param name="communicationIdentifier"> The communication identifier of the call ended by. </param>
        /// <param name="role"> The role of participant user. </param>
        internal AcsCallParticipantProperties(CommunicationIdentifierModel communicationIdentifier, AcsCallParticipantKind? role)
        {
            CommunicationIdentifier = communicationIdentifier;
            Role = role;
        }

        /// <summary> The communication identifier of the call ended by. </summary>
        public CommunicationIdentifierModel CommunicationIdentifier { get; }
        /// <summary> The role of participant user. </summary>
        public AcsCallParticipantKind? Role { get; }
    }
}
