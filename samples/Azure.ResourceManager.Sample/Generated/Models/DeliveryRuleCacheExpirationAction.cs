// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines the cache expiration action for the delivery rule. </summary>
    public partial class DeliveryRuleCacheExpirationAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of DeliveryRuleCacheExpirationAction. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleCacheExpirationAction(CacheExpirationActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = DeliveryRuleActionName.CacheExpiration;
        }

        /// <summary> Initializes a new instance of DeliveryRuleCacheExpirationAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal DeliveryRuleCacheExpirationAction(DeliveryRuleActionName name, CacheExpirationActionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public CacheExpirationActionParameters Parameters { get; set; }
    }
}
