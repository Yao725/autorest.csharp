// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Result of the request to list origins. It contains a list of origin objects and a URL link to get the next set of results. </summary>
    internal partial class OriginListResult
    {
        /// <summary> Initializes a new instance of OriginListResult. </summary>
        internal OriginListResult()
        {
            Value = new ChangeTrackingList<OriginData>();
        }

        /// <summary> Initializes a new instance of OriginListResult. </summary>
        /// <param name="value"> List of CDN origins within an endpoint. </param>
        /// <param name="nextLink"> URL to get the next set of origin objects if there are any. </param>
        internal OriginListResult(IReadOnlyList<OriginData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of CDN origins within an endpoint. </summary>
        public IReadOnlyList<OriginData> Value { get; }
        /// <summary> URL to get the next set of origin objects if there are any. </summary>
        public string NextLink { get; }
    }
}
