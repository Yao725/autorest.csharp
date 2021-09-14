// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines contents of custom rules. </summary>
    public partial class CustomRuleList
    {
        /// <summary> Initializes a new instance of CustomRuleList. </summary>
        public CustomRuleList()
        {
            Rules = new ChangeTrackingList<CustomRule>();
        }

        /// <summary> Initializes a new instance of CustomRuleList. </summary>
        /// <param name="rules"> List of rules. </param>
        internal CustomRuleList(IList<CustomRule> rules)
        {
            Rules = rules;
        }

        /// <summary> List of rules. </summary>
        public IList<CustomRule> Rules { get; }
    }
}
