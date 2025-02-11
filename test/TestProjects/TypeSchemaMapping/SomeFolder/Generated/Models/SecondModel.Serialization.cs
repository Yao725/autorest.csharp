// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using NamespaceForEnums;

namespace TypeSchemaMapping.Models
{
    internal partial class SecondModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IntProperty))
            {
                writer.WritePropertyName("StringProperty"u8);
                writer.WriteNumberValue(IntProperty);
            }
            if (Optional.IsCollectionDefined(DictionaryProperty))
            {
                writer.WritePropertyName("DictionaryProperty"u8);
                writer.WriteStartObject();
                foreach (var item in DictionaryProperty)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DaysOfWeek))
            {
                writer.WritePropertyName("DaysOfWeek"u8);
                writer.WriteStringValue(DaysOfWeek.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SecondModel DeserializeSecondModel(JsonElement element)
        {
            Optional<int> stringProperty = default;
            Optional<IReadOnlyDictionary<string, string>> dictionaryProperty = default;
            Optional<CustomDaysOfWeek> daysOfWeek = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("StringProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stringProperty = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("DictionaryProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    dictionaryProperty = dictionary;
                    continue;
                }
                if (property.NameEquals("DaysOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    daysOfWeek = new CustomDaysOfWeek(property.Value.GetString());
                    continue;
                }
            }
            return new SecondModel(stringProperty, Optional.ToDictionary(dictionaryProperty), Optional.ToNullable(daysOfWeek));
        }
    }
}
