// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The MediaStreamingUpdate. </summary>
    public partial class MediaStreamingUpdate
    {
        /// <summary> Initializes a new instance of <see cref="MediaStreamingUpdate"/>. </summary>
        internal MediaStreamingUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaStreamingUpdate"/>. </summary>
        /// <param name="contentType"></param>
        /// <param name="mediaStreamingStatus"></param>
        /// <param name="mediaStreamingStatusDetails"></param>
        internal MediaStreamingUpdate(string contentType, MediaStreamingStatus? mediaStreamingStatus, MediaStreamingStatusDetails? mediaStreamingStatusDetails)
        {
            ContentType = contentType;
            MediaStreamingStatus = mediaStreamingStatus;
            MediaStreamingStatusDetails = mediaStreamingStatusDetails;
        }

        /// <summary> Gets the content type. </summary>
        public string ContentType { get; }
        /// <summary> Gets the media streaming status. </summary>
        public MediaStreamingStatus? MediaStreamingStatus { get; }
        /// <summary> Gets the media streaming status details. </summary>
        public MediaStreamingStatusDetails? MediaStreamingStatusDetails { get; }
    }
}
