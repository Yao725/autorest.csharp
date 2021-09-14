// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines a rate limiting rule that can be included in a waf policy. </summary>
    public partial class RateLimitRule : CustomRule
    {
        /// <summary> Initializes a new instance of RateLimitRule. </summary>
        /// <param name="name"> Defines the name of the custom rule. </param>
        /// <param name="priority"> Defines in what order this rule be evaluated in the overall list of custom rules. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <param name="rateLimitThreshold"> Defines rate limit threshold. </param>
        /// <param name="rateLimitDurationInMinutes"> Defines rate limit duration. Default is 1 minute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="matchConditions"/> is null. </exception>
        public RateLimitRule(string name, int priority, IEnumerable<MatchCondition> matchConditions, ActionType action, int rateLimitThreshold, int rateLimitDurationInMinutes) : base(name, priority, matchConditions, action)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (matchConditions == null)
            {
                throw new ArgumentNullException(nameof(matchConditions));
            }

            RateLimitThreshold = rateLimitThreshold;
            RateLimitDurationInMinutes = rateLimitDurationInMinutes;
        }

        /// <summary> Initializes a new instance of RateLimitRule. </summary>
        /// <param name="name"> Defines the name of the custom rule. </param>
        /// <param name="enabledState"> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </param>
        /// <param name="priority"> Defines in what order this rule be evaluated in the overall list of custom rules. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <param name="rateLimitThreshold"> Defines rate limit threshold. </param>
        /// <param name="rateLimitDurationInMinutes"> Defines rate limit duration. Default is 1 minute. </param>
        internal RateLimitRule(string name, CustomRuleEnabledState? enabledState, int priority, IList<MatchCondition> matchConditions, ActionType action, int rateLimitThreshold, int rateLimitDurationInMinutes) : base(name, enabledState, priority, matchConditions, action)
        {
            RateLimitThreshold = rateLimitThreshold;
            RateLimitDurationInMinutes = rateLimitDurationInMinutes;
        }

        /// <summary> Defines rate limit threshold. </summary>
        public int RateLimitThreshold { get; set; }
        /// <summary> Defines rate limit duration. Default is 1 minute. </summary>
        public int RateLimitDurationInMinutes { get; set; }
    }
}
