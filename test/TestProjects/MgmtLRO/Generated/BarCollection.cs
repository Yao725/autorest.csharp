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
using Azure.ResourceManager.Resources;

namespace MgmtLRO
{
    /// <summary> A class representing collection of Bar and their operations over its parent. </summary>
    public partial class BarCollection : ArmCollection, IEnumerable<Bar>, IAsyncEnumerable<Bar>
    {
        private readonly ClientDiagnostics _barClientDiagnostics;
        private readonly BarsRestOperations _barRestClient;

        /// <summary> Initializes a new instance of the <see cref="BarCollection"/> class for mocking. </summary>
        protected BarCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BarCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BarCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _barClientDiagnostics = new ClientDiagnostics("MgmtLRO", Bar.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(Bar.ResourceType, out string barApiVersion);
            _barRestClient = new BarsRestOperations(_barClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, barApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The Bar to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<ArmOperation<Bar>> CreateOrUpdateAsync(bool waitForCompletion, string barName, BarData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var message = await _barRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, barName, body, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtLROArmOperation<Bar>(new BarOperationSource(Client), _barClientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location);
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
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The Bar to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<Bar> CreateOrUpdate(bool waitForCompletion, string barName, BarData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var message = _barRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, barName, body, cancellationToken);
                var operation = new MgmtLROArmOperation<Bar>(new BarOperationSource(Client), _barClientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location);
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
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public async virtual Task<Response<Bar>> GetAsync(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.Get");
            scope.Start();
            try
            {
                var response = await _barRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, barName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _barClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Bar(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public virtual Response<Bar> Get(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.Get");
            scope.Start();
            try
            {
                var response = _barRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, barName, cancellationToken);
                if (response.Value == null)
                    throw _barClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Bar(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars
        /// Operation Id: Bars_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Bar" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Bar> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Bar>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _barClientDiagnostics.CreateScope("BarCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _barRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars
        /// Operation Id: Bars_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Bar" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Bar> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Bar> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _barClientDiagnostics.CreateScope("BarCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _barRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(barName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public virtual Response<bool> Exists(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(barName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public async virtual Task<Response<Bar>> GetIfExistsAsync(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _barRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, barName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Bar>(null, response.GetRawResponse());
                return Response.FromValue(new Bar(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/bars/{barName}
        /// Operation Id: Bars_Get
        /// </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="barName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> is null. </exception>
        public virtual Response<Bar> GetIfExists(string barName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(barName, nameof(barName));

            using var scope = _barClientDiagnostics.CreateScope("BarCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _barRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, barName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Bar>(null, response.GetRawResponse());
                return Response.FromValue(new Bar(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Bar> IEnumerable<Bar>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Bar> IAsyncEnumerable<Bar>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
