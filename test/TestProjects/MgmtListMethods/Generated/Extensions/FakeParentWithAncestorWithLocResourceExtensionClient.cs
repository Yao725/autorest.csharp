// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtListMethods;

namespace MgmtListMethods.Mock
{
    /// <summary> A class to add extension methods to FakeParentWithAncestorWithLocResource. </summary>
    public partial class FakeParentWithAncestorWithLocResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _fakeParentWithAncestorWithLocClientDiagnostics;
        private FakeParentWithAncestorWithLocsRestOperations _fakeParentWithAncestorWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithLocResourceExtensionClient"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithLocResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithLocResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithLocResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FakeParentWithAncestorWithLocClientDiagnostics => _fakeParentWithAncestorWithLocClientDiagnostics ??= new ClientDiagnostics("MgmtListMethods.Mock", FakeParentWithAncestorWithLocResource.ResourceType.Namespace, Diagnostics);
        private FakeParentWithAncestorWithLocsRestOperations FakeParentWithAncestorWithLocRestClient => _fakeParentWithAncestorWithLocRestClient ??= new FakeParentWithAncestorWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FakeParentWithAncestorWithLocResource.ResourceType));

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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakeParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithLocs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithLocResource> GetFakeParentWithAncestorWithLocsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FakeParentWithAncestorWithLocRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FakeParentWithAncestorWithLocRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FakeParentWithAncestorWithLocResource(Client, FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(e)), FakeParentWithAncestorWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithLocResourceExtensionClient.GetFakeParentWithAncestorWithLocs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakeParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithLocs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithLocResource> GetFakeParentWithAncestorWithLocs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FakeParentWithAncestorWithLocRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FakeParentWithAncestorWithLocRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FakeParentWithAncestorWithLocResource(Client, FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(e)), FakeParentWithAncestorWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithLocResourceExtensionClient.GetFakeParentWithAncestorWithLocs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all under the specified subscription for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/locations/{location}/fakeParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithLocs_ListTestByLocations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithLocResource> GetFakeParentWithAncestorWithLocsByLocationAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            HttpMessage FirstPageRequest(int? pageSizeHint) => FakeParentWithAncestorWithLocRestClient.CreateListTestByLocationsRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FakeParentWithAncestorWithLocRestClient.CreateListTestByLocationsNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FakeParentWithAncestorWithLocResource(Client, FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(e)), FakeParentWithAncestorWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithLocResourceExtensionClient.GetFakeParentWithAncestorWithLocsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all under the specified subscription for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/locations/{location}/fakeParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithLocs_ListTestByLocations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithLocResource> GetFakeParentWithAncestorWithLocsByLocation(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            HttpMessage FirstPageRequest(int? pageSizeHint) => FakeParentWithAncestorWithLocRestClient.CreateListTestByLocationsRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FakeParentWithAncestorWithLocRestClient.CreateListTestByLocationsNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FakeParentWithAncestorWithLocResource(Client, FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(e)), FakeParentWithAncestorWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithLocResourceExtensionClient.GetFakeParentWithAncestorWithLocsByLocation", "value", "nextLink", cancellationToken);
        }
    }
}
