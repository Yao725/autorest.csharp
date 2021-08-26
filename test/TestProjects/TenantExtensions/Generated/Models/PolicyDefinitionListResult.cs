// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using TenantExtensions;

namespace TenantExtensions.Models
{
    /// <summary> List of policy definitions. </summary>
    internal partial class PolicyDefinitionListResult
    {
        /// <summary> Initializes a new instance of PolicyDefinitionListResult. </summary>
        internal PolicyDefinitionListResult()
        {
            Value = new ChangeTrackingList<PolicyDefinitionData>();
        }

        /// <summary> Initializes a new instance of PolicyDefinitionListResult. </summary>
        /// <param name="value"> An array of policy definitions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal PolicyDefinitionListResult(IReadOnlyList<PolicyDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of policy definitions. </summary>
        public IReadOnlyList<PolicyDefinitionData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
