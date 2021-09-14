// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Profile
        /// <summary> Gets an object representing a ProfileContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ProfileContainer" /> object. </returns>
        public static ProfileContainer GetProfiles(this ResourceGroup resourceGroup)
        {
            return new ProfileContainer(resourceGroup);
        }
        #endregion

        #region CdnWebApplicationFirewallPolicy
        /// <summary> Gets an object representing a CdnWebApplicationFirewallPolicyContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="CdnWebApplicationFirewallPolicyContainer" /> object. </returns>
        public static CdnWebApplicationFirewallPolicyContainer GetCdnWebApplicationFirewallPolicies(this ResourceGroup resourceGroup)
        {
            return new CdnWebApplicationFirewallPolicyContainer(resourceGroup);
        }
        #endregion
    }
}
