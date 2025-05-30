// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotDiagnostic along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteSlotDiagnosticResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteSlotDiagnosticResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource"/> using the GetSiteSlotDiagnostic method.
    /// </summary>
    public partial class SiteSlotDiagnosticResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotDiagnosticResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="siteName"> The siteName. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="diagnosticCategory"> The diagnosticCategory. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDiagnosticsRestClient;
        private readonly DiagnosticCategoryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/diagnostics";

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticResource"/> class for mocking. </summary>
        protected SiteSlotDiagnosticResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotDiagnosticResource(ArmClient client, DiagnosticCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotDiagnosticResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotDiagnosticDiagnosticsApiVersion);
            _siteSlotDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticCategoryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteSlotDiagnosticAnalysisResources in the SiteSlotDiagnostic. </summary>
        /// <returns> An object representing collection of SiteSlotDiagnosticAnalysisResources and their operations over a SiteSlotDiagnosticAnalysisResource. </returns>
        public virtual SiteSlotDiagnosticAnalysisCollection GetSiteSlotDiagnosticAnalyses()
        {
            return GetCachedClient(client => new SiteSlotDiagnosticAnalysisCollection(client, Id));
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteSlotDiagnosticAnalysisResource>> GetSiteSlotDiagnosticAnalysisAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotDiagnosticAnalyses().GetAsync(analysisName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticAnalysisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteSlotDiagnosticAnalysisResource> GetSiteSlotDiagnosticAnalysis(string analysisName, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotDiagnosticAnalyses().Get(analysisName, cancellationToken);
        }

        /// <summary> Gets a collection of SiteSlotDiagnosticDetectorResources in the SiteSlotDiagnostic. </summary>
        /// <returns> An object representing collection of SiteSlotDiagnosticDetectorResources and their operations over a SiteSlotDiagnosticDetectorResource. </returns>
        public virtual SiteSlotDiagnosticDetectorCollection GetSiteSlotDiagnosticDetectors()
        {
            return GetCachedClient(client => new SiteSlotDiagnosticDetectorCollection(client, Id));
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteSlotDiagnosticDetectorResource>> GetSiteSlotDiagnosticDetectorAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotDiagnosticDetectors().GetAsync(detectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetectorSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteSlotDiagnosticDetectorResource> GetSiteSlotDiagnosticDetector(string detectorName, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotDiagnosticDetectors().Get(detectorName, cancellationToken);
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotDiagnosticResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotDiagnosticResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotDiagnosticResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
