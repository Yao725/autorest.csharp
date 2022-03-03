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

namespace MgmtExtensionCommonRestOperation
{
#pragma warning disable SA1649 // File name should match first type name
    internal class MgmtExtensionCommonRestOperationArmOperation : ArmOperation
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly OperationOrResponseInternals _operation;

        /// <summary> Initializes a new instance of MgmtExtensionCommonRestOperationArmOperation for mocking. </summary>
        protected MgmtExtensionCommonRestOperationArmOperation()
        {
        }

        internal MgmtExtensionCommonRestOperationArmOperation(Response response)
        {
            _operation = new OperationOrResponseInternals(response);
        }

        internal MgmtExtensionCommonRestOperationArmOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, HttpMessage message, Response response, OperationFinalStateVia finalStateVia)
        {
            _operation = ArmOperationHelpers.CreateOperation(clientDiagnostics, pipeline, message, response, finalStateVia, "MgmtExtensionCommonRestOperationArmOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
