// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtOperations;

namespace MgmtOperations.Models
{
    internal partial class UnpatchableResourceListResult
    {
        internal static UnpatchableResourceListResult DeserializeUnpatchableResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<UnpatchableResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UnpatchableResourceData> array = new List<UnpatchableResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UnpatchableResourceData.DeserializeUnpatchableResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new UnpatchableResourceListResult(Optional.ToList(value));
        }
    }
}
