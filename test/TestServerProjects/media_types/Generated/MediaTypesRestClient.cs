// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using media_types.Models;

namespace media_types
{
    internal partial class MediaTypesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of MediaTypesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public MediaTypesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateAnalyzeBodyRequest(Models.ContentType contentType, Stream input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/analyze", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (input != null)
            {
                request.Headers.Add("Content-Type", contentType.ToSerialString());
                request.Content = RequestContent.Create(input);
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> AnalyzeBodyAsync(Models.ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(contentType, input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> AnalyzeBody(Models.ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(contentType, input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeBodyRequest(SourcePath input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/analyze", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (input != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(input);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> AnalyzeBodyAsync(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> AnalyzeBody(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeBodyNoAcceptHeaderRequest(Models.ContentType contentType, Stream input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/analyzeNoAccept", false);
            request.Uri = uri;
            if (input != null)
            {
                request.Headers.Add("Content-Type", contentType.ToSerialString());
                request.Content = RequestContent.Create(input);
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(Models.ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyNoAcceptHeaderRequest(contentType, input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response AnalyzeBodyNoAcceptHeader(Models.ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyNoAcceptHeaderRequest(contentType, input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeBodyNoAcceptHeaderRequest(SourcePath input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/analyzeNoAccept", false);
            request.Uri = uri;
            if (input != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(input);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyNoAcceptHeaderRequest(input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response AnalyzeBodyNoAcceptHeader(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyNoAcceptHeaderRequest(input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateContentTypeWithEncodingRequest(string input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/contentTypeWithEncoding", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (input != null)
            {
                request.Headers.Add("Content-Type", "text/plain; charset=UTF-8");
                request.Content = new StringRequestContent(input);
            }
            return message;
        }

        /// <summary> Pass in contentType &apos;text/plain; charset=UTF-8&apos; to pass test. Value for input does not matter. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<string>> ContentTypeWithEncodingAsync(string input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateContentTypeWithEncodingRequest(input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Pass in contentType &apos;text/plain; charset=UTF-8&apos; to pass test. Value for input does not matter. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> ContentTypeWithEncoding(string input = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateContentTypeWithEncodingRequest(input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetString();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateBinaryBodyWithTwoContentTypesRequest(ContentType1 contentType, Stream message)
        {
            var message0 = _pipeline.CreateMessage();
            var request = message0.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/binaryBodyTwoContentTypes", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            request.Headers.Add("Content-Type", contentType.ToSerialString());
            request.Content = RequestContent.Create(message);
            return message0;
        }

        /// <summary> Binary body with two content types. Pass in of {&apos;hello&apos;: &apos;world&apos;} for the application/json content type, and a byte stream of &apos;hello, world!&apos; for application/octet-stream. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public async Task<Response<string>> BinaryBodyWithTwoContentTypesAsync(ContentType1 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateBinaryBodyWithTwoContentTypesRequest(contentType, message);
            await _pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message0.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Binary body with two content types. Pass in of {&apos;hello&apos;: &apos;world&apos;} for the application/json content type, and a byte stream of &apos;hello, world!&apos; for application/octet-stream. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public Response<string> BinaryBodyWithTwoContentTypes(ContentType1 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateBinaryBodyWithTwoContentTypesRequest(contentType, message);
            _pipeline.Send(message0, cancellationToken);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = streamReader.ReadToEnd();
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message0.Response);
            }
        }

        internal HttpMessage CreateBinaryBodyWithThreeContentTypesRequest(ContentType2 contentType, Stream message)
        {
            var message0 = _pipeline.CreateMessage();
            var request = message0.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/binaryBodyThreeContentTypes", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            request.Headers.Add("Content-Type", contentType.ToSerialString());
            request.Content = RequestContent.Create(message);
            return message0;
        }

        /// <summary> Binary body with three content types. Pass in string &apos;hello, world&apos; with content type &apos;text/plain&apos;, {&apos;hello&apos;: world&apos;} with content type &apos;application/json&apos; and a byte string for &apos;application/octet-stream&apos;. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public async Task<Response<string>> BinaryBodyWithThreeContentTypesAsync(ContentType2 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateBinaryBodyWithThreeContentTypesRequest(contentType, message);
            await _pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message0.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Binary body with three content types. Pass in string &apos;hello, world&apos; with content type &apos;text/plain&apos;, {&apos;hello&apos;: world&apos;} with content type &apos;application/json&apos; and a byte string for &apos;application/octet-stream&apos;. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public Response<string> BinaryBodyWithThreeContentTypes(ContentType2 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateBinaryBodyWithThreeContentTypesRequest(contentType, message);
            _pipeline.Send(message0, cancellationToken);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = streamReader.ReadToEnd();
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message0.Response);
            }
        }

        internal HttpMessage CreatePutTextAndJsonBodyRequest(ContentType3 contentType, string message)
        {
            var message0 = _pipeline.CreateMessage();
            var request = message0.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/mediatypes/textAndJson", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "text/plain");
            request.Headers.Add("Content-Type", contentType.ToSerialString());
            request.Content = new StringRequestContent(message);
            return message0;
        }

        /// <summary> Body that&apos;s either text/plain or application/json. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public async Task<Response<string>> PutTextAndJsonBodyAsync(ContentType3 contentType, string message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreatePutTextAndJsonBodyRequest(contentType, message);
            await _pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message0.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Body that&apos;s either text/plain or application/json. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public Response<string> PutTextAndJsonBody(ContentType3 contentType, string message, CancellationToken cancellationToken = default)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreatePutTextAndJsonBodyRequest(contentType, message);
            _pipeline.Send(message0, cancellationToken);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        StreamReader streamReader = new StreamReader(message0.Response.ContentStream);
                        string value = streamReader.ReadToEnd();
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message0.Response);
            }
        }
    }
}
