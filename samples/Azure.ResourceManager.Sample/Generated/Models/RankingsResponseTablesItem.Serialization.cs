// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class RankingsResponseTablesItem
    {
        internal static RankingsResponseTablesItem DeserializeRankingsResponseTablesItem(JsonElement element)
        {
            Optional<string> ranking = default;
            Optional<IReadOnlyList<RankingsResponseTablesPropertiesItemsItem>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ranking"))
                {
                    ranking = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RankingsResponseTablesPropertiesItemsItem> array = new List<RankingsResponseTablesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RankingsResponseTablesPropertiesItemsItem.DeserializeRankingsResponseTablesPropertiesItemsItem(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new RankingsResponseTablesItem(ranking.Value, Optional.ToList(data));
        }
    }
}
