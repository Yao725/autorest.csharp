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
    internal partial class AppleDefinitionListResult
    {
        /// <summary> Initializes a new instance of AppleDefinitionListResult. </summary>
        internal AppleDefinitionListResult()
        {
            Value = new ChangeTrackingList<AppleData>();
        }

        /// <summary> Initializes a new instance of AppleDefinitionListResult. </summary>
        /// <param name="value"> An array of policy definitions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal AppleDefinitionListResult(IReadOnlyList<AppleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of policy definitions. </summary>
        public IReadOnlyList<AppleData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
