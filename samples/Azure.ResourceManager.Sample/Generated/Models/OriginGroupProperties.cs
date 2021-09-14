// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The JSON object that contains the properties of the origin group. </summary>
    internal partial class OriginGroupProperties : OriginGroupUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of OriginGroupProperties. </summary>
        internal OriginGroupProperties()
        {
        }

        /// <summary> Resource status of the origin group. </summary>
        public OriginGroupResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the origin group. </summary>
        public string ProvisioningState { get; }
    }
}
