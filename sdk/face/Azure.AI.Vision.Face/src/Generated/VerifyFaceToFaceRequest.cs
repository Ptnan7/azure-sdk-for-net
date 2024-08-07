// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The VerifyFaceToFaceRequest. </summary>
    internal partial class VerifyFaceToFaceRequest
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

        /// <summary> Initializes a new instance of <see cref="VerifyFaceToFaceRequest"/>. </summary>
        /// <param name="faceId1"> The faceId of one face, come from "Detect". </param>
        /// <param name="faceId2"> The faceId of another face, come from "Detect". </param>
        internal VerifyFaceToFaceRequest(Guid faceId1, Guid faceId2)
        {
            FaceId1 = faceId1;
            FaceId2 = faceId2;
        }

        /// <summary> Initializes a new instance of <see cref="VerifyFaceToFaceRequest"/>. </summary>
        /// <param name="faceId1"> The faceId of one face, come from "Detect". </param>
        /// <param name="faceId2"> The faceId of another face, come from "Detect". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VerifyFaceToFaceRequest(Guid faceId1, Guid faceId2, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FaceId1 = faceId1;
            FaceId2 = faceId2;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VerifyFaceToFaceRequest"/> for deserialization. </summary>
        internal VerifyFaceToFaceRequest()
        {
        }

        /// <summary> The faceId of one face, come from "Detect". </summary>
        public Guid FaceId1 { get; }
        /// <summary> The faceId of another face, come from "Detect". </summary>
        public Guid FaceId2 { get; }
    }
}
