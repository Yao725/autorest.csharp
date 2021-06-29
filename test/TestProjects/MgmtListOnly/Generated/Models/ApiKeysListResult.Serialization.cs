// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    public partial class ApiKeysListResult
    {
        internal static ApiKeysListResult DeserializeApiKeysListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApiKey>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApiKey> array = new List<ApiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiKey.DeserializeApiKey(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ApiKeysListResult(Optional.ToList(value));
        }
    }
}
