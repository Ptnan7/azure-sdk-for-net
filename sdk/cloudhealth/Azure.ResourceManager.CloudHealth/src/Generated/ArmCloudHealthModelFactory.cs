// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CloudHealth.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmCloudHealthModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelData"/> instance for mocking. </returns>
        public static HealthModelData HealthModelData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HealthModelProperties properties = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HealthModelData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelProperties"/>. </summary>
        /// <param name="dataplaneEndpoint"> The data plane endpoint for interacting with health data. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="discovery"> Configure to automatically discover entities from a given scope, such as a Service Group. The discovered entities will be linked to the root entity of the health model. </param>
        /// <returns> A new <see cref="Models.HealthModelProperties"/> instance for mocking. </returns>
        public static HealthModelProperties HealthModelProperties(string dataplaneEndpoint = null, HealthModelProvisioningState? provisioningState = null, ModelDiscoverySettings discovery = null)
        {
            return new HealthModelProperties(dataplaneEndpoint, provisioningState, discovery, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelSignalDefinitionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// The resource-specific properties for this resource.
        /// Please note <see cref="Models.HealthModelSignalDefinitionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.ResourceMetricSignalDefinitionProperties"/>, <see cref="Models.LogAnalyticsQuerySignalDefinitionProperties"/> and <see cref="Models.PrometheusMetricsSignalDefinitionProperties"/>.
        /// </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelSignalDefinitionData"/> instance for mocking. </returns>
        public static HealthModelSignalDefinitionData HealthModelSignalDefinitionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthModelSignalDefinitionProperties properties = null)
        {
            return new HealthModelSignalDefinitionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelSignalDefinitionProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="signalKind"> Kind of the signal definition. </param>
        /// <param name="refreshInterval"> Interval in which the signal is being evaluated. Defaults to PT1M (1 minute). </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="dataUnit"> Unit of the signal result (e.g. Bytes, MilliSeconds, Percent, Count)). </param>
        /// <param name="evaluationRules"> Evaluation rules for the signal definition. </param>
        /// <param name="deletedOn"> Date when the signal definition was (soft-)deleted. </param>
        /// <returns> A new <see cref="Models.HealthModelSignalDefinitionProperties"/> instance for mocking. </returns>
        public static HealthModelSignalDefinitionProperties HealthModelSignalDefinitionProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string signalKind = null, EntitySignalRefreshInterval? refreshInterval = null, IDictionary<string, string> labels = null, string dataUnit = null, EntitySignalEvaluationRule evaluationRules = null, DateTimeOffset? deletedOn = null)
        {
            labels ??= new Dictionary<string, string>();

            return new UnknownHealthModelSignalDefinitionProperties(
                provisioningState,
                displayName,
                signalKind == null ? default : new EntitySignalKind(signalKind),
                refreshInterval,
                labels,
                dataUnit,
                evaluationRules,
                deletedOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceMetricSignalDefinitionProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="refreshInterval"> Interval in which the signal is being evaluated. Defaults to PT1M (1 minute). </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="dataUnit"> Unit of the signal result (e.g. Bytes, MilliSeconds, Percent, Count)). </param>
        /// <param name="evaluationRules"> Evaluation rules for the signal definition. </param>
        /// <param name="deletedOn"> Date when the signal definition was (soft-)deleted. </param>
        /// <param name="metricNamespace"> Metric namespace. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="timeGrain"> Time range of signal. ISO duration format like PT10M. </param>
        /// <param name="aggregationType"> Type of aggregation to apply to the metric. </param>
        /// <param name="dimension"> Optional: Dimension to split by. </param>
        /// <param name="dimensionFilter"> Optional: Dimension filter to apply to the dimension. Must only be set if also Dimension is set. </param>
        /// <returns> A new <see cref="Models.ResourceMetricSignalDefinitionProperties"/> instance for mocking. </returns>
        public static ResourceMetricSignalDefinitionProperties ResourceMetricSignalDefinitionProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, EntitySignalRefreshInterval? refreshInterval = null, IDictionary<string, string> labels = null, string dataUnit = null, EntitySignalEvaluationRule evaluationRules = null, DateTimeOffset? deletedOn = null, string metricNamespace = null, string metricName = null, string timeGrain = null, MetricAggregationType aggregationType = default, string dimension = null, string dimensionFilter = null)
        {
            labels ??= new Dictionary<string, string>();

            return new ResourceMetricSignalDefinitionProperties(
                provisioningState,
                displayName,
                EntitySignalKind.AzureResourceMetric,
                refreshInterval,
                labels,
                dataUnit,
                evaluationRules,
                deletedOn,
                serializedAdditionalRawData: null,
                metricNamespace,
                metricName,
                timeGrain,
                aggregationType,
                dimension,
                dimensionFilter);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LogAnalyticsQuerySignalDefinitionProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="refreshInterval"> Interval in which the signal is being evaluated. Defaults to PT1M (1 minute). </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="dataUnit"> Unit of the signal result (e.g. Bytes, MilliSeconds, Percent, Count)). </param>
        /// <param name="evaluationRules"> Evaluation rules for the signal definition. </param>
        /// <param name="deletedOn"> Date when the signal definition was (soft-)deleted. </param>
        /// <param name="queryText"> Query text in KQL syntax. </param>
        /// <param name="timeGrain"> Time range of signal. ISO duration format like PT10M. If not specified, the KQL query must define a time range. </param>
        /// <param name="valueColumnName"> Name of the column in the result set to evaluate against the thresholds. Defaults to the first column in the result set if not specified. The column must be numeric. </param>
        /// <returns> A new <see cref="Models.LogAnalyticsQuerySignalDefinitionProperties"/> instance for mocking. </returns>
        public static LogAnalyticsQuerySignalDefinitionProperties LogAnalyticsQuerySignalDefinitionProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, EntitySignalRefreshInterval? refreshInterval = null, IDictionary<string, string> labels = null, string dataUnit = null, EntitySignalEvaluationRule evaluationRules = null, DateTimeOffset? deletedOn = null, string queryText = null, string timeGrain = null, string valueColumnName = null)
        {
            labels ??= new Dictionary<string, string>();

            return new LogAnalyticsQuerySignalDefinitionProperties(
                provisioningState,
                displayName,
                EntitySignalKind.LogAnalyticsQuery,
                refreshInterval,
                labels,
                dataUnit,
                evaluationRules,
                deletedOn,
                serializedAdditionalRawData: null,
                queryText,
                timeGrain,
                valueColumnName);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PrometheusMetricsSignalDefinitionProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="refreshInterval"> Interval in which the signal is being evaluated. Defaults to PT1M (1 minute). </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="dataUnit"> Unit of the signal result (e.g. Bytes, MilliSeconds, Percent, Count)). </param>
        /// <param name="evaluationRules"> Evaluation rules for the signal definition. </param>
        /// <param name="deletedOn"> Date when the signal definition was (soft-)deleted. </param>
        /// <param name="queryText"> Query text in PromQL syntax. </param>
        /// <param name="timeGrain"> Time range of signal. ISO duration format like PT10M. </param>
        /// <returns> A new <see cref="Models.PrometheusMetricsSignalDefinitionProperties"/> instance for mocking. </returns>
        public static PrometheusMetricsSignalDefinitionProperties PrometheusMetricsSignalDefinitionProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, EntitySignalRefreshInterval? refreshInterval = null, IDictionary<string, string> labels = null, string dataUnit = null, EntitySignalEvaluationRule evaluationRules = null, DateTimeOffset? deletedOn = null, string queryText = null, string timeGrain = null)
        {
            labels ??= new Dictionary<string, string>();

            return new PrometheusMetricsSignalDefinitionProperties(
                provisioningState,
                displayName,
                EntitySignalKind.PrometheusMetricsQuery,
                refreshInterval,
                labels,
                dataUnit,
                evaluationRules,
                deletedOn,
                serializedAdditionalRawData: null,
                queryText,
                timeGrain);
        }

        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelAuthenticationSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// The resource-specific properties for this resource.
        /// Please note <see cref="Models.HealthModelAuthenticationSettingProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.ManagedIdentityAuthenticationSettingProperties"/>.
        /// </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelAuthenticationSettingData"/> instance for mocking. </returns>
        public static HealthModelAuthenticationSettingData HealthModelAuthenticationSettingData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthModelAuthenticationSettingProperties properties = null)
        {
            return new HealthModelAuthenticationSettingData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelAuthenticationSettingProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="authenticationKind"> Kind of the authentication setting. </param>
        /// <returns> A new <see cref="Models.HealthModelAuthenticationSettingProperties"/> instance for mocking. </returns>
        public static HealthModelAuthenticationSettingProperties HealthModelAuthenticationSettingProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string authenticationKind = null)
        {
            return new UnknownHealthModelAuthenticationSettingProperties(provisioningState, displayName, authenticationKind == null ? default : new HealthModelAuthenticationKind(authenticationKind), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedIdentityAuthenticationSettingProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="managedIdentityName"> Name of the managed identity to use. Either 'SystemAssigned' or the resourceId of a user-assigned identity. </param>
        /// <returns> A new <see cref="Models.ManagedIdentityAuthenticationSettingProperties"/> instance for mocking. </returns>
        public static ManagedIdentityAuthenticationSettingProperties ManagedIdentityAuthenticationSettingProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string managedIdentityName = null)
        {
            return new ManagedIdentityAuthenticationSettingProperties(provisioningState, displayName, HealthModelAuthenticationKind.ManagedIdentity, serializedAdditionalRawData: null, managedIdentityName);
        }

        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelEntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelEntityData"/> instance for mocking. </returns>
        public static HealthModelEntityData HealthModelEntityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthModelEntityProperties properties = null)
        {
            return new HealthModelEntityData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelEntityProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="kind"> Entity kind. </param>
        /// <param name="canvasPosition"> Positioning of the entity on the model canvas. </param>
        /// <param name="icon"> Visual icon definition. If not set, a default icon is used. </param>
        /// <param name="healthObjective"> Health objective as a percentage of time the entity should be healthy. </param>
        /// <param name="impact"> Impact of the entity in health state propagation. </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="signals"> Signal groups which are assigned to this entity. </param>
        /// <param name="discoveredBy"> Discovered by which discovery rule. If set, the entity cannot be deleted manually. </param>
        /// <param name="deletedOn"> Date when the entity was (soft-)deleted. </param>
        /// <param name="healthState"> Health state of this entity. </param>
        /// <param name="alerts"> Alert configuration for this entity. </param>
        /// <returns> A new <see cref="Models.HealthModelEntityProperties"/> instance for mocking. </returns>
        public static HealthModelEntityProperties HealthModelEntityProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string kind = null, EntityCoordinates canvasPosition = null, EntityIcon icon = null, float? healthObjective = null, EntityImpact? impact = null, IDictionary<string, string> labels = null, EntitySignalGroup signals = null, string discoveredBy = null, DateTimeOffset? deletedOn = null, EntityHealthState? healthState = null, EntityAlerts alerts = null)
        {
            labels ??= new Dictionary<string, string>();

            return new HealthModelEntityProperties(
                provisioningState,
                displayName,
                kind,
                canvasPosition,
                icon,
                healthObjective,
                impact,
                labels,
                signals,
                discoveredBy,
                deletedOn,
                healthState,
                alerts,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelRelationshipData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelRelationshipData"/> instance for mocking. </returns>
        public static HealthModelRelationshipData HealthModelRelationshipData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthModelRelationshipProperties properties = null)
        {
            return new HealthModelRelationshipData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelRelationshipProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="parentEntityName"> Resource name of the parent entity. </param>
        /// <param name="childEntityName"> Resource name of the child entity. </param>
        /// <param name="labels"> Optional set of labels (key-value pairs). </param>
        /// <param name="discoveredBy"> Discovered by which discovery rule. If set, the relationship cannot be deleted manually. </param>
        /// <param name="deletedOn"> Date when the relationship was (soft-)deleted. </param>
        /// <returns> A new <see cref="Models.HealthModelRelationshipProperties"/> instance for mocking. </returns>
        public static HealthModelRelationshipProperties HealthModelRelationshipProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string parentEntityName = null, string childEntityName = null, IDictionary<string, string> labels = null, string discoveredBy = null, DateTimeOffset? deletedOn = null)
        {
            labels ??= new Dictionary<string, string>();

            return new HealthModelRelationshipProperties(
                provisioningState,
                displayName,
                parentEntityName,
                childEntityName,
                labels,
                discoveredBy,
                deletedOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CloudHealth.HealthModelDiscoveryRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="CloudHealth.HealthModelDiscoveryRuleData"/> instance for mocking. </returns>
        public static HealthModelDiscoveryRuleData HealthModelDiscoveryRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HealthModelDiscoveryRuleProperties properties = null)
        {
            return new HealthModelDiscoveryRuleData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HealthModelDiscoveryRuleProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="resourceGraphQuery"> Azure Resource Graph query text in KQL syntax. The query must return at least a column named 'id' which contains the resource ID of the discovered resources. </param>
        /// <param name="authenticationSetting"> Reference to the name of the authentication setting which is used for querying Azure Resource Graph. The same authentication setting will also be assigned to any discovered entities. </param>
        /// <param name="discoverRelationships"> Whether to create relationships between the discovered entities based on a set of built-in rules. These relationships cannot be manually deleted. </param>
        /// <param name="addRecommendedSignals"> Whether to add all recommended signals to the discovered entities. </param>
        /// <param name="deletedOn"> Date when the discovery rule was (soft-)deleted. </param>
        /// <param name="errorMessage"> Error message if the last discovery operation failed. </param>
        /// <param name="numberOfDiscoveredEntities"> Number of discovered entities in the last discovery operation. </param>
        /// <param name="entityName"> Name of the entity which represents the discovery rule. Note: It might take a few minutes after creating the discovery rule until the entity is created. </param>
        /// <returns> A new <see cref="Models.HealthModelDiscoveryRuleProperties"/> instance for mocking. </returns>
        public static HealthModelDiscoveryRuleProperties HealthModelDiscoveryRuleProperties(HealthModelProvisioningState? provisioningState = null, string displayName = null, string resourceGraphQuery = null, string authenticationSetting = null, DiscoveryRuleRelationshipDiscoveryBehavior discoverRelationships = default, DiscoveryRuleRecommendedSignalsBehavior addRecommendedSignals = default, DateTimeOffset? deletedOn = null, string errorMessage = null, int? numberOfDiscoveredEntities = null, string entityName = null)
        {
            return new HealthModelDiscoveryRuleProperties(
                provisioningState,
                displayName,
                resourceGraphQuery,
                authenticationSetting,
                discoverRelationships,
                addRecommendedSignals,
                deletedOn,
                errorMessage,
                numberOfDiscoveredEntities,
                entityName,
                serializedAdditionalRawData: null);
        }
    }
}
