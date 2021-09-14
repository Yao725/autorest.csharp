// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    internal partial class AFDEndpointListResult
    {
        internal static AFDEndpointListResult DeserializeAFDEndpointListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AFDEndpointData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AFDEndpointData> array = new List<AFDEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AFDEndpointData.DeserializeAFDEndpointData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AFDEndpointListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
