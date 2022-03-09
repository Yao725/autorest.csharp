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
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    internal partial class DedicatedHostsRestOperations
    {
        private readonly UserAgentValue _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of DedicatedHostsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public DedicatedHostsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-06-01";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = UserAgentValue.FromType<DedicatedHostsRestOperations>(applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostData parameters)
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
            uri.AppendPath("/providers/Microsoft.Compute/hostGroups/", false);
            uri.AppendPath(hostGroupName, true);
            uri.AppendPath("/hosts/", false);
            uri.AppendPath(hostName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Create or update a dedicated host . </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/>, <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<HttpMessage> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hostGroupName, hostName, parameters);
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

        /// <summary> Create or update a dedicated host . </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/>, <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public HttpMessage CreateOrUpdate(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hostGroupName, hostName, parameters);
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

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostUpdateOptions options)
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
            uri.AppendPath("/providers/Microsoft.Compute/hostGroups/", false);
            uri.AppendPath(hostGroupName, true);
            uri.AppendPath("/hosts/", false);
            uri.AppendPath(hostName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(options);
            request.Content = content;
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Update an dedicated host . </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="options"> Parameters supplied to the Update Dedicated Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/>, <paramref name="hostName"/> or <paramref name="options"/> is null. </exception>
        public async Task<HttpMessage> UpdateAsync(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, hostGroupName, hostName, options);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update an dedicated host . </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="options"> Parameters supplied to the Update Dedicated Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/>, <paramref name="hostName"/> or <paramref name="options"/> is null. </exception>
        public HttpMessage Update(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, DedicatedHostUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, hostGroupName, hostName, options);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName)
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
            uri.AppendPath("/providers/Microsoft.Compute/hostGroups/", false);
            uri.AppendPath(hostGroupName, true);
            uri.AppendPath("/hosts/", false);
            uri.AppendPath(hostName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Delete a dedicated host. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/> or <paramref name="hostName"/> is null. </exception>
        public async Task<HttpMessage> DeleteAsync(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hostGroupName, hostName);
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

        /// <summary> Delete a dedicated host. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/> or <paramref name="hostName"/> is null. </exception>
        public HttpMessage Delete(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hostGroupName, hostName);
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

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName)
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
            uri.AppendPath("/providers/Microsoft.Compute/hostGroups/", false);
            uri.AppendPath(hostGroupName, true);
            uri.AppendPath("/hosts/", false);
            uri.AppendPath(hostName, true);
            uri.AppendQuery("$expand", "instanceView", true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Retrieves information about a dedicated host. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/> or <paramref name="hostName"/> is null. </exception>
        public async Task<Response<DedicatedHostData>> GetAsync(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hostGroupName, hostName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DedicatedHostData)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information about a dedicated host. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostGroupName"/> or <paramref name="hostName"/> is null. </exception>
        public Response<DedicatedHostData> Get(string subscriptionId, string resourceGroupName, string hostGroupName, string hostName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hostGroupName, hostName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DedicatedHostData)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByHostGroupRequest(string subscriptionId, string resourceGroupName, string hostGroupName)
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
            uri.AppendPath("/providers/Microsoft.Compute/hostGroups/", false);
            uri.AppendPath(hostGroupName, true);
            uri.AppendPath("/hosts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostGroupName"/> is null. </exception>
        public async Task<Response<DedicatedHostListResult>> ListByHostGroupAsync(string subscriptionId, string resourceGroupName, string hostGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var message = CreateListByHostGroupRequest(subscriptionId, resourceGroupName, hostGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DedicatedHostListResult.DeserializeDedicatedHostListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostGroupName"/> is null. </exception>
        public Response<DedicatedHostListResult> ListByHostGroup(string subscriptionId, string resourceGroupName, string hostGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var message = CreateListByHostGroupRequest(subscriptionId, resourceGroupName, hostGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DedicatedHostListResult.DeserializeDedicatedHostListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByHostGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string hostGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetUserAgentString(_userAgent);
            return message;
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostGroupName"/> is null. </exception>
        public async Task<Response<DedicatedHostListResult>> ListByHostGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string hostGroupName, CancellationToken cancellationToken = default)
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
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var message = CreateListByHostGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, hostGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DedicatedHostListResult.DeserializeDedicatedHostListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostGroupName"/> is null. </exception>
        public Response<DedicatedHostListResult> ListByHostGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, string hostGroupName, CancellationToken cancellationToken = default)
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
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var message = CreateListByHostGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, hostGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DedicatedHostListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DedicatedHostListResult.DeserializeDedicatedHostListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
