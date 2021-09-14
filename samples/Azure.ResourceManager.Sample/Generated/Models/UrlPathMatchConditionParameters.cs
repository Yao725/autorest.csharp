// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines the parameters for UrlPath match conditions. </summary>
    public partial class UrlPathMatchConditionParameters
    {
        /// <summary> Initializes a new instance of UrlPathMatchConditionParameters. </summary>
        /// <param name="operator"> Describes operator to be matched. </param>
        public UrlPathMatchConditionParameters(UrlPathOperator @operator)
        {
            OdataType = "#Microsoft.Azure.Cdn.Models.DeliveryRuleUrlPathMatchConditionParameters";
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<Transform>();
        }

        /// <summary> Initializes a new instance of UrlPathMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal UrlPathMatchConditionParameters(string odataType, UrlPathOperator @operator, bool? negateCondition, IList<string> matchValues, IList<Transform> transforms)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        public string OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public UrlPathOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<Transform> Transforms { get; }
    }
}
