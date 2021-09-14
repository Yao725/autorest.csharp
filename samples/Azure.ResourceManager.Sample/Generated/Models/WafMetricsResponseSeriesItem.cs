// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The WafMetricsResponseSeriesItem. </summary>
    public partial class WafMetricsResponseSeriesItem
    {
        /// <summary> Initializes a new instance of WafMetricsResponseSeriesItem. </summary>
        internal WafMetricsResponseSeriesItem()
        {
            Unit = "count";
            Groups = new ChangeTrackingList<WafMetricsResponseSeriesPropertiesItemsItem>();
            Data = new ChangeTrackingList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
        }

        /// <summary> Initializes a new instance of WafMetricsResponseSeriesItem. </summary>
        /// <param name="metric"></param>
        /// <param name="unit"></param>
        /// <param name="groups"></param>
        /// <param name="data"></param>
        internal WafMetricsResponseSeriesItem(string metric, string unit, IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem> groups, IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> data)
        {
            Metric = metric;
            Unit = unit;
            Groups = groups;
            Data = data;
        }

        public string Metric { get; }
        public string Unit { get; }
        public IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem> Groups { get; }
        public IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> Data { get; }
    }
}
