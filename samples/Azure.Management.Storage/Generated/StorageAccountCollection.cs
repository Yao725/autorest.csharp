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
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of StorageAccount and their operations over its parent. </summary>
    public partial class StorageAccountCollection : ArmCollection, IEnumerable<StorageAccount>, IAsyncEnumerable<StorageAccount>
    {
        private readonly ClientDiagnostics _storageAccountClientDiagnostics;
        private readonly StorageAccountsRestOperations _storageAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageAccountCollection"/> class for mocking. </summary>
        protected StorageAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageAccountClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", StorageAccount.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(StorageAccount.ResourceType, out string storageAccountApiVersion);
            _storageAccountRestClient = new StorageAccountsRestOperations(_storageAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, storageAccountApiVersion);
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
        /// Asynchronously creates a new storage account with the specified parameters. If an account is already created and a subsequent create request is issued with different properties, the account properties will be updated. If an account is already created and a subsequent create or update request is issued with the exact same set of properties, the request will succeed.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The parameters to provide for the created account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<StorageAccount>> CreateOrUpdateAsync(bool waitForCompletion, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageAccountRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<StorageAccount>(new StorageAccountOperationSource(Client), _storageAccountClientDiagnostics, Pipeline, _storageAccountRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, parameters), response, OperationFinalStateVia.Location, _storageAccountRestClient.GetUserAgent());
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
        /// Asynchronously creates a new storage account with the specified parameters. If an account is already created and a subsequent create request is issued with different properties, the account properties will be updated. If an account is already created and a subsequent create or update request is issued with the exact same set of properties, the request will succeed.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The parameters to provide for the created account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<StorageAccount> CreateOrUpdate(bool waitForCompletion, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageAccountRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, parameters, cancellationToken);
                var operation = new StorageArmOperation<StorageAccount>(new StorageAccountOperationSource(Client), _storageAccountClientDiagnostics, Pipeline, _storageAccountRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, parameters), response, OperationFinalStateVia.Location, _storageAccountRestClient.GetUserAgent());
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
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async virtual Task<Response<StorageAccount>> GetAsync(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageAccountRestClient.GetPropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _storageAccountClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StorageAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<StorageAccount> Get(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _storageAccountRestClient.GetProperties(Id.SubscriptionId, Id.ResourceGroupName, accountName, expand, cancellationToken);
                if (response.Value == null)
                    throw _storageAccountClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async virtual Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = await _storageAccountRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, accountName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailability(StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = _storageAccountRestClient.CheckNameAvailability(Id.SubscriptionId, accountName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the storage accounts available under the given resource group. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccount> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageAccountRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageAccount>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageAccountRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the storage accounts available under the given resource group. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccount> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StorageAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageAccountRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageAccount> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageAccountRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(accountName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(accountName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async virtual Task<Response<StorageAccount>> GetIfExistsAsync(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageAccountRestClient.GetPropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StorageAccount>(null, response.GetRawResponse());
                return Response.FromValue(new StorageAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// Operation Id: StorageAccounts_GetProperties
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account&apos;s properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<StorageAccount> GetIfExists(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _storageAccountClientDiagnostics.CreateScope("StorageAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageAccountRestClient.GetProperties(Id.SubscriptionId, Id.ResourceGroupName, accountName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StorageAccount>(null, response.GetRawResponse());
                return Response.FromValue(new StorageAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageAccount> IEnumerable<StorageAccount>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageAccount> IAsyncEnumerable<StorageAccount>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
