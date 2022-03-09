// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    internal partial class AnotherParentsRestOperations
    {
        private readonly UserAgentValue _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AnotherParentsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public AnotherParentsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-03-01";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = UserAgentValue.FromType<AnotherParentsRestOperations>(applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentData anotherBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(anotherBody);
            request.Content = content;
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="anotherName"/> or <paramref name="anotherBody"/> is null. </exception>
        public async Task<HttpMessage> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (anotherBody == null)
            {
                throw new ArgumentNullException(nameof(anotherBody));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, anotherName, anotherBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="anotherName"/> or <paramref name="anotherBody"/> is null. </exception>
        public HttpMessage CreateOrUpdate(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (anotherBody == null)
            {
                throw new ArgumentNullException(nameof(anotherBody));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, anotherName, anotherBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentUpdateOptions options)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(options);
            request.Content = content;
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to update the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be updated. </param>
        /// <param name="options"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="anotherName"/> or <paramref name="options"/> is null. </exception>
        public async Task<HttpMessage> UpdateAsync(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, anotherName, options);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to update the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be updated. </param>
        /// <param name="options"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="anotherName"/> or <paramref name="options"/> is null. </exception>
        public HttpMessage Update(string subscriptionId, string resourceGroupName, string anotherName, AnotherParentUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, anotherName, options);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string anotherName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to delete the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public async Task<HttpMessage> DeleteAsync(string subscriptionId, string resourceGroupName, string anotherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, anotherName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to delete the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public HttpMessage Delete(string subscriptionId, string resourceGroupName, string anotherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, anotherName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string anotherName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to get the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public async Task<Response<AnotherParentData>> GetAsync(string subscriptionId, string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, anotherName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnotherParentData.DeserializeAnotherParentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AnotherParentData)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get the run command. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public Response<AnotherParentData> Get(string subscriptionId, string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, anotherName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnotherParentData.DeserializeAnotherParentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AnotherParentData)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<AnotherParentsListResult>> ListAsync(string subscriptionId, string resourceGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnotherParentsListResult.DeserializeAnotherParentsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<AnotherParentsListResult> List(string subscriptionId, string resourceGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnotherParentsListResult.DeserializeAnotherParentsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<AnotherParentsListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnotherParentsListResult.DeserializeAnotherParentsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<AnotherParentsListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnotherParentsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnotherParentsListResult.DeserializeAnotherParentsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
