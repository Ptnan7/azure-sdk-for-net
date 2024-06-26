// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> The status of the blueprint. This field is readonly. </summary>
    public partial class BlueprintStatus : BlueprintResourceStatusBase
    {
        /// <summary> Initializes a new instance of <see cref="BlueprintStatus"/>. </summary>
        internal BlueprintStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlueprintStatus"/>. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlueprintStatus(DateTimeOffset? timeCreated, DateTimeOffset? lastModified, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(timeCreated, lastModified, serializedAdditionalRawData)
        {
        }
    }
}
