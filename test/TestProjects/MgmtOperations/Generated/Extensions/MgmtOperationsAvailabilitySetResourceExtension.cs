// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtOperations;
using MgmtOperations.Models;

namespace MgmtOperations.Mock
{
    /// <summary> A class to add extension methods to AvailabilitySetResource. </summary>
    public partial class MgmtOperationsAvailabilitySetResourceExtension : ArmResource
    {
        private ClientDiagnostics _availabilitySetClientDiagnostics;
        private AvailabilitySetsRestOperations _availabilitySetRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtOperationsAvailabilitySetResourceExtension"/> class for mocking. </summary>
        protected MgmtOperationsAvailabilitySetResourceExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtOperationsAvailabilitySetResourceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtOperationsAvailabilitySetResourceExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AvailabilitySetClientDiagnostics => _availabilitySetClientDiagnostics ??= new ClientDiagnostics("MgmtOperations", AvailabilitySetResource.ResourceType.Namespace, Diagnostics);
        private AvailabilitySetsRestOperations AvailabilitySetRestClient => _availabilitySetRestClient ??= new AvailabilitySetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AvailabilitySetResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Update an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/patchAvailabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_TestLROMethod</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetUpdate"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetUpdate"/> is null. </exception>
        public virtual async Task<ArmOperation<TestAvailabilitySet>> TestLROMethodAvailabilitySetAsync(WaitUntil waitUntil, AvailabilitySetUpdate availabilitySetUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(availabilitySetUpdate, nameof(availabilitySetUpdate));

            using var scope = AvailabilitySetClientDiagnostics.CreateScope("MgmtOperationsAvailabilitySetResourceExtension.TestLROMethodAvailabilitySet");
            scope.Start();
            try
            {
                var response = await AvailabilitySetRestClient.TestLROMethodAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetUpdate, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtOperationsArmOperation<TestAvailabilitySet>(new TestAvailabilitySetOperationSource(), AvailabilitySetClientDiagnostics, Pipeline, AvailabilitySetRestClient.CreateTestLROMethodRequest(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetUpdate).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Update an availability set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/patchAvailabilitySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_TestLROMethod</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetUpdate"> Parameters supplied to the Update Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetUpdate"/> is null. </exception>
        public virtual ArmOperation<TestAvailabilitySet> TestLROMethodAvailabilitySet(WaitUntil waitUntil, AvailabilitySetUpdate availabilitySetUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(availabilitySetUpdate, nameof(availabilitySetUpdate));

            using var scope = AvailabilitySetClientDiagnostics.CreateScope("MgmtOperationsAvailabilitySetResourceExtension.TestLROMethodAvailabilitySet");
            scope.Start();
            try
            {
                var response = AvailabilitySetRestClient.TestLROMethod(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetUpdate, cancellationToken);
                var operation = new MgmtOperationsArmOperation<TestAvailabilitySet>(new TestAvailabilitySetOperationSource(), AvailabilitySetClientDiagnostics, Pipeline, AvailabilitySetRestClient.CreateTestLROMethodRequest(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetUpdate).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
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
