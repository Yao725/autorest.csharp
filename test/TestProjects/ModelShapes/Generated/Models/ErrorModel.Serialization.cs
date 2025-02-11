// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ModelShapes.Models
{
    internal partial class ErrorModel
    {
        internal static ErrorModel DeserializeErrorModel(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new ErrorModel(code.Value, status.Value);
        }
    }
}
