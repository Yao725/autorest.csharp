// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Result of the request to list custom domains. It contains a list of custom domain objects and a URL link to get the next set of results. </summary>
    internal partial class CustomDomainListResult
    {
        /// <summary> Initializes a new instance of CustomDomainListResult. </summary>
        internal CustomDomainListResult()
        {
            Value = new ChangeTrackingList<CustomDomainData>();
        }

        /// <summary> Initializes a new instance of CustomDomainListResult. </summary>
        /// <param name="value"> List of CDN CustomDomains within an endpoint. </param>
        /// <param name="nextLink"> URL to get the next set of custom domain objects if there are any. </param>
        internal CustomDomainListResult(IReadOnlyList<CustomDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of CDN CustomDomains within an endpoint. </summary>
        public IReadOnlyList<CustomDomainData> Value { get; }
        /// <summary> URL to get the next set of custom domain objects if there are any. </summary>
        public string NextLink { get; }
    }
}
