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

namespace lro
{
    /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
    public partial class LROsCustomHeaderPost202Retry200Operation : Operation
    {
        private readonly OperationInternal _operation;

        /// <summary> Initializes a new instance of LROsCustomHeaderPost202Retry200Operation for mocking. </summary>
        protected LROsCustomHeaderPost202Retry200Operation()
        {
        }

        internal LROsCustomHeaderPost202Retry200Operation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation nextLinkOperation = NextLinkOperationImplementation.Create(pipeline, request.Method, request.Uri.ToUri(), response, OperationFinalStateVia.Location);
            _operation = new OperationInternal(nextLinkOperation, clientDiagnostics, response, "LROsCustomHeaderPost202Retry200Operation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

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
