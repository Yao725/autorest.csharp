// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Result of the request to list rule sets. It contains a list of rule set objects and a URL link to get the next set of results. </summary>
    internal partial class RuleSetListResult
    {
        /// <summary> Initializes a new instance of RuleSetListResult. </summary>
        internal RuleSetListResult()
        {
            Value = new ChangeTrackingList<RuleSetData>();
        }

        /// <summary> Initializes a new instance of RuleSetListResult. </summary>
        /// <param name="value"> List of AzureFrontDoor rule sets within a profile. </param>
        /// <param name="nextLink"> URL to get the next set of rule set objects if there are any. </param>
        internal RuleSetListResult(IReadOnlyList<RuleSetData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of AzureFrontDoor rule sets within a profile. </summary>
        public IReadOnlyList<RuleSetData> Value { get; }
        /// <summary> URL to get the next set of rule set objects if there are any. </summary>
        public string NextLink { get; }
    }
}
