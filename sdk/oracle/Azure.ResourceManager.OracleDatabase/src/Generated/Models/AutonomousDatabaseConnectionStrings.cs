// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Connection strings to connect to an Oracle Autonomous Database. </summary>
    public partial class AutonomousDatabaseConnectionStrings
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

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseConnectionStrings"/>. </summary>
        internal AutonomousDatabaseConnectionStrings()
        {
            Profiles = new ChangeTrackingList<AutonomousDatabaseConnectionStringProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseConnectionStrings"/>. </summary>
        /// <param name="allConnectionStrings"> Returns all connection strings that can be used to connect to the Autonomous Database. </param>
        /// <param name="dedicated"> The database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements. </param>
        /// <param name="high"> The High database service provides the highest level of resources to each SQL statement resulting in the highest performance, but supports the fewest number of concurrent SQL statements. </param>
        /// <param name="low"> The Low database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements. </param>
        /// <param name="medium"> The Medium database service provides a lower level of resources to each SQL statement potentially resulting a lower level of performance, but supports more concurrent SQL statements. </param>
        /// <param name="profiles"> A list of connection string profiles to allow clients to group, filter and select connection string values based on structured metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutonomousDatabaseConnectionStrings(AutonomousDatabaseConnectionStringType allConnectionStrings, string dedicated, string high, string low, string medium, IReadOnlyList<AutonomousDatabaseConnectionStringProfile> profiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllConnectionStrings = allConnectionStrings;
            Dedicated = dedicated;
            High = high;
            Low = low;
            Medium = medium;
            Profiles = profiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Returns all connection strings that can be used to connect to the Autonomous Database. </summary>
        public AutonomousDatabaseConnectionStringType AllConnectionStrings { get; }
        /// <summary> The database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements. </summary>
        public string Dedicated { get; }
        /// <summary> The High database service provides the highest level of resources to each SQL statement resulting in the highest performance, but supports the fewest number of concurrent SQL statements. </summary>
        public string High { get; }
        /// <summary> The Low database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements. </summary>
        public string Low { get; }
        /// <summary> The Medium database service provides a lower level of resources to each SQL statement potentially resulting a lower level of performance, but supports more concurrent SQL statements. </summary>
        public string Medium { get; }
        /// <summary> A list of connection string profiles to allow clients to group, filter and select connection string values based on structured metadata. </summary>
        public IReadOnlyList<AutonomousDatabaseConnectionStringProfile> Profiles { get; }
    }
}
