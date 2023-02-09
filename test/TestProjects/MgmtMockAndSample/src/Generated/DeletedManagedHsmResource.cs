// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtMockAndSample
{
    /// <summary>
    /// A Class representing a DeletedManagedHsm along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DeletedManagedHsmResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDeletedManagedHsmResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetDeletedManagedHsm method.
    /// </summary>
    public partial class DeletedManagedHsmResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeletedManagedHsmResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deletedManagedHsmManagedHsmsClientDiagnostics;
        private readonly ManagedHsmsRestOperations _deletedManagedHsmManagedHsmsRestClient;
        private readonly DeletedManagedHsmData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedManagedHsmResource"/> class for mocking. </summary>
        protected DeletedManagedHsmResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedManagedHsmResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeletedManagedHsmResource(ArmClient client, DeletedManagedHsmData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedManagedHsmResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedManagedHsmResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedManagedHsmManagedHsmsClientDiagnostics = new ClientDiagnostics("MgmtMockAndSample", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deletedManagedHsmManagedHsmsApiVersion);
            _deletedManagedHsmManagedHsmsRestClient = new ManagedHsmsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedManagedHsmManagedHsmsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/locations/deletedManagedHSMs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedManagedHsmData Data
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

        /// <summary>
        /// Gets the specified deleted managed HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedManagedHsmResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmResource.Get");
            scope.Start();
            try
            {
                var response = await _deletedManagedHsmManagedHsmsRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified deleted managed HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedManagedHsmResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmResource.Get");
            scope.Start();
            try
            {
                var response = _deletedManagedHsmManagedHsmsRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedManagedHsmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified managed HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}/purge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_PurgeDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> PurgeDeletedAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmResource.PurgeDeleted");
            scope.Start();
            try
            {
                using var message = _deletedManagedHsmManagedHsmsRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                var response = await _deletedManagedHsmManagedHsmsRestClient.PurgeDeletedAsync(message, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMockAndSampleArmOperation(_deletedManagedHsmManagedHsmsClientDiagnostics, Pipeline, message.Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified managed HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedManagedHSMs/{name}/purge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_PurgeDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation PurgeDeleted(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedManagedHsmManagedHsmsClientDiagnostics.CreateScope("DeletedManagedHsmResource.PurgeDeleted");
            scope.Start();
            try
            {
                using var message = _deletedManagedHsmManagedHsmsRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                var response = _deletedManagedHsmManagedHsmsRestClient.PurgeDeleted(message, cancellationToken);
                var operation = new MgmtMockAndSampleArmOperation(_deletedManagedHsmManagedHsmsClientDiagnostics, Pipeline, message.Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
