// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Additional Managed CCF properties. </summary>
    public partial class ManagedCcfProperties
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

        /// <summary> Initializes a new instance of <see cref="ManagedCcfProperties"/>. </summary>
        public ManagedCcfProperties()
        {
            MemberIdentityCertificates = new ChangeTrackingList<ConfidentialLedgerMemberIdentityCertificate>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCcfProperties"/>. </summary>
        /// <param name="appName"> Unique name for the Managed CCF. </param>
        /// <param name="appUri"> Endpoint for calling Managed CCF Service. </param>
        /// <param name="identityServiceUri"> Endpoint for accessing network identity. </param>
        /// <param name="memberIdentityCertificates"> List of member identity certificates for  Managed CCF. </param>
        /// <param name="deploymentType"> Deployment Type of Managed CCF. </param>
        /// <param name="runningState"> Object representing RunningState for Managed CCF. </param>
        /// <param name="provisioningState"> Provisioning state of Managed CCF Resource. </param>
        /// <param name="nodeCount"> Number of CCF nodes in the Managed CCF. </param>
        /// <param name="enclavePlatform"> Enclave platform of Managed CCF. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedCcfProperties(string appName, Uri appUri, Uri identityServiceUri, IList<ConfidentialLedgerMemberIdentityCertificate> memberIdentityCertificates, ConfidentialLedgerDeploymentType deploymentType, ConfidentialLedgerRunningState? runningState, ConfidentialLedgerProvisioningState? provisioningState, int? nodeCount, ConfidentialLedgerEnclavePlatform? enclavePlatform, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppName = appName;
            AppUri = appUri;
            IdentityServiceUri = identityServiceUri;
            MemberIdentityCertificates = memberIdentityCertificates;
            DeploymentType = deploymentType;
            RunningState = runningState;
            ProvisioningState = provisioningState;
            NodeCount = nodeCount;
            EnclavePlatform = enclavePlatform;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique name for the Managed CCF. </summary>
        public string AppName { get; }
        /// <summary> Endpoint for calling Managed CCF Service. </summary>
        public Uri AppUri { get; }
        /// <summary> Endpoint for accessing network identity. </summary>
        public Uri IdentityServiceUri { get; }
        /// <summary> List of member identity certificates for  Managed CCF. </summary>
        public IList<ConfidentialLedgerMemberIdentityCertificate> MemberIdentityCertificates { get; }
        /// <summary> Deployment Type of Managed CCF. </summary>
        public ConfidentialLedgerDeploymentType DeploymentType { get; set; }
        /// <summary> Object representing RunningState for Managed CCF. </summary>
        public ConfidentialLedgerRunningState? RunningState { get; set; }
        /// <summary> Provisioning state of Managed CCF Resource. </summary>
        public ConfidentialLedgerProvisioningState? ProvisioningState { get; }
        /// <summary> Number of CCF nodes in the Managed CCF. </summary>
        public int? NodeCount { get; set; }
        /// <summary> Enclave platform of Managed CCF. </summary>
        public ConfidentialLedgerEnclavePlatform? EnclavePlatform { get; set; }
    }
}
