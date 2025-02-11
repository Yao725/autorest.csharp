// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using ExactMatchInheritance;

namespace ExactMatchInheritance.Models
{
    internal partial class ExactMatchModel5ListResult
    {
        internal static ExactMatchModel5ListResult DeserializeExactMatchModel5ListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExactMatchModel5Data>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExactMatchModel5Data> array = new List<ExactMatchModel5Data>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExactMatchModel5Data.DeserializeExactMatchModel5Data(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExactMatchModel5ListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
