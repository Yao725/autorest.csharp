// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtParent
{
    /// <summary> A class representing collection of DedicatedHost and their operations over its parent. </summary>
    public partial class DedicatedHostCollection : ArmCollection, IEnumerable<DedicatedHost>, IAsyncEnumerable<DedicatedHost>
    {
        private readonly ClientDiagnostics _dedicatedHostClientDiagnostics;
        private readonly DedicatedHostsRestOperations _dedicatedHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostCollection"/> class for mocking. </summary>
        protected DedicatedHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DedicatedHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dedicatedHostClientDiagnostics = new ClientDiagnostics("MgmtParent", DedicatedHost.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DedicatedHost.ResourceType, out string dedicatedHostApiVersion);
            _dedicatedHostRestClient = new DedicatedHostsRestOperations(_dedicatedHostClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dedicatedHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DedicatedHostGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DedicatedHostGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a dedicated host .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<DedicatedHost>> CreateOrUpdateAsync(bool waitForCompletion, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParentArmOperation<DedicatedHost>(new DedicatedHostOperationSource(Client), _dedicatedHostClientDiagnostics, Pipeline, _dedicatedHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters), response, OperationFinalStateVia.Location, _dedicatedHostRestClient.GetUserAgent());
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a dedicated host .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DedicatedHost> CreateOrUpdate(bool waitForCompletion, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken);
                var operation = new MgmtParentArmOperation<DedicatedHost>(new DedicatedHostOperationSource(Client), _dedicatedHostClientDiagnostics, Pipeline, _dedicatedHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters), response, OperationFinalStateVia.Location, _dedicatedHostRestClient.GetUserAgent());
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a dedicated host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHost>> GetAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _dedicatedHostClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a dedicated host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHost> Get(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken);
                if (response.Value == null)
                    throw _dedicatedHostClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts
        /// Operation Id: DedicatedHosts_ListByHostGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostRestClient.ListByHostGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DedicatedHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostRestClient.ListByHostGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts
        /// Operation Id: DedicatedHosts_ListByHostGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostRestClient.ListByHostGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DedicatedHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostRestClient.ListByHostGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHost>> GetIfExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHost>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHost> GetIfExists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHost>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DedicatedHost> IEnumerable<DedicatedHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedHost> IAsyncEnumerable<DedicatedHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
