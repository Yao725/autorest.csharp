// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class CustomRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WritePropertyName("priority");
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("matchConditions");
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action");
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static CustomRule DeserializeCustomRule(JsonElement element)
        {
            string name = default;
            Optional<CustomRuleEnabledState> enabledState = default;
            int priority = default;
            IList<MatchCondition> matchConditions = default;
            ActionType action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabledState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledState = new CustomRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchConditions"))
                {
                    List<MatchCondition> array = new List<MatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchCondition.DeserializeMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = new ActionType(property.Value.GetString());
                    continue;
                }
            }
            return new CustomRule(name, Optional.ToNullable(enabledState), priority, matchConditions, action);
        }
    }
}
