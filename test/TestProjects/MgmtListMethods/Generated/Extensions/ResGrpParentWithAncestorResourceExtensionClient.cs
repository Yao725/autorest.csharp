// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtListMethods;

namespace MgmtListMethods.Mock
{
    /// <summary> A class to add extension methods to ResGrpParentWithAncestorResource. </summary>
    public partial class ResGrpParentWithAncestorResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _resGrpParentWithAncestorClientDiagnostics;
        private ResGrpParentWithAncestorsRestOperations _resGrpParentWithAncestorRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorResourceExtensionClient"/> class for mocking. </summary>
        protected ResGrpParentWithAncestorResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ResGrpParentWithAncestorClientDiagnostics => _resGrpParentWithAncestorClientDiagnostics ??= new ClientDiagnostics("MgmtListMethods.Mock", ResGrpParentWithAncestorResource.ResourceType.Namespace, Diagnostics);
        private ResGrpParentWithAncestorsRestOperations ResGrpParentWithAncestorRestClient => _resGrpParentWithAncestorRestClient ??= new ResGrpParentWithAncestorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResGrpParentWithAncestorResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestors_NonPageableListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResGrpParentWithAncestorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResGrpParentWithAncestorResource> GetResGrpParentWithAncestorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResGrpParentWithAncestorRestClient.CreateNonPageableListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ResGrpParentWithAncestorResource(Client, ResGrpParentWithAncestorData.DeserializeResGrpParentWithAncestorData(e)), ResGrpParentWithAncestorClientDiagnostics, Pipeline, "ResGrpParentWithAncestorResourceExtensionClient.GetResGrpParentWithAncestors", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestors_NonPageableListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResGrpParentWithAncestorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResGrpParentWithAncestorResource> GetResGrpParentWithAncestors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResGrpParentWithAncestorRestClient.CreateNonPageableListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new ResGrpParentWithAncestorResource(Client, ResGrpParentWithAncestorData.DeserializeResGrpParentWithAncestorData(e)), ResGrpParentWithAncestorClientDiagnostics, Pipeline, "ResGrpParentWithAncestorResourceExtensionClient.GetResGrpParentWithAncestors", "value", null, cancellationToken);
        }
    }
}
