// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Defines the parameters for the origin group override action.
    /// Serialized Name: OriginGroupOverrideActionParameters
    /// </summary>
    public partial class OriginGroupOverrideActionProperties : DeliveryRuleActionProperties
    {
        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideActionProperties"/>. </summary>
        /// <param name="originGroup">
        /// defines the OriginGroup that would override the DefaultOriginGroup.
        /// Serialized Name: OriginGroupOverrideActionParameters.originGroup
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroup"/> is null. </exception>
        public OriginGroupOverrideActionProperties(WritableSubResource originGroup)
        {
            Argument.AssertNotNull(originGroup, nameof(originGroup));

            OriginGroup = originGroup;
            TypeName = DeliveryRuleActionParametersType.DeliveryRuleOriginGroupOverrideActionParameters;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideActionProperties"/>. </summary>
        /// <param name="typeName"> Serialized Name: DeliveryRuleActionParameters.typeName. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="originGroup">
        /// defines the OriginGroup that would override the DefaultOriginGroup.
        /// Serialized Name: OriginGroupOverrideActionParameters.originGroup
        /// </param>
        internal OriginGroupOverrideActionProperties(DeliveryRuleActionParametersType typeName, IDictionary<string, BinaryData> serializedAdditionalRawData, WritableSubResource originGroup) : base(typeName, serializedAdditionalRawData)
        {
            OriginGroup = originGroup;
            TypeName = typeName;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideActionProperties"/> for deserialization. </summary>
        internal OriginGroupOverrideActionProperties()
        {
        }

        /// <summary>
        /// defines the OriginGroup that would override the DefaultOriginGroup.
        /// Serialized Name: OriginGroupOverrideActionParameters.originGroup
        /// </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }
    }
}
