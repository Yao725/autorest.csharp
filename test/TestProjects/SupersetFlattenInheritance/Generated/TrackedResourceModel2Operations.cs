// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the operations that can be performed over a specific TrackedResourceModel2. </summary>
    public partial class TrackedResourceModel2Operations : ResourceOperationsBase<ResourceGroupResourceIdentifier, TrackedResourceModel2>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private TrackedResourceModel2SRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel2Operations"/> class for mocking. </summary>
        protected TrackedResourceModel2Operations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel2Operations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal TrackedResourceModel2Operations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new TrackedResourceModel2SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/trackedResourceModel2s";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<TrackedResourceModel2>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<TrackedResourceModel2> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new TrackedResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async Task<Response<TrackedResourceModel2>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.AddTag");
            scope.Start();
            try
            {
                var operation = await StartAddTagAsync(key, value, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public Response<TrackedResourceModel2> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.AddTag");
            scope.Start();
            try
            {
                var operation = StartAddTag(key, value, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<TrackedResourceModel2SPutOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public TrackedResourceModel2SPutOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = _restClient.Put(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async Task<Response<TrackedResourceModel2>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.SetTags");
            scope.Start();
            try
            {
                var operation = await StartSetTagsAsync(tags, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public Response<TrackedResourceModel2> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.SetTags");
            scope.Start();
            try
            {
                var operation = StartSetTags(tags, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<TrackedResourceModel2SPutOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartSetTags");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public TrackedResourceModel2SPutOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartSetTags");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = _restClient.Put(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async Task<Response<TrackedResourceModel2>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.RemoveTag");
            scope.Start();
            try
            {
                var operation = await StartRemoveTagAsync(key, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public Response<TrackedResourceModel2> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.RemoveTag");
            scope.Start();
            try
            {
                var operation = StartRemoveTag(key, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<TrackedResourceModel2SPutOperation> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public TrackedResourceModel2SPutOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TrackedResourceModel2Data(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = _restClient.Put(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new TrackedResourceModel2SPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
