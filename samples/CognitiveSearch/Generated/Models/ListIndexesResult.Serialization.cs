// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ListIndexesResult
    {
        internal static ListIndexesResult DeserializeListIndexesResult(JsonElement element)
        {
            IReadOnlyList<Index> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<Index> array = new List<Index>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Index.DeserializeIndex(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListIndexesResult(value);
        }
    }
}
