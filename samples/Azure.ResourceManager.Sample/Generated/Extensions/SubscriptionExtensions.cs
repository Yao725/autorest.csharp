// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region Profile
        private static ProfilesRestOperations GetProfilesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ProfilesRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the Profiles for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Profile> GetProfilesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetProfilesRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<Profile>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Profile>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the Profiles for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Profile> GetProfiles(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetProfilesRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<Profile> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAll(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Profile> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetProfileByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Profile.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetProfileByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Profile.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region Probe
        private static ProbeRestOperations GetProbeRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ProbeRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static async Task<Response<ValidateProbeOutput>> ValidateProbeAsync(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetProbeRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ValidateProbe");
                scope.Start();
                try
                {
                    var response = await restOperations.ValidateAsync(validateProbeInput, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static Response<ValidateProbeOutput> ValidateProbe(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetProbeRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ValidateProbe");
                scope.Start();
                try
                {
                    var response = restOperations.Validate(validateProbeInput, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        #endregion

        #region ResourceUsage
        private static ResourceUsageRestOperations GetResourceUsageRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ResourceUsageRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the ResourceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceUsage> GetResourceUsagesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceUsageRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<ResourceUsage>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ResourceUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ResourceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceUsage> GetResourceUsages(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceUsageRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<ResourceUsage> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAll(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ResourceUsage> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        #endregion

        #region Validate
        private static ValidateRestOperations GetValidateRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ValidateRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Validate a Secret in the profile. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public static async Task<Response<ValidateSecretOutput>> SecretValidateAsync(this Subscription subscription, ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            if (validateSecretInput == null)
            {
                throw new ArgumentNullException(nameof(validateSecretInput));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetValidateRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.SecretValidate");
                scope.Start();
                try
                {
                    var response = await restOperations.SecretAsync(validateSecretInput, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Validate a Secret in the profile. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public static Response<ValidateSecretOutput> SecretValidate(this Subscription subscription, ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            if (validateSecretInput == null)
            {
                throw new ArgumentNullException(nameof(validateSecretInput));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetValidateRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.SecretValidate");
                scope.Start();
                try
                {
                    var response = restOperations.Secret(validateSecretInput, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        #endregion

        #region ManagedRuleSet
        private static ManagedRuleSetsRestOperations GetManagedRuleSetsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ManagedRuleSetsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the ManagedRuleSetDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetManagedRuleSetsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<ManagedRuleSetDefinition>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagedRuleSetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ManagedRuleSetDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetManagedRuleSetsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<ManagedRuleSetDefinition> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAll(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagedRuleSetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        #endregion
    }
}
