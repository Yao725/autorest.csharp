// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The json object that contains properties required to create a security policy. </summary>
    public partial class SecurityPolicyProperties : AFDStateProperties
    {
        /// <summary> Initializes a new instance of SecurityPolicyProperties. </summary>
        public SecurityPolicyProperties()
        {
        }

        /// <summary> object which contains security policy parameters. </summary>
        public SecurityPolicyParameters Parameters { get; set; }
    }
}
