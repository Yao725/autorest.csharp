// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtMockAndSample;

namespace MgmtMockAndSample.Mock
{
    /// <summary> A class to add extension methods to FirewallPolicyResource. </summary>
    public partial class MgmtMockAndSampleFirewallPolicyResourceExtension : ArmResource
    {
        private ClientDiagnostics _firewallPolicyClientDiagnostics;
        private FirewallPoliciesRestOperations _firewallPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtMockAndSampleFirewallPolicyResourceExtension"/> class for mocking. </summary>
        protected MgmtMockAndSampleFirewallPolicyResourceExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtMockAndSampleFirewallPolicyResourceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtMockAndSampleFirewallPolicyResourceExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FirewallPolicyClientDiagnostics => _firewallPolicyClientDiagnostics ??= new ClientDiagnostics("MgmtMockAndSample", FirewallPolicyResource.ResourceType.Namespace, Diagnostics);
        private FirewallPoliciesRestOperations FirewallPolicyRestClient => _firewallPolicyRestClient ??= new FirewallPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FirewallPolicyResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all the Firewall Policies in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/firewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicies_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirewallPolicyResource> GetFirewallPoliciesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FirewallPolicyRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FirewallPolicyRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FirewallPolicyResource(Client, FirewallPolicyData.DeserializeFirewallPolicyData(e)), FirewallPolicyClientDiagnostics, Pipeline, "MgmtMockAndSampleFirewallPolicyResourceExtension.GetFirewallPolicies", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Firewall Policies in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/firewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicies_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirewallPolicyResource> GetFirewallPolicies(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FirewallPolicyRestClient.CreateListAllRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FirewallPolicyRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FirewallPolicyResource(Client, FirewallPolicyData.DeserializeFirewallPolicyData(e)), FirewallPolicyClientDiagnostics, Pipeline, "MgmtMockAndSampleFirewallPolicyResourceExtension.GetFirewallPolicies", "value", "nextLink", cancellationToken);
        }
    }
}
