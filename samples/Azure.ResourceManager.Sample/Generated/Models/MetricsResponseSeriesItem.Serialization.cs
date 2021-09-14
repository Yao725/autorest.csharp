// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class MetricsResponseSeriesItem
    {
        internal static MetricsResponseSeriesItem DeserializeMetricsResponseSeriesItem(JsonElement element)
        {
            Optional<string> metric = default;
            Optional<MetricsResponseSeriesItemUnit> unit = default;
            Optional<IReadOnlyList<MetricsResponseSeriesPropertiesItemsItem>> groups = default;
            Optional<IReadOnlyList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = new MetricsResponseSeriesItemUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetricsResponseSeriesPropertiesItemsItem> array = new List<MetricsResponseSeriesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsResponseSeriesPropertiesItemsItem.DeserializeMetricsResponseSeriesPropertiesItemsItem(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> array = new List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems.DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new MetricsResponseSeriesItem(metric.Value, Optional.ToNullable(unit), Optional.ToList(groups), Optional.ToList(data));
        }
    }
}
