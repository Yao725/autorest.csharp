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

namespace MgmtKeyvault
{
#pragma warning disable SA1649 // File name should match first type name
    internal class MgmtKeyvaultArmOperation<T> : ArmOperation<T>
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly OperationOrResponseInternals<T> _operation;

        /// <summary> Initializes a new instance of MgmtKeyvaultArmOperation for mocking. </summary>
        protected MgmtKeyvaultArmOperation()
        {
        }

        internal MgmtKeyvaultArmOperation(Response<T> response)
        {
            _operation = new OperationOrResponseInternals<T>(response);
        }

        internal MgmtKeyvaultArmOperation(IOperationSource<T> source, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, HttpMessage message, Response response, OperationFinalStateVia finalStateVia)
        {
            _operation = ArmOperationHelpers.CreateOperation(source, clientDiagnostics, pipeline, message, response, finalStateVia, "MgmtKeyvaultArmOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override T Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<T>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<T>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
