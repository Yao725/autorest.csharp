// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using SubscriptionExtensions.Mock;

namespace SubscriptionExtensions
{
    /// <summary> A class to add extension methods to SubscriptionExtensions. </summary>
    public static partial class SubscriptionExtensionsExtensions
    {
        private static SubscriptionExtensionsResourceGroupResourceExtension GetSubscriptionExtensionsResourceGroupResourceExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionExtensionsResourceGroupResourceExtension(client, resource.Id);
            });
        }

        private static SubscriptionExtensionsResourceGroupResourceExtension GetSubscriptionExtensionsResourceGroupResourceExtension(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionExtensionsResourceGroupResourceExtension(client, scope);
            });
        }

        private static SubscriptionExtensionsSubscriptionResourceExtension GetSubscriptionExtensionsSubscriptionResourceExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionExtensionsSubscriptionResourceExtension(client, resource.Id);
            });
        }

        private static SubscriptionExtensionsSubscriptionResourceExtension GetSubscriptionExtensionsSubscriptionResourceExtension(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionExtensionsSubscriptionResourceExtension(client, scope);
            });
        }
        #region ToasterResource
        /// <summary>
        /// Gets an object representing a <see cref="ToasterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ToasterResource.CreateResourceIdentifier" /> to create a <see cref="ToasterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ToasterResource" /> object. </returns>
        public static ToasterResource GetToasterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ToasterResource.ValidateResourceId(id);
                return new ToasterResource(client, id);
            }
            );
        }
        #endregion

        #region OvenResource
        /// <summary>
        /// Gets an object representing an <see cref="OvenResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OvenResource.CreateResourceIdentifier" /> to create an <see cref="OvenResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OvenResource" /> object. </returns>
        public static OvenResource GetOvenResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OvenResource.ValidateResourceId(id);
                return new OvenResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of OvenResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OvenResources and their operations over a OvenResource. </returns>
        public static OvenCollection GetOvens(this ResourceGroupResource resourceGroupResource)
        {
            return GetSubscriptionExtensionsResourceGroupResourceExtension(resourceGroupResource).GetOvens();
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ovens_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ovenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OvenResource>> GetOvenAsync(this ResourceGroupResource resourceGroupResource, string ovenName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetOvens().GetAsync(ovenName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ovens_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ovenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<OvenResource> GetOven(this ResourceGroupResource resourceGroupResource, string ovenName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetOvens().Get(ovenName, cancellationToken);
        }

        /// <summary> Gets a collection of ToasterResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ToasterResources and their operations over a ToasterResource. </returns>
        public static ToasterCollection GetToasters(this SubscriptionResource subscriptionResource)
        {
            return GetSubscriptionExtensionsSubscriptionResourceExtension(subscriptionResource).GetToasters();
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/toasters/{toasterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Toasters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="toasterName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="toasterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="toasterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ToasterResource>> GetToasterAsync(this SubscriptionResource subscriptionResource, string toasterName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetToasters().GetAsync(toasterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/toasters/{toasterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Toasters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="toasterName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="toasterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="toasterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ToasterResource> GetToaster(this SubscriptionResource subscriptionResource, string toasterName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetToasters().Get(toasterName, cancellationToken);
        }
    }
}
