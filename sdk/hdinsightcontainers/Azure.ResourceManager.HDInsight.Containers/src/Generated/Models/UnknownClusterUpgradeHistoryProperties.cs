// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Unknown version of ClusterUpgradeHistoryProperties. </summary>
    internal partial class UnknownClusterUpgradeHistoryProperties : ClusterUpgradeHistoryProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownClusterUpgradeHistoryProperties"/>. </summary>
        /// <param name="upgradeType"> Type of upgrade. </param>
        /// <param name="utcTime"> Time when created this upgrade history. </param>
        /// <param name="upgradeResult"> Result of this upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownClusterUpgradeHistoryProperties(ClusterUpgradeHistoryType upgradeType, string utcTime, ClusterUpgradeHistoryUpgradeResultType upgradeResult, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(upgradeType, utcTime, upgradeResult, serializedAdditionalRawData)
        {
            UpgradeType = upgradeType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownClusterUpgradeHistoryProperties"/> for deserialization. </summary>
        internal UnknownClusterUpgradeHistoryProperties()
        {
        }
    }
}
