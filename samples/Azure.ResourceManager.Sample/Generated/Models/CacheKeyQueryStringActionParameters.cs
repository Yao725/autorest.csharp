// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Defines the parameters for the cache-key query string action. </summary>
    public partial class CacheKeyQueryStringActionParameters
    {
        /// <summary> Initializes a new instance of CacheKeyQueryStringActionParameters. </summary>
        /// <param name="queryStringBehavior"> Caching behavior for the requests. </param>
        public CacheKeyQueryStringActionParameters(QueryStringBehavior queryStringBehavior)
        {
            OdataType = "#Microsoft.Azure.Cdn.Models.DeliveryRuleCacheKeyQueryStringBehaviorActionParameters";
            QueryStringBehavior = queryStringBehavior;
        }

        /// <summary> Initializes a new instance of CacheKeyQueryStringActionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="queryStringBehavior"> Caching behavior for the requests. </param>
        /// <param name="queryParameters"> query parameters to include or exclude (comma separated). </param>
        internal CacheKeyQueryStringActionParameters(string odataType, QueryStringBehavior queryStringBehavior, string queryParameters)
        {
            OdataType = odataType;
            QueryStringBehavior = queryStringBehavior;
            QueryParameters = queryParameters;
        }

        public string OdataType { get; set; }
        /// <summary> Caching behavior for the requests. </summary>
        public QueryStringBehavior QueryStringBehavior { get; set; }
        /// <summary> query parameters to include or exclude (comma separated). </summary>
        public string QueryParameters { get; set; }
    }
}
