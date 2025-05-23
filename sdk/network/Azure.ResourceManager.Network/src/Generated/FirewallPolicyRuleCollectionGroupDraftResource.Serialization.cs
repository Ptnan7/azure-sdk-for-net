// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class FirewallPolicyRuleCollectionGroupDraftResource : IJsonModel<FirewallPolicyRuleCollectionGroupDraftData>
    {
        private static FirewallPolicyRuleCollectionGroupDraftData s_dataDeserializationInstance;
        private static FirewallPolicyRuleCollectionGroupDraftData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FirewallPolicyRuleCollectionGroupDraftData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FirewallPolicyRuleCollectionGroupDraftData>)Data).Write(writer, options);

        FirewallPolicyRuleCollectionGroupDraftData IJsonModel<FirewallPolicyRuleCollectionGroupDraftData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FirewallPolicyRuleCollectionGroupDraftData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FirewallPolicyRuleCollectionGroupDraftData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FirewallPolicyRuleCollectionGroupDraftData>(Data, options, AzureResourceManagerNetworkContext.Default);

        FirewallPolicyRuleCollectionGroupDraftData IPersistableModel<FirewallPolicyRuleCollectionGroupDraftData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FirewallPolicyRuleCollectionGroupDraftData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<FirewallPolicyRuleCollectionGroupDraftData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FirewallPolicyRuleCollectionGroupDraftData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
