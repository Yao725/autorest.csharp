// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Mock
{
    /// <summary> A class to add extension methods to DedicatedHostGroupResource. </summary>
    public partial class DedicatedHostGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dedicatedHostGroupClientDiagnostics;
        private DedicatedHostGroupsRestOperations _dedicatedHostGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupResourceExtensionClient"/> class for mocking. </summary>
        protected DedicatedHostGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DedicatedHostGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DedicatedHostGroupClientDiagnostics => _dedicatedHostGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Sample.Mock", DedicatedHostGroupResource.ResourceType.Namespace, Diagnostics);
        private DedicatedHostGroupsRestOperations DedicatedHostGroupRestClient => _dedicatedHostGroupRestClient ??= new DedicatedHostGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DedicatedHostGroupResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the dedicated host groups in the subscription. Use the nextLink property in the response to get the next page of dedicated host groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/hostGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHostGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHostGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHostGroupResource> GetDedicatedHostGroupsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedHostGroupRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DedicatedHostGroupRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DedicatedHostGroupResource(Client, DedicatedHostGroupData.DeserializeDedicatedHostGroupData(e)), DedicatedHostGroupClientDiagnostics, Pipeline, "DedicatedHostGroupResourceExtensionClient.GetDedicatedHostGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the dedicated host groups in the subscription. Use the nextLink property in the response to get the next page of dedicated host groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/hostGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHostGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHostGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHostGroupResource> GetDedicatedHostGroups(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DedicatedHostGroupRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DedicatedHostGroupRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DedicatedHostGroupResource(Client, DedicatedHostGroupData.DeserializeDedicatedHostGroupData(e)), DedicatedHostGroupClientDiagnostics, Pipeline, "DedicatedHostGroupResourceExtensionClient.GetDedicatedHostGroups", "value", "nextLink", cancellationToken);
        }
    }
}
