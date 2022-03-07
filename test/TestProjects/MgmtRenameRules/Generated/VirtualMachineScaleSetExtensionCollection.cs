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

namespace MgmtRenameRules
{
    /// <summary> A class representing collection of VirtualMachineScaleSetExtension and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetExtensionCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetExtension>, IAsyncEnumerable<VirtualMachineScaleSetExtension>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetExtensionClientDiagnostics;
        private readonly VirtualMachineScaleSetExtensionsRestOperations _virtualMachineScaleSetExtensionRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetExtensionCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetExtensionClientDiagnostics = new ClientDiagnostics("MgmtRenameRules", VirtualMachineScaleSetExtension.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualMachineScaleSetExtension.ResourceType, out string virtualMachineScaleSetExtensionApiVersion);
            _virtualMachineScaleSetExtensionRestClient = new VirtualMachineScaleSetExtensionsRestOperations(_virtualMachineScaleSetExtensionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineScaleSetExtensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSet.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSet.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update an extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<VirtualMachineScaleSetExtension>> CreateOrUpdateAsync(bool waitForCompletion, string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));
            Argument.AssertNotNull(extensionParameters, nameof(extensionParameters));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtRenameRulesArmOperation<VirtualMachineScaleSetExtension>(new VirtualMachineScaleSetExtensionOperationSource(Client), _virtualMachineScaleSetExtensionClientDiagnostics, Pipeline, _virtualMachineScaleSetExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters), response, OperationFinalStateVia.Location, _virtualMachineScaleSetExtensionRestClient.GetUserAgent());
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
        /// The operation to create or update an extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetExtension> CreateOrUpdate(bool waitForCompletion, string vmssExtensionName, VirtualMachineScaleSetExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));
            Argument.AssertNotNull(extensionParameters, nameof(extensionParameters));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters, cancellationToken);
                var operation = new MgmtRenameRulesArmOperation<VirtualMachineScaleSetExtension>(new VirtualMachineScaleSetExtensionOperationSource(Client), _virtualMachineScaleSetExtensionClientDiagnostics, Pipeline, _virtualMachineScaleSetExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, extensionParameters), response, OperationFinalStateVia.Location, _virtualMachineScaleSetExtensionRestClient.GetUserAgent());
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
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetExtension>> GetAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualMachineScaleSetExtensionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSetExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetExtension> Get(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualMachineScaleSetExtensionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all extensions in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetExtensions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetExtension> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetExtensionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetExtensionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all extensions in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetExtensions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetExtension> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetExtensionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetExtensionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmssExtensionName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmssExtensionName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetExtension>> GetIfExistsAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetExtension>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetExtension> GetIfExists(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _virtualMachineScaleSetExtensionClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmssExtensionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetExtension>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetExtension> IEnumerable<VirtualMachineScaleSetExtension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetExtension> IAsyncEnumerable<VirtualMachineScaleSetExtension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
