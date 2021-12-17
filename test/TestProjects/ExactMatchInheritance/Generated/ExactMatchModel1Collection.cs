// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using ExactMatchInheritance.Models;

namespace ExactMatchInheritance
{
    /// <summary> A class representing collection of ExactMatchModel1 and their operations over its parent. </summary>
    public partial class ExactMatchModel1Collection : ArmCollection, IEnumerable<ExactMatchModel1>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExactMatchModel1SRestOperations _exactMatchModel1sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExactMatchModel1Collection"/> class for mocking. </summary>
        protected ExactMatchModel1Collection()
        {
        }

        /// <summary> Initializes a new instance of ExactMatchModel1Collection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExactMatchModel1Collection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _exactMatchModel1sRestClient = new ExactMatchModel1SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_Put
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ExactMatchModel1SPutOperation CreateOrUpdate(string exactMatchModel1SName, ExactMatchModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _exactMatchModel1sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, parameters, cancellationToken);
                var operation = new ExactMatchModel1SPutOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_Put
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ExactMatchModel1SPutOperation> CreateOrUpdateAsync(string exactMatchModel1SName, ExactMatchModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _exactMatchModel1sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExactMatchModel1SPutOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_Get
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public virtual Response<ExactMatchModel1> Get(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.Get");
            scope.Start();
            try
            {
                var response = _exactMatchModel1sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_Get
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel1>> GetAsync(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.Get");
            scope.Start();
            try
            {
                var response = await _exactMatchModel1sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExactMatchModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public virtual Response<ExactMatchModel1> GetIfExists(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _exactMatchModel1sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExactMatchModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new ExactMatchModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel1>> GetIfExistsAsync(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _exactMatchModel1sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExactMatchModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new ExactMatchModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(exactMatchModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            if (exactMatchModel1SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(exactMatchModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ExactMatchModel1>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetAll");
            scope.Start();
            try
            {
                var response = _exactMatchModel1sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(value => new ExactMatchModel1(Parent, value)).ToArray() as IReadOnlyList<ExactMatchModel1>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel1s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<ExactMatchModel1>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetAll");
            scope.Start();
            try
            {
                var response = await _exactMatchModel1sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(value => new ExactMatchModel1(Parent, value)).ToArray() as IReadOnlyList<ExactMatchModel1>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExactMatchModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExactMatchModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExactMatchModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel1Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExactMatchModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExactMatchModel1> IEnumerable<ExactMatchModel1>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ExactMatchModel1, ExactMatchModel1Data> Construct() { }
    }
}
